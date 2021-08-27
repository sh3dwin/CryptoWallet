from yfinance import ticker

if __name__ == '__main__':

    option = "updateValue"
    print("Getting Bitcoin value information...")
    btc = ticker.Ticker("BTC-USD")
    print("Getting Ethereum value information...")
    eth = ticker.Ticker("ETH-USD")
    print("Getting VeChain value information...")
    vet = ticker.Ticker("VET-USD")
    print("Getting DogeCoin value information...")
    doge = ticker.Ticker("DOGE-USD")
    print("Getting Cardano value information...")
    ada = ticker.Ticker("ADA-USD")
    print("Getting Solana value information...")
    sol = ticker.Ticker("SOL1-USD")
    print("Getting BitcoinCash value information...")
    bch = ticker.Ticker("BCH-USD")

    fileBTC = open("../data/dataBTC.txt", "w", 1)
    fileBTC.write(btc.history().to_string())
    fileBTC.close()
    print("Done...")
    fileETH = open("../data/dataETH.txt", "w", 1)
    fileETH.write(eth.history().to_string())
    fileETH.close()
    print("Done...")
    fileVET = open("../data/dataVET.txt", "w", 1)
    fileVET.write(vet.history().to_string())
    fileVET.close()
    print("Done...")
    fileDOGE = open("../data/dataDOGE.txt", "w", 1)
    fileDOGE.write(doge.history().to_string())
    fileDOGE.close()
    print("Done...")
    fileADA = open("../data/dataADA.txt", "w", 1)
    fileADA.write(ada.history().to_string())
    fileADA.close()
    print("Done...")
    fileSOL = open("../data/dataSOL.txt", "w", 1)
    fileSOL.write(sol.history().to_string())
    fileSOL.close()
    print("Done...")
    fileBCH = open("../data/dataBCH.txt", "w", 1)
    fileBCH.write(bch.history().to_string())
    fileBCH.close()
    print("Done...")
    valueFile = open("../data/valueData.txt", "w")
    print("Getting price information...")
    valueFile.write("{}\n".format(btc.info["regularMarketPrice"]))
    print("BTC Done...")
    valueFile.write("{}\n".format(eth.info["regularMarketPrice"]))
    print("ETH Done...")
    valueFile.write("{}\n".format(ada.info["regularMarketPrice"]))
    print("ADA Done...")
    valueFile.write("{}\n".format(doge.info["regularMarketPrice"]))
    print("DOGE Done...")
    valueFile.write("{}\n".format(sol.info["regularMarketPrice"]))
    print("SOL Done...")
    valueFile.write("{}\n".format(bch.info["regularMarketPrice"]))
    print("BCH Done...")
    valueFile.write("{}\n".format(vet.info["regularMarketPrice"]))
    print("VET Done...")

    valueFile.close()


# regularMarketPrice
# dayHigh
# dayLow


