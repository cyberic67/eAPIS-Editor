
Public Structure DomesticLocationType

    Private mAirportCode As String
    Private mCity As String
    Private mState As String
    Private mPlaceDescription As String

    Public Property AirportCode As String
        Get
            Return mAirportCode
        End Get
        Set(ByVal value As String)
            mAirportCode = Left(Trim(value), 4)
        End Set
    End Property

    Public Property City As String
        Get
            Return mCity
        End Get
        Set(ByVal value As String)
            mCity = Left(Trim(value), 30)
        End Set
    End Property

    Public Property State As String
        Get
            Return mState
        End Get
        Set(ByVal value As String)
            mState = Left(Trim(value), 2)
        End Set
    End Property

    Public Property PlaceDescription As String
        Get
            Return mPlaceDescription
        End Get
        Set(ByVal value As String)
            mPlaceDescription = Left(Trim(value), 75)
        End Set
    End Property

End Structure

Public Structure ForeignLocationType

    Private mAirportCode As String
    Private mCity As String
    Private mCountryCode As String

    Public Property AirportCode As String
        Get
            Return mAirportCode
        End Get
        Set(ByVal value As String)
            mAirportCode = Left(Trim(value), 4)
        End Set
    End Property

    Public Property City As String
        Get
            Return mCity
        End Get
        Set(ByVal value As String)
            mCity = Left(Trim(value), 30)
        End Set
    End Property

    Public Property CountryCode As String
        Get
            Return mCountryCode
        End Get
        Set(ByVal value As String)
            mCountryCode = Left(Trim(value), 3)
        End Set
    End Property

End Structure

Public Structure CompleteItineraryType

    Private mForeignAirport1 As String
    Private mForeignAirport2 As String
    Private mForeignAirport3 As String
    Private mForeignAirport4 As String
    Private mForeignAirport5 As String

    Public Property ForeignAirport1 As String
        Get
            Return mForeignAirport1
        End Get
        Set(ByVal value As String)
            mForeignAirport1 = Left(Trim(value), 10)
        End Set
    End Property

    Public Property ForeignAirport2 As String
        Get
            Return mForeignAirport2
        End Get
        Set(ByVal value As String)
            mForeignAirport2 = Left(Trim(value), 10)
        End Set
    End Property

    Public Property ForeignAirport3 As String
        Get
            Return mForeignAirport3
        End Get
        Set(ByVal value As String)
            mForeignAirport3 = Left(Trim(value), 10)
        End Set
    End Property

    Public Property ForeignAirport4 As String
        Get
            Return mForeignAirport4
        End Get
        Set(ByVal value As String)
            mForeignAirport4 = Left(Trim(value), 10)
        End Set
    End Property

    Public Property ForeignAirport5 As String
        Get
            Return mForeignAirport5
        End Get
        Set(ByVal value As String)
            mForeignAirport5 = Left(Trim(value), 10)
        End Set
    End Property

End Structure

Public Structure ContactType

    Private mStreetAddr As String
    Private mAddressSupplemental As String
    Private mCity As String
    Private mStateProvince As String
    Private mZipPostal As String
    Private mCountry As String
    Private mTelephoneNbr As String
    Private mFaxNbr As String
    Private mEmailAddr As String

    Public Property StreetAddr As String
        Get
            Return mStreetAddr
        End Get
        Set(ByVal value As String)
            mStreetAddr = Left(Trim(value), 40)
        End Set
    End Property

    Public Property AddressSupplemental As String
        Get
            Return mAddressSupplemental
        End Get
        Set(ByVal value As String)
            mAddressSupplemental = Left(Trim(value), 8)
        End Set
    End Property
    Public Property City As String
        Get
            Return mCity
        End Get
        Set(ByVal value As String)
            mCity = Left(Trim(value), 30)
        End Set
    End Property
    Public Property StateProvince As String
        Get
            Return mStateProvince
        End Get
        Set(ByVal value As String)
            mStateProvince = Left(Trim(value), 2)
        End Set
    End Property
    Public Property ZipPostal As String
        Get
            Return mZipPostal
        End Get
        Set(ByVal value As String)
            mZipPostal = Left(Trim(value), 9)
        End Set
    End Property
    Public Property Country As String
        Get
            Return mCountry
        End Get
        Set(ByVal value As String)
            mCountry = Left(Trim(value), 3)
        End Set
    End Property
    Public Property TelephoneNbr As String
        Get
            Return mTelephoneNbr
        End Get
        Set(ByVal value As String)
            mTelephoneNbr = Left(Trim(value), 25)
        End Set
    End Property
    Public Property FaxNbr As String
        Get
            Return mFaxNbr
        End Get
        Set(ByVal value As String)
            mFaxNbr = Left(Trim(value), 25)
        End Set
    End Property
    Public Property EmailAddrFaxNbr As String
        Get
            Return mEmailAddr
        End Get
        Set(ByVal value As String)
            mEmailAddr = Left(Trim(value), 70)
        End Set
    End Property
End Structure

Public Structure AddressType

    Private mStreetAddr As String
    Private mCity As String
    Private mStateProvince As String
    Private mPostalCode As String
    Private mCountry As String

    Public Property StreetAddr As String
        Get
            Return mStreetAddr
        End Get
        Set(ByVal value As String)
            mStreetAddr = Left(Trim(value), 35)
        End Set
    End Property

    Public Property City As String
        Get
            Return mCity
        End Get
        Set(ByVal value As String)
            mCity = Left(Trim(value), 35)
        End Set
    End Property
    Public Property StateProvince As String
        Get
            Return mStateProvince
        End Get
        Set(ByVal value As String)
            mStateProvince = Left(Trim(value), 2)
        End Set
    End Property
    Public Property PostalCode As String
        Get
            Return mPostalCode
        End Get
        Set(ByVal value As String)
            mPostalCode = Left(Trim(value), 9)
        End Set
    End Property
    Public Property Country As String
        Get
            Return mCountry
        End Get
        Set(ByVal value As String)
            mCountry = Left(Trim(value), 3)
        End Set
    End Property

End Structure

Public Structure USAddressType

    Private mStreetAddr As String
    Private mCity As String
    Private mState As String
    Private mPostalCode As String


    Public Property StreetAddr As String
        Get
            Return mStreetAddr
        End Get
        Set(ByVal value As String)
            mStreetAddr = Left(Trim(value), 35)
        End Set
    End Property

    Public Property City As String
        Get
            Return mCity
        End Get
        Set(ByVal value As String)
            mCity = Left(Trim(value), 35)
        End Set
    End Property
    Public Property State As String
        Get
            Return mState
        End Get
        Set(ByVal value As String)
            mState = Left(Trim(value), 2)
        End Set
    End Property
    Public Property PostalCode As String
        Get
            Return mPostalCode
        End Get
        Set(ByVal value As String)
            mPostalCode = Left(Trim(value), 9)
        End Set
    End Property

End Structure


Public Class APIS_Manifest

    Private mSenderID As String
    Private mAircraftTailNumber As String

    Public Property SenderID As String

        Get
            Return mSenderID
        End Get

        Set(ByVal value As String)
            mSenderID = value
        End Set

    End Property

    Public Property AircraftTailNumber
        Get
            Return mAircraftTailNumber
        End Get
        Set(ByVal value)
            mAircraftTailNumber = Replace(value, "-", String.Empty)
        End Set
    End Property

End Class

