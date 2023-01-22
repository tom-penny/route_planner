using static RoutePlanner.Direction;
using static RoutePlanner.Stations;
using static RoutePlanner.TubeLine;
using RoutePlanner.Model.DataAccess;
using RoutePlanner.Model.Entities;

namespace RoutePlanner;

public static class Stations
{
    public static Station ActonCentral { get; } = DataContext.Add(new("Acton Central", Zone.Zone3));
    public static Station Aldgate { get; } = DataContext.Add(new("Aldgate", Zone.Zone1));
    public static Station BakerStreet { get; } = DataContext.Add(new("Baker Street", Zone.Zone1));
    public static Station Bank { get; } = DataContext.Add(new("Bank", Zone.Zone1));
    public static Station Barbican { get; } = DataContext.Add(new("Barbican", Zone.Zone1));
    public static Station BaronsCourt { get; } = DataContext.Add(new("Barons Court", Zone.Zone2));
    public static Station Bayswater { get; } = DataContext.Add(new("Bayswater", Zone.Zone1));
    public static Station Bermondsey { get; } = DataContext.Add(new("Bermondsey", Zone.Zone2));
    public static Station Blackfriars { get; } = DataContext.Add(new Station("Blackfriars", Zone.Zone1));
    public static Station BlackhorseRoad { get; } = DataContext.Add(new("Blackhorse Road", Zone.Zone3));
    public static Station BondStreet { get; } = DataContext.Add(new Station("Bond Street", Zone.Zone1));
    public static Station Brixton { get; } = DataContext.Add(new Station("Brixton", Zone.Zone2));
    public static Station BrondesburyPark { get; } = DataContext.Add(new Station("Brondesbury Park", Zone.Zone2));
    public static Station Brondesbury { get; } = DataContext.Add(new Station("Brondesbury", Zone.Zone2));
    public static Station CaledonianRoadAndBarnsbury { get; } = DataContext.Add(new Station("Caledonian Road & Barnsbury", Zone.Zone2));
    public static Station CamdenRoad { get; } = DataContext.Add(new Station("Camden Road", Zone.Zone2));
    public static Station CanadaWater { get; } = DataContext.Add(new Station("Canada Water", Zone.Zone2));
    public static Station CanaryWharf { get; } = DataContext.Add(new Station("Canary Wharf", Zone.Zone2));
    public static Station CanningTown { get; } = DataContext.Add(new Station("Canning Town", Zone.Zone2));
    public static Station CannonStreet { get; } = DataContext.Add(new Station("Cannon Street", Zone.Zone1));
    public static Station Canonbury { get; } = DataContext.Add(new Station("Canonbury", Zone.Zone2));
    public static Station CanonsPark { get; } = DataContext.Add(new Station("Canons Park", Zone.Zone5));
    public static Station ChanceryLane { get; } = DataContext.Add(new Station("Chancery Lane", Zone.Zone1));
    public static Station CharingCross { get; } = DataContext.Add(new Station("Charing Cross", Zone.Zone1));
    public static Station ClaphamJunction { get; } = DataContext.Add(new Station("Clapham Junction", Zone.Zone2));
    public static Station CoventGarden { get; } = DataContext.Add(new Station("Covent Garden", Zone.Zone1));
    public static Station DalstonKingsland { get; } = DataContext.Add(new Station("Dalston Kingsland", Zone.Zone2));
    public static Station DollisHill { get; } = DataContext.Add(new Station("Dollis Hill", Zone.Zone3));
    public static Station EarlsCourt { get; } = DataContext.Add(new Station("Earl's Court", Zone.Zone1));
    public static Station EdgwareRoad { get; } = DataContext.Add(new Station("Edgware Road", Zone.Zone1));
    public static Station Embankment { get; } = DataContext.Add(new Station("Embankment", Zone.Zone1));
    public static Station EustonSquare { get; } = DataContext.Add(new Station("Euston Square", Zone.Zone1));
    public static Station Euston { get; } = DataContext.Add(new Station("Euston", Zone.Zone1));
    public static Station Farringdon { get; } = DataContext.Add(new Station("Farringdon", Zone.Zone1));
    public static Station FinchleyRoadAndFrognal { get; } = DataContext.Add(new Station("Finchley Road & Frognal", Zone.Zone2));
    public static Station FinchleyRoad { get; } = DataContext.Add(new Station("Finchley Road", Zone.Zone2));
    public static Station FinsburyPark { get; } = DataContext.Add(new Station("Finsbury Park", Zone.Zone2));
    public static Station GloucesterRoad { get; } = DataContext.Add(new Station("Gloucester Road", Zone.Zone1));
    public static Station GoldhawkRoad { get; } = DataContext.Add(new Station("Goldhawk Road", Zone.Zone2));
    public static Station GoodgeStreet { get; } = DataContext.Add(new Station("Goodge Street", Zone.Zone1));
    public static Station GospelOak { get; } = DataContext.Add(new Station("Gospel Oak", Zone.Zone2));
    public static Station GreatPortlandStreet { get; } = DataContext.Add(new Station("Great Portland Street", Zone.Zone1));
    public static Station GreenPark { get; } = DataContext.Add(new Station("Green Park", Zone.Zone1));
    public static Station Gunnersbury { get; } = DataContext.Add(new Station("Gunnersbury", Zone.Zone3));
    public static Station HackneyCentral { get; } = DataContext.Add(new Station("Hackney Central", Zone.Zone2));
    public static Station HackneyWick { get; } = DataContext.Add(new Station("Hackney Wick", Zone.Zone2));
    public static Station Hammersmith { get; } = DataContext.Add(new Station("Hammersmith", Zone.Zone2));
    public static Station HampsteadHeath { get; } = DataContext.Add(new Station("Hampstead Heath", Zone.Zone2));
    public static Station HighStreetKensington { get; } = DataContext.Add(new Station("High Street Kensington", Zone.Zone1));
    public static Station HighburyAndIslington { get; } = DataContext.Add(new Station("Highbury & Islington", Zone.Zone2));
    public static Station Holborn { get; } = DataContext.Add(new Station("Holborn", Zone.Zone1));
    public static Station HollandPark { get; } = DataContext.Add(new Station("Holland Park", Zone.Zone2));
    public static Station Homerton { get; } = DataContext.Add(new Station("Homerton", Zone.Zone2));
    public static Station HydeParkCorner { get; } = DataContext.Add(new Station("Hyde Park Corner", Zone.Zone1));
    public static Station ImperialWharf { get; } = DataContext.Add(new Station("Imperial Wharf", Zone.Zone2));
    public static Station KensalRise { get; } = DataContext.Add(new Station("Kensal Rise", Zone.Zone2));
    public static Station KensingtonOlympia { get; } = DataContext.Add(new Station("Kensington Olympia", Zone.Zone2));
    public static Station KentishTownWest { get; } = DataContext.Add(new Station("Kentish Town West", Zone.Zone2));
    public static Station KewGardens { get; } = DataContext.Add(new Station("Kew Gardens", Zone.Zone3));
    public static Station Kilburn { get; } = DataContext.Add(new Station("Kilburn", Zone.Zone2));
    public static Station KingsCrossStPancras { get; } = DataContext.Add(new Station("King's Cross St. Pancras", Zone.Zone1));
    public static Station Kingsbury { get; } = DataContext.Add(new Station("Kingsbury", Zone.Zone4));
    public static Station Knightsbridge { get; } = DataContext.Add(new Station("Knightsbridge", Zone.Zone1));
    public static Station LadbrokeGrove { get; } = DataContext.Add(new Station("Ladbroke Grove", Zone.Zone2));
    public static Station LancasterGate { get; } = DataContext.Add(new Station("Lancaster Gate", Zone.Zone1));
    public static Station LatimerRoad { get; } = DataContext.Add(new Station("Latimer Road", Zone.Zone2));
    public static Station LeicesterSquare { get; } = DataContext.Add(new Station("Leicester Square", Zone.Zone1));
    public static Station LiverpoolStreet { get; } = DataContext.Add(new Station("Liverpool Street", Zone.Zone1));
    public static Station LondonBridge { get; } = DataContext.Add(new Station("London Bridge", Zone.Zone1));
    public static Station MansionHouse { get; } = DataContext.Add(new Station("Mansion House", Zone.Zone1));
    public static Station MarbleArch { get; } = DataContext.Add(new Station("Marble Arch", Zone.Zone1));
    public static Station Monument { get; } = DataContext.Add(new Station("Monument", Zone.Zone1));
    public static Station Moorgate { get; } = DataContext.Add(new Station("Moorgate", Zone.Zone1));
    public static Station Neasden { get; } = DataContext.Add(new Station("Neasden", Zone.Zone3));
    public static Station NorthGreenwich { get; } = DataContext.Add(new Station("North Greenwich", Zone.Zone2));
    public static Station NottingHillGate { get; } = DataContext.Add(new Station("Notting Hill Gate", Zone.Zone1));
    public static Station OxfordCircus { get; } = DataContext.Add(new Station("Oxford Circus", Zone.Zone1));
    public static Station Paddington { get; } = DataContext.Add(new Station("Paddington", Zone.Zone1));
    public static Station PiccadillyCircus { get; } = DataContext.Add(new Station("Piccadilly Circus", Zone.Zone1));
    public static Station Pimlico { get; } = DataContext.Add(new Station("Pimlico", Zone.Zone1));
    public static Station Queensbury { get; } = DataContext.Add(new Station("Queensbury", Zone.Zone4));
    public static Station Queensway { get; } = DataContext.Add(new Station("Queensway", Zone.Zone1));
    public static Station RegentsPark { get; } = DataContext.Add(new Station("Regent's Park", Zone.Zone1));
    public static Station Richmond { get; } = DataContext.Add(new Station("Richmond", Zone.Zone4));
    public static Station RoyalOak { get; } = DataContext.Add(new Station("Royal Oak", Zone.Zone2));
    public static Station RussellSquare { get; } = DataContext.Add(new Station("Russell Square", Zone.Zone1));
    public static Station SevenSisters { get; } = DataContext.Add(new Station("Seven Sisters", Zone.Zone3));
    public static Station ShepherdsBushMarket { get; } = DataContext.Add(new Station("Shepherd's Bush Market", Zone.Zone2));
    public static Station ShepherdsBush { get; } = DataContext.Add(new Station("Shepherd's Bush", Zone.Zone2));
    public static Station SloaneSquare { get; } = DataContext.Add(new Station("Sloane Square", Zone.Zone1));
    public static Station SouthActon { get; } = DataContext.Add(new Station("South Acton", Zone.Zone3));
    public static Station SouthKensington { get; } = DataContext.Add(new Station("South Kensington", Zone.Zone1));
    public static Station Southwark { get; } = DataContext.Add(new Station("Southwark", Zone.Zone1));
    public static Station StJamesPark { get; } = DataContext.Add(new Station("St. James's Park", Zone.Zone1));
    public static Station StJohnsWood { get; } = DataContext.Add(new Station("St. John's Wood", Zone.Zone2));
    public static Station StPauls { get; } = DataContext.Add(new Station("St. Paul's", Zone.Zone1));
    public static Station Stanmore { get; } = DataContext.Add(new Station("Stanmore", Zone.Zone5));
    public static Station Stockwell { get; } = DataContext.Add(new Station("Stockwell", Zone.Zone2));
    public static Station Stratford { get; } = DataContext.Add(new Station("Stratford", Zone.Zone2));
    public static Station SwissCottage { get; } = DataContext.Add(new Station("Swiss Cottage", Zone.Zone2));
    public static Station Temple { get; } = DataContext.Add(new Station("Temple", Zone.Zone1));
    public static Station TottenhamCourtRoad { get; } = DataContext.Add(new Station("Tottenham Court Road", Zone.Zone1));
    public static Station TottenhamHale { get; } = DataContext.Add(new Station("Tottenham Hale", Zone.Zone3));
    public static Station TowerHill { get; } = DataContext.Add(new Station("Tower Hill", Zone.Zone1));
    public static Station Vauxhall { get; } = DataContext.Add(new Station("Vauxhall", Zone.Zone1));
    public static Station Victoria { get; } = DataContext.Add(new Station("Victoria", Zone.Zone1));
    public static Station WalthamstowCentral { get; } = DataContext.Add(new Station("Walthamstow Central", Zone.Zone3));
    public static Station WarrenStreet { get; } = DataContext.Add(new Station("Warren Street", Zone.Zone1));
    public static Station Waterloo { get; } = DataContext.Add(new Station("Waterloo", Zone.Zone1));
    public static Station WembleyPark { get; } = DataContext.Add(new Station("Wembley Park", Zone.Zone4));
    public static Station WestBrompton { get; } = DataContext.Add(new Station("West Brompton", Zone.Zone2));
    public static Station WestHam { get; } = DataContext.Add(new Station("West Ham", Zone.Zone2));
    public static Station WestHampstead { get; } = DataContext.Add(new Station("West Hampstead", Zone.Zone2));
    public static Station WestKensington { get; } = DataContext.Add(new Station("West Kensington", Zone.Zone2));
    public static Station WestbournePark { get; } = DataContext.Add(new Station("Westbourne Park", Zone.Zone2));
    public static Station Westminster { get; } = DataContext.Add(new Station("Westminster", Zone.Zone1));
    public static Station WillesdenGreen { get; } = DataContext.Add(new Station("Willesden Green", Zone.Zone2));
    public static Station WillesdenJunction { get; } = DataContext.Add(new Station("Willesden Junction", Zone.Zone2));
    public static Station WoodLane { get; } = DataContext.Add(new Station("Wood Lane", Zone.Zone2));
}


public class Connections
{
    public static void AddConnections()
    {
        //Acton Central
        ActonCentral.AddConnection(WillesdenJunction, Overground, Eastbound, 6.00d);
        ActonCentral.AddConnection(SouthActon, Overground, Westbound, 3.00d);
        //Aldgate
        Aldgate.AddConnection(LiverpoolStreet, Circle, Inner, 1.75d);
        Aldgate.AddConnection(TowerHill, Circle, Outer, 1.37d);
        //Baker
        BakerStreet.AddConnection(RegentsPark, Bakerloo, Southbound, 1.68d);
        BakerStreet.AddConnection(BondStreet, Jubilee, Eastbound, 2.10d);
        BakerStreet.AddConnection(StJohnsWood, Jubilee, Westbound, 2.85d);
        BakerStreet.AddConnection(EdgwareRoad, Circle, Inner, 1.88d);
        BakerStreet.AddConnection(GreatPortlandStreet, Circle, Outer, 1.90d);
        //Bank
        Bank.AddConnection(LiverpoolStreet, Central, Eastbound, 1.62d);
        Bank.AddConnection(StPauls, Central, Westbound, 1.63d);
        Bank.AddConnection(LondonBridge, Northern, Southbound, 1.55d);
        Bank.AddConnection(Moorgate, Northern, Northbound, 1.77d);
        //Barbican
        Barbican.AddConnection(Farringdon, Circle, Inner, 1.2d);
        Barbican.AddConnection(Moorgate, Circle, Outer, 1.32d);
        //BaronsCourt
        BaronsCourt.AddConnection(EarlsCourt, Piccadilly, Eastbound, 2.55d);
        BaronsCourt.AddConnection(Hammersmith, Piccadilly, Westbound, 1.32d);
        BaronsCourt.AddConnection(Hammersmith, District, Westbound, 1.33d);
        BaronsCourt.AddConnection(WestKensington, District, Eastbound, 1.28d);
        //Bayswater
        Bayswater.AddConnection(NottingHillGate, Circle, Inner, 1.47d);
        Bayswater.AddConnection(Paddington, Circle, Outer, 1.63d);
        Bayswater.AddConnection(NottingHillGate, District, Westbound, 1.47d);
        Bayswater.AddConnection(Paddington, District, Eastbound, 1.63d);
        //Bermondsey
        Bermondsey.AddConnection(CanadaWater, Jubilee, Eastbound, 1.48d);
        Bermondsey.AddConnection(LondonBridge, Jubilee, Westbound, 2.17d);
        //Blackfriars
        Blackfriars.AddConnection(MansionHouse, Circle, Inner, 1.52d);
        Blackfriars.AddConnection(Temple, Circle, Outer, 1.37d);
        //BlackhorseRoad
        BlackhorseRoad.AddConnection(TottenhamHale, TubeLine.Victoria, Southbound, 1.90d);
        BlackhorseRoad.AddConnection(WalthamstowCentral, TubeLine.Victoria, Northbound, 2.12d);
        //BondStreet
        BondStreet.AddConnection(OxfordCircus, Central, Eastbound, 1.10d);
        BondStreet.AddConnection(MarbleArch, Central, Westbound, 1.02d);
        BondStreet.AddConnection(GreenPark, Jubilee, Eastbound, 1.78d);
        BondStreet.AddConnection(BakerStreet, Jubilee, Westbound, 2.28d);
        //Brixton
        Brixton.AddConnection(Stockwell, TubeLine.Victoria, Northbound, 2.18d);
        //Brondesbury
        Brondesbury.AddConnection(BrondesburyPark, Overground, Westbound, 1.00d);
        Brondesbury.AddConnection(WestHampstead, Overground, Eastbound, 2.00d);
        //BrondesburyPark
        BrondesburyPark.AddConnection(KensalRise, Overground, Westbound, 2.00d);
        BrondesburyPark.AddConnection(Brondesbury, Overground, Eastbound, 2.00d);
        //CaledonianRoadandBarnsbury
        CaledonianRoadAndBarnsbury.AddConnection(CamdenRoad, Overground, Westbound, 3.00d);
        CaledonianRoadAndBarnsbury.AddConnection(HighburyAndIslington, Overground, Eastbound, 3.00d);
        //CamdenRoad
        CamdenRoad.AddConnection(KentishTownWest, Overground, Westbound, 2.00d);
        CamdenRoad.AddConnection(CaledonianRoadAndBarnsbury, Overground, Eastbound, 3.00d);
        //CanadaWater
        CanadaWater.AddConnection(CanaryWharf, Jubilee, Eastbound, 2.50d);
        CanadaWater.AddConnection(Bermondsey, Jubilee, Westbound, 1.52d);
        //CanaryWharf
        CanaryWharf.AddConnection(NorthGreenwich, Jubilee, Eastbound, 2.23d);
        CanaryWharf.AddConnection(CanadaWater, Jubilee, Westbound, 2.63d);
        //CanningTown
        CanningTown.AddConnection(WestHam, Jubilee, Eastbound, 2.15d);
        CanningTown.AddConnection(NorthGreenwich, Jubilee, Westbound, 2.17d);
        //CannonStreet
        CannonStreet.AddConnection(Monument, Circle, Inner, 0.97d);
        CannonStreet.AddConnection(MansionHouse, Circle, Outer, 0.93d);
        //Canonbury
        Canonbury.AddConnection(HighburyAndIslington, Overground, Westbound, 3.00d);
        Canonbury.AddConnection(DalstonKingsland, Overground, Eastbound, 2.00d);
        //CanonsPark
        CanonsPark.AddConnection(Queensbury, Jubilee, Eastbound, 1.93d);
        CanonsPark.AddConnection(Stanmore, Jubilee, Westbound, 2.87d);
        //ChanceryLane
        ChanceryLane.AddConnection(StPauls, Central, Eastbound, 1.52d);
        ChanceryLane.AddConnection(Holborn, Central, Westbound, 0.85d);
        //CharingCross
        CharingCross.AddConnection(Embankment, Bakerloo, Southbound, 0.95d);
        CharingCross.AddConnection(PiccadillyCircus, Bakerloo, Northbound, 1.60d);
        CharingCross.AddConnection(Embankment, Northern, Southbound, 0.80d);
        CharingCross.AddConnection(LeicesterSquare, Northern, Northbound, 1.17d);
        //ClaphamJunction
        ClaphamJunction.AddConnection(ImperialWharf, Overground, Eastbound, 4.00d);
        //CoventGarden
        CoventGarden.AddConnection(Holborn, Piccadilly, Eastbound, 1.40d);
        CoventGarden.AddConnection(LeicesterSquare, Piccadilly, Westbound, 0.77d);
        //DalstonKingsland
        DalstonKingsland.AddConnection(Canonbury, Overground, Westbound, 2.00d);
        DalstonKingsland.AddConnection(HackneyCentral, Overground, Eastbound, 2.00d);
        //DollisHill
        DollisHill.AddConnection(WillesdenGreen, Jubilee, Eastbound, 1.80d);
        DollisHill.AddConnection(Neasden, Jubilee, Westbound, 1.38d);
        //EarlsCourt
        EarlsCourt.AddConnection(GloucesterRoad, Piccadilly, Eastbound, 1.37d);
        EarlsCourt.AddConnection(BaronsCourt, Piccadilly, Westbound, 2.68d);
        EarlsCourt.AddConnection(KensingtonOlympia, District, Westbound, 3.08d);
        EarlsCourt.AddConnection(WestBrompton, District, Westbound, 1.42d);
        EarlsCourt.AddConnection(WestKensington, District, Westbound, 1.62d);
        EarlsCourt.AddConnection(HighStreetKensington, District, Eastbound, 3.05d);
        EarlsCourt.AddConnection(GloucesterRoad, District, Eastbound, 1.92d);
        //EdgwareRoad
        EdgwareRoad.AddConnection(Paddington, Circle, Inner, 1.85d);
        EdgwareRoad.AddConnection(Paddington, Circle, Inner, 2.08d);
        EdgwareRoad.AddConnection(BakerStreet, Circle, Outer, 1.47d);
        //Embankment
        Embankment.AddConnection(Waterloo, Bakerloo, Southbound, 1.43d);
        Embankment.AddConnection(CharingCross, Bakerloo, Northbound, 0.97d);
        Embankment.AddConnection(Temple, Circle, Inner, 1.37d);
        Embankment.AddConnection(Westminster, Circle, Outer, 1.40d);
        Embankment.AddConnection(Waterloo, Northern, Southbound, 1.37d);
        Embankment.AddConnection(CharingCross, Northern, Northbound, 0.87d);
        //Euston
        Euston.AddConnection(WarrenStreet, TubeLine.Victoria, Southbound, 1.30d);
        Euston.AddConnection(KingsCrossStPancras, TubeLine.Victoria, Northbound, 1.35d);
        Euston.AddConnection(KingsCrossStPancras, Northern, Southbound, 1.53d);
        Euston.AddConnection(WarrenStreet, Northern, Southbound, 1.18d);
        //EustonSquare
        EustonSquare.AddConnection(GreatPortlandStreet, Circle, Inner, 1.30d);
        EustonSquare.AddConnection(KingsCrossStPancras, Circle, Outer, 1.75d);
        //Farringdon
        Farringdon.AddConnection(KingsCrossStPancras, Circle, Inner, 3.12d);
        Farringdon.AddConnection(Barbican, Circle, Outer, 1.22d);
        //FinchleyRoad
        FinchleyRoad.AddConnection(SwissCottage, Jubilee, Eastbound, 1.18d);
        FinchleyRoad.AddConnection(WestHampstead, Jubilee, Westbound, 1.20d);
        //FinchleyRoadAndFrognal
        FinchleyRoadAndFrognal.AddConnection(WestHampstead, Overground, Westbound, 2.00d);
        FinchleyRoadAndFrognal.AddConnection(HampsteadHeath, Overground, Eastbound, 3.00d);
        //FinsburyPark
        FinsburyPark.AddConnection(HighburyAndIslington, TubeLine.Victoria, Southbound, 2.90d);
        FinsburyPark.AddConnection(SevenSisters, TubeLine.Victoria, Northbound, 4.25d);
        //GloucesterRoad
        GloucesterRoad.AddConnection(SouthKensington, Circle, Inner, 1.43d);
        GloucesterRoad.AddConnection(HighStreetKensington, Circle, Outer, 2.23d);
        GloucesterRoad.AddConnection(SouthKensington, Piccadilly, Eastbound, 1.28d);
        GloucesterRoad.AddConnection(EarlsCourt, Piccadilly, Westbound, 1.37d);
        //GoldhawkRoad
        GoldhawkRoad.AddConnection(Hammersmith, Circle, Inner, 2.43d);
        GoldhawkRoad.AddConnection(ShepherdsBushMarket, Circle, Outer, 1.15d);
        //GoodgeStreet
        GoodgeStreet.AddConnection(TottenhamCourtRoad, Northern, Southbound, 1.32d);
        GoodgeStreet.AddConnection(WarrenStreet, Northern, Northbound, 1.07d);
        //GospelOak
        GospelOak.AddConnection(HampsteadHeath, Overground, Westbound, 2.00d);
        GospelOak.AddConnection(KentishTownWest, Overground, Eastbound, 2.00d);
        //GreatPortlandStreet
        GreatPortlandStreet.AddConnection(BakerStreet, Circle, Inner, 1.57d);
        GreatPortlandStreet.AddConnection(EustonSquare, Circle, Outer, 1.25d);
        //GreenPark
        GreenPark.AddConnection(Westminster, Jubilee, Eastbound, 1.87d);
        GreenPark.AddConnection(BondStreet, Jubilee, Westbound, 1.82d);
        GreenPark.AddConnection(PiccadillyCircus, Piccadilly, Eastbound, 1.10d);
        GreenPark.AddConnection(HydeParkCorner, Piccadilly, Westbound, 1.73d);
        GreenPark.AddConnection(Stations.Victoria, TubeLine.Victoria, Southbound, 1.88d);
        GreenPark.AddConnection(OxfordCircus, TubeLine.Victoria, Northbound, 1.97d);
        //Gunnersbury
        Gunnersbury.AddConnection(KewGardens, Overground, Westbound, 3.00d);
        Gunnersbury.AddConnection(SouthActon, Overground, Eastbound, 3.00d);
        //HackneyCentral
        HackneyCentral.AddConnection(DalstonKingsland, Overground, Westbound, 2.00d);
        HackneyCentral.AddConnection(Homerton, Overground, Eastbound, 2.00d);
        //HackneyWick
        HackneyWick.AddConnection(Homerton, Overground, Westbound, 3.00d);
        HackneyWick.AddConnection(Stratford, Overground, Eastbound, 7.00d);
        //Hammersmith
        Hammersmith.AddConnection(GoldhawkRoad, Circle, Outer, 2.05d);
        Hammersmith.AddConnection(BaronsCourt, Piccadilly, Eastbound, 1.38d);
        Hammersmith.AddConnection(BaronsCourt, District, Eastbound, 1.43d);
        //HampsteadHeath
        HampsteadHeath.AddConnection(FinchleyRoadAndFrognal, Overground, Westbound, 2.00d);
        HampsteadHeath.AddConnection(GospelOak, Overground, Eastbound, 2.00d);
        //HighStreetKensington
        HighStreetKensington.AddConnection(GloucesterRoad, Circle, Inner, 1.80d);
        HighStreetKensington.AddConnection(NottingHillGate, Circle, Outer, 1.68d);
        //HighburyAndIslington
        HighburyAndIslington.AddConnection(KingsCrossStPancras, TubeLine.Victoria, Southbound, 2.77d);
        HighburyAndIslington.AddConnection(FinsburyPark, TubeLine.Victoria, Northbound, 2.40d);
        HighburyAndIslington.AddConnection(CaledonianRoadAndBarnsbury, Overground, Westbound, 2.00d);
        HighburyAndIslington.AddConnection(Canonbury, Overground, Eastbound, 2.00d);
        //Holborn
        Holborn.AddConnection(ChanceryLane, Central, Eastbound, 0.87d);
        Holborn.AddConnection(TottenhamCourtRoad, Central, Westbound, 1.38d);
        Holborn.AddConnection(RussellSquare, Piccadilly, Eastbound, 1.55d);
        Holborn.AddConnection(CoventGarden, Piccadilly, Westbound, 1.53d);
        //HollandPark
        HollandPark.AddConnection(NottingHillGate, Central, Eastbound, 1.08d);
        HollandPark.AddConnection(ShepherdsBush, Central, Westbound, 1.52d);
        //Homerton
        Homerton.AddConnection(HackneyCentral, Overground, Westbound, 2.00d);
        Homerton.AddConnection(HackneyWick, Overground, Eastbound, 2.00d);
        //HydeParkCorner
        HydeParkCorner.AddConnection(GreenPark, Piccadilly, Eastbound, 1.73d);
        HydeParkCorner.AddConnection(Knightsbridge, Piccadilly, Westbound, 1.12d);
        //ImperialWharf
        ImperialWharf.AddConnection(ClaphamJunction, Overground, Westbound, 7.00d);
        ImperialWharf.AddConnection(WestBrompton, Overground, Eastbound, 3.00d);
        //KensalRise
        KensalRise.AddConnection(WillesdenJunction, Overground, Westbound, 5.00d);
        KensalRise.AddConnection(BrondesburyPark, Overground, Eastbound, 2.00d);
        //KensingtonOlympia
        KensingtonOlympia.AddConnection(EarlsCourt, District, Eastbound, 2.73d);
        KensingtonOlympia.AddConnection(WestBrompton, Overground, Westbound, 3.00d);
        KensingtonOlympia.AddConnection(ShepherdsBush, Overground, Eastbound, 2.00d);
        //KentishTownWest
        KentishTownWest.AddConnection(GospelOak, Overground, Westbound, 4.00d);
        KentishTownWest.AddConnection(CamdenRoad, Overground, Eastbound, 4.00d);
        //KewGardens
        KewGardens.AddConnection(Richmond, Overground, Westbound, 5.00d);
        KewGardens.AddConnection(Gunnersbury, Overground, Eastbound, 3.00d);
        //Kilburn
        Kilburn.AddConnection(WestHampstead, Jubilee, Eastbound, 1.63d);
        Kilburn.AddConnection(WillesdenGreen, Jubilee, Westbound, 2.07d);
        //KingsCrossStPancras
        KingsCrossStPancras.AddConnection(Euston, Northern, Northbound, 1.33d);
        KingsCrossStPancras.AddConnection(RussellSquare, Piccadilly, Westbound, 1.67d);
        KingsCrossStPancras.AddConnection(Euston, TubeLine.Victoria, Southbound, 1.32d);
        KingsCrossStPancras.AddConnection(HighburyAndIslington, TubeLine.Victoria, Northbound, 2.87d);
        KingsCrossStPancras.AddConnection(EustonSquare, Circle, Inner, 1.65d);
        KingsCrossStPancras.AddConnection(Farringdon, Circle, Outer, 2.98d);
        //Kingsbury
        Kingsbury.AddConnection(WembleyPark, Jubilee, Eastbound, 3.47d);
        Kingsbury.AddConnection(Queensbury, Jubilee, Westbound, 1.85d);
        //Knightsbridge
        Knightsbridge.AddConnection(HydeParkCorner, Piccadilly, Eastbound, 1.10d);
        Knightsbridge.AddConnection(SouthKensington, Piccadilly, Westbound, 2.23d);
        //LadbrokeGrove
        LadbrokeGrove.AddConnection(LatimerRoad, Circle, Inner, 1.28d);
        LadbrokeGrove.AddConnection(WestbournePark, Circle, Outer, 1.48d);
        //LancasterGate
        LancasterGate.AddConnection(MarbleArch, Central, Eastbound, 1.92d);
        LancasterGate.AddConnection(Queensway, Central, Westbound, 1.65d);
        //LatimerRoad
        LatimerRoad.AddConnection(WoodLane, Circle, Inner, 2.00d);
        LatimerRoad.AddConnection(LadbrokeGrove, Circle, Outer, 1.37d);
        //LeicesterSquare
        LeicesterSquare.AddConnection(CharingCross, Northern, Southbound, 1.20d);
        LeicesterSquare.AddConnection(TottenhamCourtRoad, Northern, Northbound, 1.03d);
        LeicesterSquare.AddConnection(CoventGarden, Piccadilly, Eastbound, 0.77d);
        LeicesterSquare.AddConnection(PiccadillyCircus, Piccadilly, Westbound, 1.07d);
        //LiverpoolStreet
        LiverpoolStreet.AddConnection(Bank, Central, Westbound, 1.65d);
        LiverpoolStreet.AddConnection(Moorgate, Circle, Inner, 1.32d);
        LiverpoolStreet.AddConnection(Aldgate, Circle, Outer, 2.18d);
        //LondonBridge
        LondonBridge.AddConnection(Bermondsey, Jubilee, Eastbound, 2.25d);
        LondonBridge.AddConnection(Southwark, Jubilee, Westbound, 1.77d);
        LondonBridge.AddConnection(Bank, Northern, Northbound, 1.53d);
        //MansionHouse
        MansionHouse.AddConnection(CannonStreet, Circle, Inner, 0.98d);
        MansionHouse.AddConnection(Blackfriars, Circle, Outer, 1.22d);
        //MarbleArch
        MarbleArch.AddConnection(BondStreet, Central, Eastbound, 1.00d);
        MarbleArch.AddConnection(LancasterGate, Central, Westbound, 1.62d);
        //Monument
        Monument.AddConnection(TowerHill, Circle, Inner, 1.80d);
        Monument.AddConnection(CannonStreet, Circle, Outer, 0.88d);
        //Moorgate
        Moorgate.AddConnection(Barbican, Circle, Inner, 1.38d);
        Moorgate.AddConnection(LiverpoolStreet, Circle, Outer, 1.18d);
        Moorgate.AddConnection(Bank, Northern, Southbound, 1.90d);
        //Neasden
        Neasden.AddConnection(DollisHill, Jubilee, Eastbound, 1.43d);
        Neasden.AddConnection(WembleyPark, Jubilee, Westbound, 2.65d);
        //NorthGreenwich
        NorthGreenwich.AddConnection(CanningTown, Jubilee, Eastbound, 2.15d);
        NorthGreenwich.AddConnection(CanaryWharf, Jubilee, Westbound, 1.98d);
        //NottingHillGate
        NottingHillGate.AddConnection(Queensway, Central, Eastbound, 1.17d);
        NottingHillGate.AddConnection(HollandPark, Central, Westbound, 1.18d);
        NottingHillGate.AddConnection(HighStreetKensington, Circle, Inner, 1.58d);
        NottingHillGate.AddConnection(Bayswater, Circle, Outer, 1.77d);
        //OxfordCircus
        OxfordCircus.AddConnection(PiccadillyCircus, Bakerloo, Southbound, 1.95d);
        OxfordCircus.AddConnection(RegentsPark, Bakerloo, Northbound, 1.72d);
        OxfordCircus.AddConnection(TottenhamCourtRoad, Central, Eastbound, 0.98d);
        OxfordCircus.AddConnection(BondStreet, Central, Westbound, 1.03d);
        OxfordCircus.AddConnection(GreenPark, TubeLine.Victoria, Southbound, 1.78d);
        OxfordCircus.AddConnection(WarrenStreet, TubeLine.Victoria, Northbound, 1.53d);
        //Paddington
        Paddington.AddConnection(RoyalOak, Circle, Inner, 1.33d);
        Paddington.AddConnection(EdgwareRoad, Circle, Outer, 2.15d);
        Paddington.AddConnection(EdgwareRoad, Circle, Outer, 2.33d);
        Paddington.AddConnection(Bayswater, Circle, Inner, 1.65d);
        //PiccadillyCircus
        PiccadillyCircus.AddConnection(CharingCross, Bakerloo, Southbound, 1.35d);
        PiccadillyCircus.AddConnection(OxfordCircus, Bakerloo, Northbound, 2.02d);
        PiccadillyCircus.AddConnection(LeicesterSquare, Piccadilly, Eastbound, 1.17d);
        PiccadillyCircus.AddConnection(GreenPark, Piccadilly, Westbound, 1.18d);
        //Pimlico
        Pimlico.AddConnection(Vauxhall, TubeLine.Victoria, Southbound, 1.40d);
        Pimlico.AddConnection(Stations.Victoria, TubeLine.Victoria, Northbound, 2.18d);
        //Queensbury
        Queensbury.AddConnection(Kingsbury, Jubilee, Eastbound, 1.72d);
        Queensbury.AddConnection(CanonsPark, Jubilee, Westbound, 2.23d);
        //Queensway
        Queensway.AddConnection(LancasterGate, Central, Eastbound, 1.35d);
        Queensway.AddConnection(NottingHillGate, Central, Westbound, 1.18d);
        //RegentsPark
        RegentsPark.AddConnection(OxfordCircus, Bakerloo, Southbound, 1.85d);
        RegentsPark.AddConnection(BakerStreet, Bakerloo, Northbound, 1.65d);
        //Richmond
        Richmond.AddConnection(KewGardens, Overground, Eastbound, 3.00d);
        //RoyalOak
        RoyalOak.AddConnection(WestbournePark, Circle, Inner, 1.72d);
        RoyalOak.AddConnection(Paddington, Circle, Outer, 1.52d);
        //RussellSquare
        RussellSquare.AddConnection(KingsCrossStPancras, Piccadilly, Eastbound, 1.90d);
        RussellSquare.AddConnection(Holborn, Piccadilly, Westbound, 1.37d);
        //SevenSisters
        SevenSisters.AddConnection(FinsburyPark, TubeLine.Victoria, Southbound, 3.77d);
        SevenSisters.AddConnection(TottenhamHale, TubeLine.Victoria, Northbound, 1.60d);
        //ShepherdsBush
        ShepherdsBush.AddConnection(HollandPark, Central, Eastbound, 1.37d);
        ShepherdsBush.AddConnection(KensingtonOlympia, Overground, Westbound, 3.00d);
        ShepherdsBush.AddConnection(WillesdenJunction, Overground, Eastbound, 9.00d);
        //ShepherdsBushMarket
        ShepherdsBushMarket.AddConnection(GoldhawkRoad, Circle, Inner, 1.15d);
        ShepherdsBushMarket.AddConnection(WoodLane, Circle, Outer, 2.00d);
        //SloaneSquare
        SloaneSquare.AddConnection(Stations.Victoria, Circle, Inner, 1.80d);
        SloaneSquare.AddConnection(SouthKensington, Circle, Outer, 2.00d);
        //SouthActon
        SouthActon.AddConnection(ActonCentral, Overground, Eastbound, 3.00d);
        SouthActon.AddConnection(Gunnersbury, Overground, Westbound, 4.00d);
        //SouthKensington
        SouthKensington.AddConnection(SloaneSquare, Circle, Inner, 1.98d);
        SouthKensington.AddConnection(GloucesterRoad, Circle, Outer, 1.48d);
        SouthKensington.AddConnection(Knightsbridge, Piccadilly, Eastbound, 2.48d);
        SouthKensington.AddConnection(GloucesterRoad, Piccadilly, Westbound, 1.37d);
        //Southwark
        Southwark.AddConnection(LondonBridge, Jubilee, Eastbound, 1.65d);
        Southwark.AddConnection(Waterloo, Jubilee, Westbound, 0.97d);
        //StJamesPark
        StJamesPark.AddConnection(Westminster, Circle, Inner, 1.50d);
        StJamesPark.AddConnection(Stations.Victoria, Circle, Outer, 1.33d);
        //StJohnsWood
        StJohnsWood.AddConnection(BakerStreet, Jubilee, Eastbound, 2.77d);
        StJohnsWood.AddConnection(SwissCottage, Jubilee, Westbound, 1.52d);
        //StPauls
        StPauls.AddConnection(Bank, Central, Eastbound, 1.62d);
        StPauls.AddConnection(ChanceryLane, Central, Westbound, 1.52d);
        //Stanmore
        Stanmore.AddConnection(CanonsPark, Jubilee, Eastbound, 1.95d);
        //Stockwell
        Stockwell.AddConnection(Brixton, TubeLine.Victoria, Southbound, 2.03d);
        Stockwell.AddConnection(Vauxhall, TubeLine.Victoria, Northbound, 2.23d);
        //Stratford
        Stratford.AddConnection(HackneyWick, Overground, Westbound, 3.00d);
        Stratford.AddConnection(WestHam, Jubilee, Westbound, 2.42d);
        //SwissCottage
        SwissCottage.AddConnection(StJohnsWood, Jubilee, Eastbound, 1.52d);
        SwissCottage.AddConnection(FinchleyRoad, Jubilee, Westbound, 1.18d);
        //Temple
        Temple.AddConnection(Blackfriars, Circle, Inner, 1.40d);
        Temple.AddConnection(Embankment, Circle, Outer, 1.43d);
        //TottenhamCourtRoad
        TottenhamCourtRoad.AddConnection(Holborn, Central, Eastbound, 1.63d);
        TottenhamCourtRoad.AddConnection(OxfordCircus, Central, Westbound, 1.02d);
        TottenhamCourtRoad.AddConnection(LeicesterSquare, Northern, Southbound, 0.98d);
        TottenhamCourtRoad.AddConnection(GoodgeStreet, Northern, Northbound, 1.28d);
        //TottenhamHale
        TottenhamHale.AddConnection(SevenSisters, TubeLine.Victoria, Southbound, 2.00d);
        TottenhamHale.AddConnection(BlackhorseRoad, TubeLine.Victoria, Northbound, 1.97d);
        //TowerHill
        TowerHill.AddConnection(Aldgate, Circle, Inner, 1.30d);
        TowerHill.AddConnection(Monument, Circle, Outer, 1.48d);
        //Vauxhall
        Vauxhall.AddConnection(Stockwell, TubeLine.Victoria, Southbound, 2.30d);
        Vauxhall.AddConnection(Pimlico, TubeLine.Victoria, Northbound, 1.37d);
        //Victoria
        Stations.Victoria.AddConnection(StJamesPark, Circle, Inner, 1.42d);
        Stations.Victoria.AddConnection(SloaneSquare, Circle, Outer, 1.75d);
        Stations.Victoria.AddConnection(Pimlico, TubeLine.Victoria, Southbound, 1.83d);
        Stations.Victoria.AddConnection(GreenPark, TubeLine.Victoria, Northbound, 1.95d);
        //WalthamstowCentral
        WalthamstowCentral.AddConnection(BlackhorseRoad, TubeLine.Victoria, Southbound, 2.12d);
        //WarrenStreet
        WarrenStreet.AddConnection(GoodgeStreet, Northern, Southbound, 1.07d);
        WarrenStreet.AddConnection(Euston, Northern, Northbound, 1.18d);
        WarrenStreet.AddConnection(OxfordCircus, TubeLine.Victoria, Southbound, 1.72d);
        WarrenStreet.AddConnection(Euston, TubeLine.Victoria, Northbound, 1.32d);
        //Waterloo
        Waterloo.AddConnection(Embankment, Bakerloo, Northbound, 1.22d);
        Waterloo.AddConnection(Southwark, Jubilee, Eastbound, 1.02d);
        Waterloo.AddConnection(Westminster, Jubilee, Westbound, 1.43d);
        Waterloo.AddConnection(Embankment, Northern, Northbound, 1.4d);
        //WembleyPark
        WembleyPark.AddConnection(Neasden, Jubilee, Eastbound, 2.60d);
        WembleyPark.AddConnection(Kingsbury, Jubilee, Westbound, 3.47d);
        //WestBrompton
        WestBrompton.AddConnection(ImperialWharf, Overground, Westbound, 2.00d);
        WestBrompton.AddConnection(KensingtonOlympia, Overground, Eastbound, 3.00d);
        WestBrompton.AddConnection(EarlsCourt, District, Eastbound, 1.42d);
        //WestHam
        WestHam.AddConnection(Stratford, Jubilee, Eastbound, 3.15d);
        WestHam.AddConnection(CanningTown, Jubilee, Westbound, 2.13d);
        //WestHampstead
        WestHampstead.AddConnection(Brondesbury, Overground, Westbound, 2.00d);
        WestHampstead.AddConnection(FinchleyRoadAndFrognal, Overground, Eastbound, 1.00d);
        WestHampstead.AddConnection(FinchleyRoad, Jubilee, Eastbound, 1.25d);
        WestHampstead.AddConnection(Kilburn, Jubilee, Westbound, 1.55d);
        //WestKensington
        WestKensington.AddConnection(BaronsCourt, District, Westbound, 1.32d);
        WestKensington.AddConnection(EarlsCourt, District, Eastbound, 2.17d);
        //WestbournePark
        WestbournePark.AddConnection(LadbrokeGrove, Circle, Inner, 1.48d);
        WestbournePark.AddConnection(RoyalOak, Circle, Outer, 1.78d);
        //Westminster
        Westminster.AddConnection(Embankment, Circle, Inner, 1.37d);
        Westminster.AddConnection(StJamesPark, Circle, Outer, 1.52d);
        Westminster.AddConnection(Waterloo, Jubilee, Eastbound, 1.38d);
        Westminster.AddConnection(GreenPark, Jubilee, Westbound, 1.82d);
        //WillesdenGreen
        WillesdenGreen.AddConnection(Kilburn, Jubilee, Eastbound, 1.68d);
        WillesdenGreen.AddConnection(DollisHill, Jubilee, Westbound, 1.67d);
        //WillesdenJunction
        WillesdenJunction.AddConnection(ShepherdsBush, Overground, Westbound, 8.00d);
        WillesdenJunction.AddConnection(ActonCentral, Overground, Westbound, 5.00d);
        WillesdenJunction.AddConnection(KensalRise, Overground, Eastbound, 2.00d);
        //WoodLane
        WoodLane.AddConnection(ShepherdsBushMarket, Circle, Inner, 2.00d);
        WoodLane.AddConnection(LatimerRoad, Circle, Outer, 2.00d);
    }
}