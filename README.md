﻿#**CryptoWallet documentation**

#**Windows Forms Project by: Kiril Avramoski**

1. **Опис на апликацијата**
	Оваа апликација е еден вид сметка за крипто-валути каде корисникот може да купува и да разменува крипто-валути. Корисникот може да купува и разменува помеѓу 7 крипто валути и тоа
BTC (Bitcoin), ETH (Ethereum), ADA (Cardano), DOGE (DogeCoin), SOL (Solana), BCH (BitcoinCash), VET (VeChain). Вредностите на секои од овие валути се земени преку Python скрипта користејќи го модулот yfinance (Ran Aroussi), кои во реално време зема информации од Yahoo! finance.
2. **Упатство за користење**
	2.1 **Најавување во системот**
	При уклучување на апликацијата, на корисникот му е претставена форма за внесување на корисничко име и лозинка.

	2.2 **Регистрирање во системот**
	Доколку корисникот не е регистриран во системот, тој има можност да се регистрира со кликање на Create an Account (види слика 1). Откако корисникот ќе го направи тоа, му се појавува форма каде може да внесе корисничко име и лозинка, и доколку се е во ред информациите се зачувани во системот и сега корисникот може да се најави во системот.

	2.3 **Главна форма**
	Во главната форма корисникот има пристап до повеќе информации. Во горниот лев дел од формата е претставено името на корисникот како и вкупната вреднос на крипто-валутите што ги поседува. Со кликање на ”Details”, корисникот добива детален приказ за секоја крипто-валута посебно (колку количина поседува и вредноста на таа количина). Во ”Transaction history” делот, корисникот може да ги виде сите акции кои ги извршил во апликацијата (купување и разменување).
	На графикот се претставени цените на избраната крипто-валута (корисникот ја бира истата со кликање на копчињата за соодветната валута) во последните 31 дена. Под графикот е дадена моменталната цена на пазарот, а десно од тоа дадени се опциите за купување и разменување.
	Со кликање на ”Log Out” копчето, корисникот може да се врати во формата за најавување, а со класично затварање на прозорецот, корисникот ја напушта апликацијата.

	2.4 **Купување крипто-валути**
	Кога корисникот ќе кликне на копчето за купување, се појавува форма каде корисникот може да избере која крипто-валута сака да ја купи. После тоа избира количина ($15, $50 или $100), а потоа клика на копчето ”Preview” по што се прикажува колкава количина добива за таа цена, копчето ”Preview” станува “Confirm” и притоа корисникот има 4 секунди да ја потврди транзакцијата. Со потврдата се затвора формата и се додава купената количина на сметката на корисникот.

	2.5 **Разменување на крипто-валути**
	Откако ќе се отвори формата за размена, корисникот бира од која во која валута сака да ја направи размената, а притоа не е дозволено да конвертира во истата валута илли да конвертира поголема количина од таа што ја има на располагање. Со кликање на копчето за потврда се врши размената и се затвора формата.

3. **Имплементација**
	Основната класа која има пристап до сите информации е CryptoWallet формата, која е всушност формата за најавување во системот. CryptoWallet класата во себе содржи објект од класата UserDoc и ArrayList од класата CryptoValue
	3.1. **UserDoc**
	Оваа класа ги чува информациите за сите корисници во системот (корисничко име и лозинка). При стартување на програмата, конструкторот на оваа класа пристапува до текст датотека со име ”userData.txt”, каде се зачувани информациите за предходно најавените корисници. Со најавување во системот, logInUser(username, password) функцијата го враќа корисникот со соодветното корисничко име и лозинка и ја креира главната форма со овој корисник како аргумент.
	Во User класата се зачувани корисничкото име, лозинката, историјата на транзакции, како и сметката (објект од Wallet класа). Преку оваа класа главната форма има пристап до состојбата на корисникот како и до неговата историја. Оваа класа има функции преку кои може да се менува состојбата на Wallet објектот.
Wallet класата е едноставна класа која во себе содржи информации за количина на секоја од крипто-валутите во системот.
	3.2 **CryptoValue**
	Во оваа класа се зачувани сите потребни информации за секоја поеднинечна крипто-валута во системот. Секој објект од оваа класа има име, моментална вредност на берзата според информации од Yahoo! Finance, како и информации за најголема и најмала вредност во текот на еден ден, за последните 31 дена. Овие информации се земаат од Yahoo! finance преку Python скрипта користејќи го ”yfinance” модулот. Оваа скрипта ги зачувува овии информации во датотека со име this.code + “Data.txt” (каде this.code е кодот за соодветната валута, пр. btc, eth итн.), од каде подоцна се прочитани при креирање на објект од оваа класа. 
	3.3 **Функции**
	public void draw(Graphics graphic, float x1, float y1, float x2, float y2);
	Како аргументи оваа функција ја прима графиката врз која ќе се извршува Paint настанот, како и големината на истата. На почетокот се пресметува висината и ширината на графиката. Потоа се пресметува растојанието помеѓу податоците, а на крај се земаат максималната и минималната вредност на валутата во последните 31 дена кои подоцна ќе се користат за нормализација на податоците. После тоа во циклус се пресметува разликата помеѓу максималната и минималната вредност на валутата во одреден ден, и во зависност од тоа дали максималната вредност во овој ден е поголема или помала од максималната вредност во предходниот ден, денешната разлика се црта со зелена или црвена боја соодветно. По овој чекор се гледа дали наредниот ден има покачување во максималната вредност, и доколку има, се црта линија до минималната вредност од наредниот ден со зелена боја, а во спротивно со црвена. На крај се цртаат две испрекинати линии кои претставуваат 95% од максималната вредност во последниот месец, и 105% од минималната вредност во последниот месец, со цел корисникот да има претстава за разликите на цените во тој месец
	private void convertPreviewButton_Click(object sender, EventArgs e);
	Оваа функција се повикува при кликање на копчето за конвертирање на внесената крипто валута во таа што ја избрал корисникот. Конверзијата е направена така што се зема количината која ја внесол корисникот, и доколку е валидна (корисникот има доволно средства), оваа количина се множи со количникот помеѓу моменталната вредност на валутата која ја конвертира и моменталната вредност на валутата во која се врши конверзијата. По овој настан корисникот има опција да ја потврди размената доколку нема проблеми.
