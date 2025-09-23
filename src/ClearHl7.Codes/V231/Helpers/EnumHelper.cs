﻿using System;

namespace ClearHl7.Codes.V231.Helpers
{
    /// <summary>
    /// Provides helper methods for interacting with enumerations.
    /// Static methods are available for optimal performance.
    /// </summary>
    /// </summary>
    public class EnumHelper : IEnumHelper
    {
        /// <summary>
        /// <summary>
        /// Converts the given CodeAcceptApplicationAcknowledgmentConditions enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeAcceptApplicationAcknowledgmentConditions input)
        {
            return input switch
            {
                CodeAcceptApplicationAcknowledgmentConditions.Always => "AL",
                CodeAcceptApplicationAcknowledgmentConditions.ErrorRejectConditionsOnly => "ER",
                CodeAcceptApplicationAcknowledgmentConditions.Never => "NE",
                CodeAcceptApplicationAcknowledgmentConditions.SuccessfulCompletionOnly => "SU",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeAcceptApplicationAcknowledgmentConditions input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeAcknowledgmentCode enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeAcknowledgmentCode input)
        {
            return input switch
            {
                CodeAcknowledgmentCode.OriginalModeAcceptEnhancedModeAcknowledgmentAccept => "AA",
                CodeAcknowledgmentCode.OriginalModeErrorEnhancedModeAcknowledgmentError => "AE",
                CodeAcknowledgmentCode.OriginalModeRejectEnhancedModeAcknowledgmentReject => "AR",
                CodeAcknowledgmentCode.EnhancedModeAcceptAcknowledgmentCommitAccept => "CA",
                CodeAcknowledgmentCode.EnhancedModeAcceptAcknowledgmentCommitError => "CE",
                CodeAcknowledgmentCode.EnhancedModeAcceptAcknowledgmentCommitReject => "CR",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeAcknowledgmentCode input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeActionCode enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeActionCode input)
        {
            return input switch
            {
                CodeActionCode.AddInsert => "A",
                CodeActionCode.Delete => "D",
                CodeActionCode.Update => "U",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeActionCode input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeActionTakenInResponseToTheEvent enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeActionTakenInResponseToTheEvent input)
        {
            return input switch
            {
                CodeActionTakenInResponseToTheEvent.ProductDoseIncreased => "DI",
                CodeActionTakenInResponseToTheEvent.ProductDoseReduced => "DR",
                CodeActionTakenInResponseToTheEvent.None => "N",
                CodeActionTakenInResponseToTheEvent.Other => "OT",
                CodeActionTakenInResponseToTheEvent.ProductWithdrawnPermanently => "WP",
                CodeActionTakenInResponseToTheEvent.ProductWithdrawnTemporarily => "WT",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeActionTakenInResponseToTheEvent input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeActiveInactive enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeActiveInactive input)
        {
            return input switch
            {
                CodeActiveInactive.ActiveStaff => "A",
                CodeActiveInactive.InactiveStaff => "I",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeActiveInactive input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeAddressType enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeAddressType input)
        {
            return input switch
            {
                CodeAddressType.FirmBusiness => "B",
                CodeAddressType.BadAddress => "BA",
                CodeAddressType.BirthDeliveryLocation => "BDL",
                CodeAddressType.ResidenceAtBirth => "BR",
                CodeAddressType.CurrentOrTemporary => "C",
                CodeAddressType.CountryOfOrigin => "F",
                CodeAddressType.Home => "H",
                CodeAddressType.LegalAddress => "L",
                CodeAddressType.Mailing => "M",
                CodeAddressType.BirthNee => "N",
                CodeAddressType.OfficeBusiness => "O",
                CodeAddressType.Permanent => "P",
                CodeAddressType.RegistryHome => "RH",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeAddressType input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeAdministrationDevice enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeAdministrationDevice input)
        {
            return input switch
            {
                CodeAdministrationDevice.Applicator => "AP",
                CodeAdministrationDevice.Buretrol => "BT",
                CodeAdministrationDevice.HeparinLock => "HL",
                CodeAdministrationDevice.Ippb => "IPPB",
                CodeAdministrationDevice.IvPump => "IVP",
                CodeAdministrationDevice.IvSoluset => "IVS",
                CodeAdministrationDevice.MeteredInhaler => "MI",
                CodeAdministrationDevice.Nebulizer => "NEB",
                CodeAdministrationDevice.PcaPump => "PCA",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeAdministrationDevice input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeAdministrationMethod enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeAdministrationMethod input)
        {
            return input switch
            {
                CodeAdministrationMethod.Chew => "CH",
                CodeAdministrationMethod.Dissolve => "DI",
                CodeAdministrationMethod.Dust => "DU",
                CodeAdministrationMethod.Infiltrate => "IF",
                CodeAdministrationMethod.Irrigate => "IR",
                CodeAdministrationMethod.Insert => "IS",
                CodeAdministrationMethod.IvPush => "IVP",
                CodeAdministrationMethod.IvPiggyback => "IVPB",
                CodeAdministrationMethod.Nebulized => "NB",
                CodeAdministrationMethod.Perfuse => "PF",
                CodeAdministrationMethod.Paint => "PT",
                CodeAdministrationMethod.Shampoo => "SH",
                CodeAdministrationMethod.Soak => "SO",
                CodeAdministrationMethod.Wash => "WA",
                CodeAdministrationMethod.Wipe => "WI",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeAdministrationMethod input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeAdministrativeSex enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeAdministrativeSex input)
        {
            return input switch
            {
                CodeAdministrativeSex.Female => "F",
                CodeAdministrativeSex.Male => "M",
                CodeAdministrativeSex.Other => "O",
                CodeAdministrativeSex.Unknown => "U",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeAdministrativeSex input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeAdmissionType enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeAdmissionType input)
        {
            return input switch
            {
                CodeAdmissionType.Accident => "A",
                CodeAdmissionType.Emergency => "E",
                CodeAdmissionType.LaborAndDelivery => "L",
                CodeAdmissionType.Routine => "R",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeAdmissionType input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeAdmitSource enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeAdmitSource input)
        {
            return input switch
            {
                CodeAdmitSource.PhysicianReferral => "1",
                CodeAdmitSource.ClinicReferral => "2",
                CodeAdmitSource.HmoReferral => "3",
                CodeAdmitSource.TransferFromHospital => "4",
                CodeAdmitSource.TransferFromSkilledNursingFacility => "5",
                CodeAdmitSource.TransferFromAnotherHealthCareFacility => "6",
                CodeAdmitSource.EmergencyRoom => "7",
                CodeAdmitSource.CourtLawEnforcement => "8",
                CodeAdmitSource.InformationNotAvailable => "9",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeAdmitSource input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeAdvancedBeneficiaryNoticeCode enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeAdvancedBeneficiaryNoticeCode input)
        {
            return input switch
            {
                CodeAdvancedBeneficiaryNoticeCode.ServiceSubjectToMedicalNecessity => "1",
                CodeAdvancedBeneficiaryNoticeCode.PatientHasBeenInformedAndAgreesToPayForService => "2",
                CodeAdvancedBeneficiaryNoticeCode.PatientHasBeenInformedAndAsksThatPayerBeBilled => "3",
                CodeAdvancedBeneficiaryNoticeCode.AdvancedBeneficiaryNoticeHasNotBeenSigned => "4",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeAdvancedBeneficiaryNoticeCode input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeAllergenType enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeAllergenType input)
        {
            return input switch
            {
                CodeAllergenType.DrugAllergy => "DA",
                CodeAllergenType.FoodAllergy => "FA",
                CodeAllergenType.MiscellaneousAllergy => "MA",
                CodeAllergenType.MiscellaneousContraindication => "MC",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeAllergenType input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeAllergySeverity enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeAllergySeverity input)
        {
            return input switch
            {
                CodeAllergySeverity.Mild => "MI",
                CodeAllergySeverity.Moderate => "MO",
                CodeAllergySeverity.Severe => "SV",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeAllergySeverity input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeAllowSubstitution enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeAllowSubstitution input)
        {
            return input switch
            {
                CodeAllowSubstitution.AllowGenericSubstitutions => "G",
                CodeAllowSubstitution.SubstitutionsAreNotAuthorized => "N",
                CodeAllowSubstitution.AllowTherapeuticSubstitutions => "T",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeAllowSubstitution input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeAllowSubstitutionCodes enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeAllowSubstitutionCodes input)
        {
            return input switch
            {
                CodeAllowSubstitutionCodes.ContactPlacerPriorToSubstitution => "Confirm",
                CodeAllowSubstitutionCodes.SubstitutionIsNotAllowed => "No",
                CodeAllowSubstitutionCodes.NotifyPlacerThatSubstitutionHasBeenMade => "Notify",
                CodeAllowSubstitutionCodes.SubstitutionOfThisResourceIsAllowed => "Yes",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeAllowSubstitutionCodes input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeAlternateCharacterSetHandlingScheme enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeAlternateCharacterSetHandlingScheme input)
        {
            return input switch
            {
                CodeAlternateCharacterSetHandlingScheme.CharacterSetSwitchingXpnExtendedPersonName => "2.3",
                CodeAlternateCharacterSetHandlingScheme.NoCharacterSetSwitching => "null",
                CodeAlternateCharacterSetHandlingScheme.Iso20221994 => "ISO 2022-1994",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeAlternateCharacterSetHandlingScheme input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeAlternateCharacterSets enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeAlternateCharacterSets input)
        {
            return input switch
            {
                CodeAlternateCharacterSets.Iso88591CharacterSet => "8859/1",
                CodeAlternateCharacterSets.Iso88592CharacterSet => "8859/2",
                CodeAlternateCharacterSets.Iso88593CharacterSet => "8859/3",
                CodeAlternateCharacterSets.Iso88594CharacterSet => "8859/4",
                CodeAlternateCharacterSets.Iso88595CharacterSet => "8859/5",
                CodeAlternateCharacterSets.Iso88596CharacterSet => "8859/6",
                CodeAlternateCharacterSets.Iso88597CharacterSet => "8859/7",
                CodeAlternateCharacterSets.Iso88598CharacterSet => "8859/8",
                CodeAlternateCharacterSets.Iso88599CharacterSet => "8859/9",
                CodeAlternateCharacterSets.Seven7BitAsciiCharacterSet => "ASCII",
                CodeAlternateCharacterSets.InfoExchangeOneByteJisX02011976 => "ISO IR14",
                CodeAlternateCharacterSets.JapaneseGraphicJisX02121990 => "ISO IR159",
                CodeAlternateCharacterSets.JapaneseGraphicJisX02081990 => "ISO IR87",
                CodeAlternateCharacterSets.IsoIec1064611993 => "UNICODE",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeAlternateCharacterSets input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeAmbulatoryStatus enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeAmbulatoryStatus input)
        {
            return input switch
            {
                CodeAmbulatoryStatus.NoFunctionalLimitations => "A0",
                CodeAmbulatoryStatus.AmbulatesWithAssistiveDevice => "A1",
                CodeAmbulatoryStatus.WheelchairStretcherBound => "A2",
                CodeAmbulatoryStatus.ComatoseNonResponsive => "A3",
                CodeAmbulatoryStatus.Disoriented => "A4",
                CodeAmbulatoryStatus.VisionImpaired => "A5",
                CodeAmbulatoryStatus.HearingImpaired => "A6",
                CodeAmbulatoryStatus.SpeechImpaired => "A7",
                CodeAmbulatoryStatus.NonEnglishSpeaking => "A8",
                CodeAmbulatoryStatus.FunctionalLevelUnknown => "A9",
                CodeAmbulatoryStatus.OxygenTherapy => "B1",
                CodeAmbulatoryStatus.SpecialEquipmentTubesIvsCatheters => "B2",
                CodeAmbulatoryStatus.Amputee => "B3",
                CodeAmbulatoryStatus.Mastectomy => "B4",
                CodeAmbulatoryStatus.Paraplegic => "B5",
                CodeAmbulatoryStatus.Pregnant => "B6",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeAmbulatoryStatus input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeAmountClass enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeAmountClass input)
        {
            return input switch
            {
                CodeAmountClass.Amount => "AT",
                CodeAmountClass.Limit => "LM",
                CodeAmountClass.Percentage => "PC",
                CodeAmountClass.Unlimited => "UL",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeAmountClass input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeAmountType enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeAmountType input)
        {
            return input switch
            {
                CodeAmountType.Differential => "DF",
                CodeAmountType.Limit => "LM",
                CodeAmountType.Percentage => "PC",
                CodeAmountType.Rate => "RT",
                CodeAmountType.Unlimited => "UL",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeAmountType input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeAnnotations enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeAnnotations input)
        {
            return input switch
            {
                CodeAnnotations.PaceSpike => "9900",
                CodeAnnotations.SasMarker => "9901",
                CodeAnnotations.SenseMarker => "9902",
                CodeAnnotations.BeatMarker => "9903",
                CodeAnnotations.Etc => "9904",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeAnnotations input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeApplicationChangeType enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeApplicationChangeType input)
        {
            return input switch
            {
                CodeApplicationChangeType.MigratesToDifferentCpu => "M",
                CodeApplicationChangeType.ShutDown => "SD",
                CodeApplicationChangeType.StartUp => "SU",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeApplicationChangeType input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeAppointmentReasonCodes enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeAppointmentReasonCodes input)
        {
            return input switch
            {
                CodeAppointmentReasonCodes.ARoutineCheckUpSuchAsAnAnnualPhysical => "CHECKUP",
                CodeAppointmentReasonCodes.EmergencyAppointment => "EMERGENCY",
                CodeAppointmentReasonCodes.AFollowUpVisitFromAPreviousAppointment => "FOLLOWUP",
                CodeAppointmentReasonCodes.RoutineAppointmentDefaultIfNotValued => "ROUTINE",
                CodeAppointmentReasonCodes.APreviouslyUnscheduledWalkInVisit => "WALKIN",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeAppointmentReasonCodes input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeAppointmentTypeCodes enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeAppointmentTypeCodes input)
        {
            return input switch
            {
                CodeAppointmentTypeCodes.RequestToAddCompletedAppointment => "Complete",
                CodeAppointmentTypeCodes.RoutineScheduleRequestTypeDefaultIfNotValued => "Normal",
                CodeAppointmentTypeCodes.RequestForTentativeAppointment => "Tentative",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeAppointmentTypeCodes input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeAssignmentOfBenefits enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeAssignmentOfBenefits input)
        {
            return input switch
            {
                CodeAssignmentOfBenefits.ModifiedAssignment => "M",
                CodeAssignmentOfBenefits.No => "N",
                CodeAssignmentOfBenefits.Yes => "Y",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeAssignmentOfBenefits input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeBedStatus enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeBedStatus input)
        {
            return input switch
            {
                CodeBedStatus.Closed => "C",
                CodeBedStatus.Housekeeping => "H",
                CodeBedStatus.Isolated => "I",
                CodeBedStatus.Contaminated => "K",
                CodeBedStatus.Occupied => "O",
                CodeBedStatus.Unoccupied => "U",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeBedStatus input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeBodySite enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeBodySite input)
        {
            return input switch
            {
                CodeBodySite.BilateralEars => "BE",
                CodeBodySite.BilateralNares => "BN",
                CodeBodySite.Buttock => "BU",
                CodeBodySite.ChestTube => "CT",
                CodeBodySite.LeftArm => "LA",
                CodeBodySite.LeftAnteriorChest => "LAC",
                CodeBodySite.LeftAntecubitalFossa => "LACF",
                CodeBodySite.LeftDeltoid => "LD",
                CodeBodySite.LeftEar => "LE",
                CodeBodySite.LeftExternalJugular => "LEJ",
                CodeBodySite.LeftFoot => "LF",
                CodeBodySite.LeftGluteusMedius => "LG",
                CodeBodySite.LeftHand => "LH",
                CodeBodySite.LeftInternalJugular => "LIJ",
                CodeBodySite.LeftLowerAbdQuadrant => "LLAQ",
                CodeBodySite.LeftLowerForearm => "LLFA",
                CodeBodySite.LeftMidForearm => "LMFA",
                CodeBodySite.LeftNaris => "LN",
                CodeBodySite.LeftPosteriorChest => "LPC",
                CodeBodySite.LeftSubclavian => "LSC",
                CodeBodySite.LeftThigh => "LT",
                CodeBodySite.LeftUpperArm => "LUA",
                CodeBodySite.LeftUpperAbdQuadrant => "LUAQ",
                CodeBodySite.LeftUpperForearm => "LUFA",
                CodeBodySite.LeftVentragluteal => "LVG",
                CodeBodySite.LeftVastusLateralis => "LVL",
                CodeBodySite.Nebulized => "NB",
                CodeBodySite.RightEye => "OD",
                CodeBodySite.LeftEye => "OS",
                CodeBodySite.BilateralEyes => "OU",
                CodeBodySite.Perianal => "PA",
                CodeBodySite.Perineal => "PERIN",
                CodeBodySite.RightArm => "RA",
                CodeBodySite.RightAnteriorChest => "RAC",
                CodeBodySite.RightAntecubitalFossa => "RACF",
                CodeBodySite.RightDeltoid => "RD",
                CodeBodySite.RightEar => "RE",
                CodeBodySite.RightExternalJugular => "REJ",
                CodeBodySite.RightFoot => "RF",
                CodeBodySite.RightGluteusMedius => "RG",
                CodeBodySite.RightHand => "RH",
                CodeBodySite.RightInternalJugular => "RIJ",
                CodeBodySite.RtLowerAbdQuadrant => "RLAQ",
                CodeBodySite.RightLowerForearm => "RLFA",
                CodeBodySite.RightMidForearm => "RMFA",
                CodeBodySite.RightNaris => "RN",
                CodeBodySite.RightPosteriorChest => "RPC",
                CodeBodySite.RightSubclavian => "RSC",
                CodeBodySite.RightThigh => "RT",
                CodeBodySite.RightUpperArm => "RUA",
                CodeBodySite.RightUpperAbdQuadrant => "RUAQ",
                CodeBodySite.RightUpperForearm => "RUFA",
                CodeBodySite.RightVentragluteal => "RVG",
                CodeBodySite.RightVastusLateralis => "RVL",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeBodySite input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeCausalityObservations enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeCausalityObservations input)
        {
            return input switch
            {
                CodeCausalityObservations.AbatementOfEventAfterProductWithdrawn => "AW",
                CodeCausalityObservations.EventRecurredAfterProductReintroduced => "BE",
                CodeCausalityObservations.DoseResponseObserved => "DR",
                CodeCausalityObservations.AlternativeExplanationForEventAvailable => "EX",
                CodeCausalityObservations.EventOccurredAfterProductIntroduced => "IN",
                CodeCausalityObservations.LiteratureReportsAssociationOfProductWithEvent => "LI",
                CodeCausalityObservations.OccurrenceOfEventConfirmedByObjectiveEvidence => "OE",
                CodeCausalityObservations.Other => "OT",
                CodeCausalityObservations.EffectObservedWhenPatientReceivesPlacebo => "PL",
                CodeCausalityObservations.SimilarEventsInPastForThisPatient => "SE",
                CodeCausalityObservations.ToxicLevelsOfProductDocumented => "TC",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeCausalityObservations input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeCertificationPatientType enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeCertificationPatientType input)
        {
            return input switch
            {
                CodeCertificationPatientType.Emergency => "ER",
                CodeCertificationPatientType.InpatientElective => "IPE",
                CodeCertificationPatientType.OutpatientElective => "OPE",
                CodeCertificationPatientType.Urgent => "UR",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeCertificationPatientType input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeCertificationStatus enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeCertificationStatus input)
        {
            return input switch
            {
                CodeCertificationStatus.Certified => "C",
                CodeCertificationStatus.Eligible => "E",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeCertificationStatus input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeChargeOnIndicator enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeChargeOnIndicator input)
        {
            return input switch
            {
                CodeChargeOnIndicator.ChargeOnOrder => "O",
                CodeChargeOnIndicator.ChargeOnResult => "R",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeChargeOnIndicator input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeChargeType enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeChargeType input)
        {
            return input switch
            {
                CodeChargeType.Charge => "CH",
                CodeChargeType.Contract => "CO",
                CodeChargeType.Credit => "CR",
                CodeChargeType.Department => "DP",
                CodeChargeType.Grant => "GR",
                CodeChargeType.NoCharge => "NC",
                CodeChargeType.Professional => "PC",
                CodeChargeType.Research => "RS",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeChargeType input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeCheckDigitScheme enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeCheckDigitScheme input)
        {
            return input switch
            {
                CodeCheckDigitScheme.Iso70641983 => "ISO",
                CodeCheckDigitScheme.Mod10Algorithm => "M10",
                CodeCheckDigitScheme.Mod11Algorithm => "M11",
                CodeCheckDigitScheme.CheckDigitInTheNationalProviderIdentifier => "NPI",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeCheckDigitScheme input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeCommentType enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeCommentType input)
        {
            return input switch
            {
                CodeCommentType.PrimaryReason => "1R",
                CodeCommentType.SecondaryReason => "2R",
                CodeCommentType.AncillaryInstructions => "AI",
                CodeCommentType.DuplicateInteractionReason => "DR",
                CodeCommentType.GeneralInstructions => "GI",
                CodeCommentType.GeneralReason => "GR",
                CodeCommentType.PatientInstructions => "PI",
                CodeCommentType.Remark => "RE",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeCommentType input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeCompletionStatus enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeCompletionStatus input)
        {
            return input switch
            {
                CodeCompletionStatus.Complete => "CP",
                CodeCompletionStatus.NotAdministered => "NA",
                CodeCompletionStatus.PartiallyAdministered => "PA",
                CodeCompletionStatus.Refused => "RE",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeCompletionStatus input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeConditionCode enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeConditionCode input)
        {
            return input switch
            {
                CodeConditionCode.MilitaryServiceRelated => "01",
                CodeConditionCode.ConditionIsEmploymentRelated => "02",
                CodeConditionCode.PatientCoveredByInsuranceNotReflectedHere => "03",
                CodeConditionCode.HmoEnrollee => "04",
                CodeConditionCode.LienHasBeenFiled => "05",
                CodeConditionCode.EsrdPatient18MonthsCoveredByEmployerInsurance => "06",
                CodeConditionCode.TreatmentOfNonTerminalConditionHospicePatient => "07",
                CodeConditionCode.BeneficiaryWouldNotProvideInfoConcerningOtherInsurance => "08",
                CodeConditionCode.NeitherPatientNorSpouseIsEmployed => "09",
                CodeConditionCode.PatientAndOrSpouseIsEmployedButNoEghpExists => "10",
                CodeConditionCode.DisabledBeneficiaryButNoLghp => "11",
                CodeConditionCode.PayerCodes12 => "12",
                CodeConditionCode.PayerCodes12To16 => "12 ... 16",
                CodeConditionCode.PayerCodes13 => "13",
                CodeConditionCode.PayerCodes14 => "14",
                CodeConditionCode.PayerCodes15 => "15",
                CodeConditionCode.PayerCodes16 => "16",
                CodeConditionCode.MaidenNameRetained => "18",
                CodeConditionCode.ChildRetainsMothersName => "19",
                CodeConditionCode.BeneficiaryRequestedBilling => "20",
                CodeConditionCode.BillingForDenialNotice => "21",
                CodeConditionCode.VaPatientChoosesMedicareCertifiedFacility => "26",
                CodeConditionCode.PatientReferredToHospitalForDiagnosticLabTest => "27",
                CodeConditionCode.PatientAndOrSpousesEghpIsSecondaryToMedicare => "28",
                CodeConditionCode.DisabledBeneficiaryAndOrFamilyMembersLghpIsSecondaryToMedicare => "29",
                CodeConditionCode.PatientIsStudentFullTimeDay => "31",
                CodeConditionCode.PatientIsStudentWorkStudyProgram => "32",
                CodeConditionCode.PatientIsStudentFullTimeNight => "33",
                CodeConditionCode.PatientIsStudentPartTime => "34",
                CodeConditionCode.GeneralCarePatientInSpecialUnit => "36",
                CodeConditionCode.WardAccommodationAsPatientRequest => "37",
                CodeConditionCode.SemiPrivateRoomNotAvailable => "38",
                CodeConditionCode.PrivateRoomMedicallyNecessary => "39",
                CodeConditionCode.SameDayTransfer => "40",
                CodeConditionCode.PartialHospitalization => "41",
                CodeConditionCode.NonAvailabilityStatementOnFile => "46",
                CodeConditionCode.PsycTreatmentCentersForChildrenAndAdolescents => "48",
                CodeConditionCode.SnfBedNotAvailable => "55",
                CodeConditionCode.MedicalAppropriateness => "56",
                CodeConditionCode.SnfReadmission => "57",
                CodeConditionCode.DayOutlier => "60",
                CodeConditionCode.CostOutlier => "61",
                CodeConditionCode.PayerCode => "62",
                CodeConditionCode.ProviderDoesNotWishCostOutlierPayment => "66",
                CodeConditionCode.BeneficiaryElectsNotToUseLifeTimeReserveLtrDays => "67",
                CodeConditionCode.BeneficiaryElectsToUseLifeTimeReserveLtrDays => "68",
                CodeConditionCode.SelfAdministeredEpo => "70",
                CodeConditionCode.FullCareInUnit => "71",
                CodeConditionCode.SelfCareInUnit => "72",
                CodeConditionCode.SelfCareTraining => "73",
                CodeConditionCode.Home => "74",
                CodeConditionCode.Home100Reimbursement => "75",
                CodeConditionCode.BackUpInFacilityDialysis => "76",
                CodeConditionCode.ProviderAcceptsPayerPaymentInFull => "77",
                CodeConditionCode.NewCoverageNotImplementedByHmo => "78",
                CodeConditionCode.CorfServicesProvidedOffSite => "79",
                CodeConditionCode.Pregnant => "80",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeConditionCode input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeConfidentialityCode enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeConfidentialityCode input)
        {
            return input switch
            {
                CodeConfidentialityCode.AidsPatient => "AID",
                CodeConfidentialityCode.Employee => "EMP",
                CodeConfidentialityCode.AlcoholDrugTreatmentPatient => "ETH",
                CodeConfidentialityCode.HivPatient => "HIV",
                CodeConfidentialityCode.PsychiatricPatient => "PSY",
                CodeConfidentialityCode.Restricted => "R",
                CodeConfidentialityCode.UsualControl => "U",
                CodeConfidentialityCode.UnwedMother => "UWM",
                CodeConfidentialityCode.VeryRestricted => "V",
                CodeConfidentialityCode.VeryImportantPersonOrCelebrity => "VIP",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeConfidentialityCode input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeCoordinationOfBenefits enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeCoordinationOfBenefits input)
        {
            return input switch
            {
                CodeCoordinationOfBenefits.Coordination => "CO",
                CodeCoordinationOfBenefits.Independent => "IN",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeCoordinationOfBenefits input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeCoverageType enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeCoverageType input)
        {
            return input switch
            {
                CodeCoverageType.BothHospitalAndPhysician => "B",
                CodeCoverageType.HospitalInstitutional => "H",
                CodeCoverageType.PhysicianProfessional => "P",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeCoverageType input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeCpRangeType enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeCpRangeType input)
        {
            return input switch
            {
                CodeCpRangeType.FlatRate => "F",
                CodeCpRangeType.ProRate => "P",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeCpRangeType input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeDateTimeSelectionQualifier enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeDateTimeSelectionQualifier input)
        {
            return input switch
            {
                CodeDateTimeSelectionQualifier.FirstValueWithinRange => "1ST",
                CodeDateTimeSelectionQualifier.AllValuesWithinTheRange => "ALL",
                CodeDateTimeSelectionQualifier.LastValueWithinTheRange => "LST",
                CodeDateTimeSelectionQualifier.ValuesWithinRangeInReverseOrder => "REV",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeDateTimeSelectionQualifier input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeDaysOfTheWeek enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeDaysOfTheWeek input)
        {
            return input switch
            {
                CodeDaysOfTheWeek.Friday => "FRI",
                CodeDaysOfTheWeek.Monday => "MON",
                CodeDaysOfTheWeek.Saturday => "SAT",
                CodeDaysOfTheWeek.Sunday => "SUN",
                CodeDaysOfTheWeek.Thursday => "THU",
                CodeDaysOfTheWeek.Tuesday => "TUE",
                CodeDaysOfTheWeek.Wednesday => "WED",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeDaysOfTheWeek input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeDayType enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeDayType input)
        {
            return input switch
            {
                CodeDayType.Approved => "AP",
                CodeDayType.Denied => "DE",
                CodeDayType.Pending => "PE",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeDayType input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeDeferredResponseType enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeDeferredResponseType input)
        {
            return input switch
            {
                CodeDeferredResponseType.BeforeTheDateTimeSpecified => "B",
                CodeDeferredResponseType.LaterThanTheDateTimeSpecified => "L",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeDeferredResponseType input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeDegreeLicenseCertificate enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeDegreeLicenseCertificate input)
        {
            return input switch
            {
                CodeDegreeLicenseCertificate.AssociateOfArts => "AA",
                CodeDegreeLicenseCertificate.AssociateOfAppliedScience => "AAS",
                CodeDegreeLicenseCertificate.AssociateOfBusinessAdministration => "ABA",
                CodeDegreeLicenseCertificate.AssociateOfEngineering => "AE",
                CodeDegreeLicenseCertificate.AssociateOfScience => "AS",
                CodeDegreeLicenseCertificate.BachelorOfArts => "BA",
                CodeDegreeLicenseCertificate.BachelorOfBusinessAdministration => "BBA",
                CodeDegreeLicenseCertificate.BachelorOrEngineering => "BE",
                CodeDegreeLicenseCertificate.BachelorOfFineArts => "BFA",
                CodeDegreeLicenseCertificate.BachelorOfNursing => "BN",
                CodeDegreeLicenseCertificate.BachelorOfScience => "BS",
                CodeDegreeLicenseCertificate.BachelorOfScienceLaw => "BSL",
                CodeDegreeLicenseCertificate.BachelorOfTheology => "BT",
                CodeDegreeLicenseCertificate.Certificate => "CER",
                CodeDegreeLicenseCertificate.DoctorOfBusinessAdministration => "DBA",
                CodeDegreeLicenseCertificate.DoctorOfEducation => "DED",
                CodeDegreeLicenseCertificate.Diploma => "DIP",
                CodeDegreeLicenseCertificate.DoctorOfOsteopathy => "DO",
                CodeDegreeLicenseCertificate.HighSchoolGraduate => "HS",
                CodeDegreeLicenseCertificate.JurisDoctor => "JD",
                CodeDegreeLicenseCertificate.MasterOfArts => "MA",
                CodeDegreeLicenseCertificate.MasterOfBusinessAdministration => "MBA",
                CodeDegreeLicenseCertificate.MasterOfCivilEngineering => "MCE",
                CodeDegreeLicenseCertificate.DoctorOfMedicine => "MD",
                CodeDegreeLicenseCertificate.MasterOfDivinity => "MDI",
                CodeDegreeLicenseCertificate.MasterOfEngineering => "ME",
                CodeDegreeLicenseCertificate.MasterOfEducation => "MED",
                CodeDegreeLicenseCertificate.MasterOfElectricalEngineering => "MEE",
                CodeDegreeLicenseCertificate.MasterOfFineArts => "MFA",
                CodeDegreeLicenseCertificate.MasterOfMechanicalEngineering => "MME",
                CodeDegreeLicenseCertificate.MasterOfScience => "MS",
                CodeDegreeLicenseCertificate.MasterOfScienceLaw => "MSL",
                CodeDegreeLicenseCertificate.MasterOfTheology => "MT",
                CodeDegreeLicenseCertificate.NonGraduate => "NG",
                CodeDegreeLicenseCertificate.DoctorOfPhilosophy => "PHD",
                CodeDegreeLicenseCertificate.DoctorOfEngineering => "PHE",
                CodeDegreeLicenseCertificate.DoctorOfScience => "PHS",
                CodeDegreeLicenseCertificate.SecretarialCertificate => "SEC",
                CodeDegreeLicenseCertificate.TradeSchoolGraduate => "TS",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeDegreeLicenseCertificate input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeDelayedAcknowledgmentType enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeDelayedAcknowledgmentType input)
        {
            return input switch
            {
                CodeDelayedAcknowledgmentType.MessageReceived => "D",
                CodeDelayedAcknowledgmentType.AcknowledgmentAfterProcessing => "F",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeDelayedAcknowledgmentType input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeDerivedSpecimen enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeDerivedSpecimen input)
        {
            return input switch
            {
                CodeDerivedSpecimen.ChildObservation => "C",
                CodeDerivedSpecimen.NotApplicable => "N",
                CodeDerivedSpecimen.ParentObservation => "P",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeDerivedSpecimen input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeDiagnosisClassification enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeDiagnosisClassification input)
        {
            return input switch
            {
                CodeDiagnosisClassification.Consultation => "C",
                CodeDiagnosisClassification.Diagnosis => "D",
                CodeDiagnosisClassification.InvasiveProcedureNotClassified => "I",
                CodeDiagnosisClassification.MedicationAntibiotic => "M",
                CodeDiagnosisClassification.Other => "O",
                CodeDiagnosisClassification.RadiologicalScheduling => "R",
                CodeDiagnosisClassification.SignAndSymptom => "S",
                CodeDiagnosisClassification.TissueDiagnosis => "T",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeDiagnosisClassification input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeDiagnosisPriority enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeDiagnosisPriority input)
        {
            return input switch
            {
                CodeDiagnosisPriority.NotIncludedInDiagnosisRanking => "0",
                CodeDiagnosisPriority.ThePrimaryDiagnosis => "1",
                CodeDiagnosisPriority.ForRankedSecondaryDiagnoses => "2 and higher",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeDiagnosisPriority input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeDiagnosisType enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeDiagnosisType input)
        {
            return input switch
            {
                CodeDiagnosisType.Admitting => "A",
                CodeDiagnosisType.Final => "F",
                CodeDiagnosisType.Working => "W",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeDiagnosisType input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeDiagnosticServiceSectionId enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeDiagnosticServiceSectionId input)
        {
            return input switch
            {
                CodeDiagnosticServiceSectionId.Audiology => "AU",
                CodeDiagnosticServiceSectionId.BloodGases => "BG",
                CodeDiagnosticServiceSectionId.BloodBank => "BLB",
                CodeDiagnosticServiceSectionId.Chemistry => "CH",
                CodeDiagnosticServiceSectionId.Cytopathology => "CP",
                CodeDiagnosticServiceSectionId.CatScan => "CT",
                CodeDiagnosticServiceSectionId.CardiacCatheterization => "CTH",
                CodeDiagnosticServiceSectionId.CardiacUltrasound => "CUS",
                CodeDiagnosticServiceSectionId.Electrocardiac => "EC",
                CodeDiagnosticServiceSectionId.Electroneuro => "EN",
                CodeDiagnosticServiceSectionId.Hematology => "HM",
                CodeDiagnosticServiceSectionId.BedsideIcuMonitoring => "ICU",
                CodeDiagnosticServiceSectionId.Immunology => "IMM",
                CodeDiagnosticServiceSectionId.Laboratory => "LAB",
                CodeDiagnosticServiceSectionId.Microbiology => "MB",
                CodeDiagnosticServiceSectionId.Mycobacteriology => "MCB",
                CodeDiagnosticServiceSectionId.Mycology => "MYC",
                CodeDiagnosticServiceSectionId.NuclearMagneticResonance => "NMR",
                CodeDiagnosticServiceSectionId.NuclearMedicineScan => "NMS",
                CodeDiagnosticServiceSectionId.NursingServiceMeasures => "NRS",
                CodeDiagnosticServiceSectionId.OutsideLab => "OSL",
                CodeDiagnosticServiceSectionId.OccupationalTherapy => "OT",
                CodeDiagnosticServiceSectionId.Other => "OTH",
                CodeDiagnosticServiceSectionId.ObUltrasound => "OUS",
                CodeDiagnosticServiceSectionId.PulmonaryFunction => "PF",
                CodeDiagnosticServiceSectionId.Pharmacy => "PHR",
                CodeDiagnosticServiceSectionId.Physician => "PHY",
                CodeDiagnosticServiceSectionId.PhysicalTherapy => "PT",
                CodeDiagnosticServiceSectionId.Radiology => "RAD",
                CodeDiagnosticServiceSectionId.RespiratoryCareTherapy => "RC",
                CodeDiagnosticServiceSectionId.RadiationTherapy => "RT",
                CodeDiagnosticServiceSectionId.RadiologyUltrasound => "RUS",
                CodeDiagnosticServiceSectionId.Radiograph => "RX",
                CodeDiagnosticServiceSectionId.SurgicalPathology => "SP",
                CodeDiagnosticServiceSectionId.Serology => "SR",
                CodeDiagnosticServiceSectionId.Toxicology => "TX",
                CodeDiagnosticServiceSectionId.Virology => "VR",
                CodeDiagnosticServiceSectionId.VascularUltrasound => "VUS",
                CodeDiagnosticServiceSectionId.Cineradiograph => "XRC",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeDiagnosticServiceSectionId input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeDietCodeSpecificationType enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeDietCodeSpecificationType input)
        {
            return input switch
            {
                CodeDietCodeSpecificationType.Diet => "D",
                CodeDietCodeSpecificationType.Preference => "P",
                CodeDietCodeSpecificationType.Supplement => "S",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeDietCodeSpecificationType input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeDisabledPersonCode enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeDisabledPersonCode input)
        {
            return input switch
            {
                CodeDisabledPersonCode.AssociatedParty => "AP",
                CodeDisabledPersonCode.Guarantor => "GT",
                CodeDisabledPersonCode.Insured => "IN",
                CodeDisabledPersonCode.Patient => "PT",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeDisabledPersonCode input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeDispenseMethod enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeDispenseMethod input)
        {
            return input switch
            {
                CodeDispenseMethod.AutomaticDispensing => "AD",
                CodeDispenseMethod.FloorStock => "F",
                CodeDispenseMethod.Traditional => "TR",
                CodeDispenseMethod.UnitDose => "UD",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeDispenseMethod input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeDocumentAvailabilityStatus enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeDocumentAvailabilityStatus input)
        {
            return input switch
            {
                CodeDocumentAvailabilityStatus.AvailableForPatientCare => "AV",
                CodeDocumentAvailabilityStatus.Deleted => "CA",
                CodeDocumentAvailabilityStatus.Obsolete => "OB",
                CodeDocumentAvailabilityStatus.UnavailableForPatientCare => "UN",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeDocumentAvailabilityStatus input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeDocumentCompletionStatus enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeDocumentCompletionStatus input)
        {
            return input switch
            {
                CodeDocumentCompletionStatus.Authenticated => "AU",
                CodeDocumentCompletionStatus.Dictated => "DI",
                CodeDocumentCompletionStatus.Documented => "DO",
                CodeDocumentCompletionStatus.Incomplete => "IN",
                CodeDocumentCompletionStatus.InProgress => "IP",
                CodeDocumentCompletionStatus.LegallyAuthenticated => "LA",
                CodeDocumentCompletionStatus.PreAuthenticated => "PA",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeDocumentCompletionStatus input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeDocumentConfidentialityStatus enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeDocumentConfidentialityStatus input)
        {
            return input switch
            {
                CodeDocumentConfidentialityStatus.Restricted => "R",
                CodeDocumentConfidentialityStatus.UsualControl => "U",
                CodeDocumentConfidentialityStatus.VeryRestricted => "V",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeDocumentConfidentialityStatus input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeDocumentStorageStatus enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeDocumentStorageStatus input)
        {
            return input switch
            {
                CodeDocumentStorageStatus.ActiveAndArchived => "AA",
                CodeDocumentStorageStatus.Active => "AC",
                CodeDocumentStorageStatus.Archived => "AR",
                CodeDocumentStorageStatus.Purged => "PU",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeDocumentStorageStatus input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeDocumentType enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeDocumentType input)
        {
            return input switch
            {
                CodeDocumentType.AutopsyReport => "AR",
                CodeDocumentType.Cardiodiagnostics => "CD",
                CodeDocumentType.Consultation => "CN",
                CodeDocumentType.DiagnosticImaging => "DI",
                CodeDocumentType.DischargeSummary => "DS",
                CodeDocumentType.EmergencyDepartmentReport => "ED",
                CodeDocumentType.HistoryAndPhysicalExamination => "HP",
                CodeDocumentType.OperativeReport => "OP",
                CodeDocumentType.PsychiatricConsultation => "PC",
                CodeDocumentType.PsychiatricHistoryAndPhysicalExamination => "PH",
                CodeDocumentType.ProcedureNote => "PN",
                CodeDocumentType.ProgressNote => "PR",
                CodeDocumentType.SurgicalPathology => "SP",
                CodeDocumentType.TransferSummary => "TS",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeDocumentType input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeDrgPayor enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeDrgPayor input)
        {
            return input switch
            {
                CodeDrgPayor.Champus => "C",
                CodeDrgPayor.ManagedCareOrganization => "G",
                CodeDrgPayor.Medicare => "M",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeDrgPayor input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeDurationCategories enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeDurationCategories input)
        {
            return input switch
            {
                CodeDurationCategories.AsteriskLifeOfTheUnit => "*",
                CodeDurationCategories.TwelveHours => "12H",
                CodeDurationCategories.OneHour => "1H",
                CodeDurationCategories.OneMonth => "1L",
                CodeDurationCategories.OneWeek => "1W",
                CodeDurationCategories.TwoAndAHalfHours => "2.5H",
                CodeDurationCategories.TwentyFourHours => "24H",
                CodeDurationCategories.TwoDays => "2D",
                CodeDurationCategories.TwoHours => "2H",
                CodeDurationCategories.TwoMonths => "2L",
                CodeDurationCategories.TwoWeeks => "2W",
                CodeDurationCategories.ThirtyMinutes => "30M",
                CodeDurationCategories.ThreeDays => "3D",
                CodeDurationCategories.ThreeHours => "3H",
                CodeDurationCategories.ThreeMonths => "3L",
                CodeDurationCategories.ThreeWeeks => "3W",
                CodeDurationCategories.FourDays => "4D",
                CodeDurationCategories.FourHours => "4H",
                CodeDurationCategories.FourWeeks => "4W",
                CodeDurationCategories.FiveDays => "5D",
                CodeDurationCategories.FiveHours => "5H",
                CodeDurationCategories.SixDays => "6D",
                CodeDurationCategories.SixHours => "6H",
                CodeDurationCategories.SevenHours => "7H",
                CodeDurationCategories.EightHours => "8H",
                CodeDurationCategories.PointInTime => "PT",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeDurationCategories input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeEligibilitySource enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeEligibilitySource input)
        {
            return input switch
            {
                CodeEligibilitySource.InsuranceCompany => "1",
                CodeEligibilitySource.Employer => "2",
                CodeEligibilitySource.InsuredPresentedPolicy => "3",
                CodeEligibilitySource.InsuredPresentedCard => "4",
                CodeEligibilitySource.SignedStatementOnFile => "5",
                CodeEligibilitySource.VerbalInformation => "6",
                CodeEligibilitySource.None => "7",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeEligibilitySource input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeEncoding enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeEncoding input)
        {
            return input switch
            {
                CodeEncoding.NoEncoding => "A",
                CodeEncoding.Base64 => "Base64",
                CodeEncoding.Hexadecimal => "Hex",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeEncoding input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeEscortRequired enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeEscortRequired input)
        {
            return input switch
            {
                CodeEscortRequired.NotRequired => "N",
                CodeEscortRequired.Required => "R",
                CodeEscortRequired.Unknown => "U",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeEscortRequired input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeEventConsequence enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeEventConsequence input)
        {
            return input switch
            {
                CodeEventConsequence.CongenitalAnomalyBirthDefect => "C",
                CodeEventConsequence.Death => "D",
                CodeEventConsequence.CausedHospitalized => "H",
                CodeEventConsequence.Incapacity => "I",
                CodeEventConsequence.Disability => "J",
                CodeEventConsequence.LifeThreatening => "L",
                CodeEventConsequence.Other => "O",
                CodeEventConsequence.ProlongedHospitalization => "P",
                CodeEventConsequence.RequiredIntervention => "R",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeEventConsequence input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeEventExpected enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeEventExpected input)
        {
            return input switch
            {
                CodeEventExpected.No => "N",
                CodeEventExpected.Unknown => "U",
                CodeEventExpected.Yes => "Y",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeEventExpected input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeEventQualification enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeEventQualification input)
        {
            return input switch
            {
                CodeEventQualification.Abuse => "A",
                CodeEventQualification.UnexpectedBeneficialEffect => "B",
                CodeEventQualification.Dependency => "D",
                CodeEventQualification.Interaction => "I",
                CodeEventQualification.LackOfExpectTherapeuticEffect => "L",
                CodeEventQualification.Misuse => "M",
                CodeEventQualification.Overdose => "O",
                CodeEventQualification.DrugWithdrawal => "W",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeEventQualification input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeEventReason enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeEventReason input)
        {
            return input switch
            {
                CodeEventReason.PatientRequest => "01",
                CodeEventReason.PhysicianHealthPractitionerOrder => "02",
                CodeEventReason.CensusManagement => "03",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeEventReason input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeEventReportedTo enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeEventReportedTo input)
        {
            return input switch
            {
                CodeEventReportedTo.Distributor => "D",
                CodeEventReportedTo.LocalFacilityUserFacility => "L",
                CodeEventReportedTo.Manufacturer => "M",
                CodeEventReportedTo.RegulatoryAgency => "R",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeEventReportedTo input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeEventSeriousness enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeEventSeriousness input)
        {
            return input switch
            {
                CodeEventSeriousness.No => "N",
                CodeEventSeriousness.Significant => "S",
                CodeEventSeriousness.Yes => "Y",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeEventSeriousness input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeEventTypeCode enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeEventTypeCode input)
        {
            return input switch
            {
                CodeEventTypeCode.AdtAckAdmitVisitNotification => "A01",
                CodeEventTypeCode.AdtAckTransferAPatient => "A02",
                CodeEventTypeCode.AdtAckDischargeEndVisit => "A03",
                CodeEventTypeCode.AdtAckRegisterAPatient => "A04",
                CodeEventTypeCode.AdtAckPreAdmitAPatient => "A05",
                CodeEventTypeCode.AdtAckChangeAnOutpatientToAnInpatient => "A06",
                CodeEventTypeCode.AdtAckChangeAnInpatientToAnOutpatient => "A07",
                CodeEventTypeCode.AdtAckUpdatePatientInformation => "A08",
                CodeEventTypeCode.AdtAckPatientDepartingTracking => "A09",
                CodeEventTypeCode.AdtAckPatientArrivingTracking => "A10",
                CodeEventTypeCode.AdtAckCancelAdmitVisitNotification => "A11",
                CodeEventTypeCode.AdtAckCancelTransfer => "A12",
                CodeEventTypeCode.AdtAckCancelDischargeEndVisit => "A13",
                CodeEventTypeCode.AdtAckPendingAdmit => "A14",
                CodeEventTypeCode.AdtAckPendingTransfer => "A15",
                CodeEventTypeCode.AdtAckPendingDischarge => "A16",
                CodeEventTypeCode.AdtAckSwapPatients => "A17",
                CodeEventTypeCode.AdtAckMergePatientInformation => "A18",
                CodeEventTypeCode.QryAdrPatientQuery => "A19",
                CodeEventTypeCode.AdtAckBedStatusUpdate => "A20",
                CodeEventTypeCode.AdtAckPatientGoesOnALeaveOfAbsence => "A21",
                CodeEventTypeCode.AdtAckPatientReturnsFromALeaveOfAbsence => "A22",
                CodeEventTypeCode.AdtAckDeleteAPatientRecord => "A23",
                CodeEventTypeCode.AdtAckLinkPatientInformation => "A24",
                CodeEventTypeCode.AdtAckCancelPendingDischarge => "A25",
                CodeEventTypeCode.AdtAckCancelPendingTransfer => "A26",
                CodeEventTypeCode.AdtAckCancelPendingAdmit => "A27",
                CodeEventTypeCode.AdtAckAddPersonInformation => "A28",
                CodeEventTypeCode.AdtAckDeletePersonInformation => "A29",
                CodeEventTypeCode.AdtAckMergePersonInformation => "A30",
                CodeEventTypeCode.AdtAckUpdatePersonInformation => "A31",
                CodeEventTypeCode.AdtAckCancelPatientArrivingTracking => "A32",
                CodeEventTypeCode.AdtAckCancelPatientDepartingTracking => "A33",
                CodeEventTypeCode.AdtAckMergePatientInfoPatientId => "A34",
                CodeEventTypeCode.AdtAckMergePatientInfoAccountNumber => "A35",
                CodeEventTypeCode.AdtAckMergePatientInfoPatientIdAccountNumber => "A36",
                CodeEventTypeCode.AdtAckUnlinkPatientInformation => "A37",
                CodeEventTypeCode.AdtAckCancelPreAdmit => "A38",
                CodeEventTypeCode.AdtAckMergePersonPatientId => "A39",
                CodeEventTypeCode.AdtAckMergePatientPatientIdList => "A40",
                CodeEventTypeCode.AdtAckMergeAccountPatientAccountNumber => "A41",
                CodeEventTypeCode.AdtAckMergeVisitVisitNumber => "A42",
                CodeEventTypeCode.AdtAckMovePatientInfoPatientIdList => "A43",
                CodeEventTypeCode.AdtAckMoveAccountInfoPatientAccountNumber => "A44",
                CodeEventTypeCode.AdtAckMoveVisitInfoVisitNumber => "A45",
                CodeEventTypeCode.AdtAckChangePatientId => "A46",
                CodeEventTypeCode.AdtAckChangePatientIdList => "A47",
                CodeEventTypeCode.AdtAckChangeAlternatePatientId => "A48",
                CodeEventTypeCode.AdtAckChangePatientAccountNumber => "A49",
                CodeEventTypeCode.AdtAckChangeVisitNumber => "A50",
                CodeEventTypeCode.AdtAckChangeAlternateVisitId => "A51",
                CodeEventTypeCode.CrmRegisterPatientOnClinicalTrial => "C01",
                CodeEventTypeCode.CrmCancelPatientRegistrationOnClinicalTrial => "C02",
                CodeEventTypeCode.CrmUpdateRegistrationInformation => "C03",
                CodeEventTypeCode.CrmPatientOffClinicalTrial => "C04",
                CodeEventTypeCode.CrmPatientEntersPhaseOfClinicalTrial => "C05",
                CodeEventTypeCode.CrmCancelPatientEnteringPhase => "C06",
                CodeEventTypeCode.CrmUpdatePhaseInfo => "C07",
                CodeEventTypeCode.CrmPatientHasGoneOffPhaseOfClinicalTrial => "C08",
                CodeEventTypeCode.CsuAutomatedTimeIntervalsForReporting => "C09",
                CodeEventTypeCode.CsuPatientCompletesClinicalTrial => "C10",
                CodeEventTypeCode.CsuPatientCompletesPhaseOfClinicalTrial => "C11",
                CodeEventTypeCode.CsuUpdatePatientOrderResultInfo => "C12",
                CodeEventTypeCode.CancelQuery => "CNQ",
                CodeEventTypeCode.RqiRpiRequestForInsuranceInformation => "I01",
                CodeEventTypeCode.RqiRplRequestReceiptOfPatientSelectionDisplayList => "I02",
                CodeEventTypeCode.RqiRprRequestReceiptOfPatientSelectionList => "I03",
                CodeEventTypeCode.RqdRpiRequestForPatientDemographicData => "I04",
                CodeEventTypeCode.RqcRciRequestForPatientClinicalInformation => "I05",
                CodeEventTypeCode.RqcRclRequestReceiptOfClinicalDataListing => "I06",
                CodeEventTypeCode.PinAckUnsolicitedInsuranceInformation => "I07",
                CodeEventTypeCode.RqaRpaRequestForTreatmentAuthorizationInformation => "I08",
                CodeEventTypeCode.RqaRpaRequestForModificationToAuthorization => "I09",
                CodeEventTypeCode.RqaRpaRequestForResubmissionOfAuthorization => "I10",
                CodeEventTypeCode.RqaRpaRequestForCancellationOfAuthorization => "I11",
                CodeEventTypeCode.RefRriPatientReferral => "I12",
                CodeEventTypeCode.RefRriModifyPatientReferral => "I13",
                CodeEventTypeCode.RefRriCancelPatientReferral => "I14",
                CodeEventTypeCode.RefRriRequestPatientReferralStatus => "I15",
                CodeEventTypeCode.MfnMfkMasterFileNotOtherwiseSpecified => "M01",
                CodeEventTypeCode.MfnMfkMasterFileStaffPractitioner => "M02",
                CodeEventTypeCode.MfnMfkMasterFileTestObservation => "M03",
                CodeEventTypeCode.MfnMfkMasterFilesChargeDescription => "M04",
                CodeEventTypeCode.MfnMfkPatientLocationMasterFile => "M05",
                CodeEventTypeCode.MfnMfkClinicalStudyWithPhasesAndSchedulesMasterFile => "M06",
                CodeEventTypeCode.MfnMfkClinicalStudyWithoutPhasesButWithSchedulesMasterFile => "M07",
                CodeEventTypeCode.MfnMfkTestObservationNumericMasterFile => "M08",
                CodeEventTypeCode.MfnMfkTestObservationCategoricalMasterFile => "M09",
                CodeEventTypeCode.MfnMfkTestObservationBatteriesMasterFile => "M10",
                CodeEventTypeCode.MfnMfkTestCalculatedObservationsMasterFile => "M11",
                CodeEventTypeCode.OrmOrderMessage => "O01",
                CodeEventTypeCode.OrrOrderResponse => "O02",
                CodeEventTypeCode.BarAckAddPatientAccounts => "P01",
                CodeEventTypeCode.BarAckPurgePatientAccounts => "P02",
                CodeEventTypeCode.DftAckPostDetailFinancialTransaction => "P03",
                CodeEventTypeCode.QryDspGenerateBillAndARStatements => "P04",
                CodeEventTypeCode.BarAckUpdateAccount => "P05",
                CodeEventTypeCode.BarAckEndAccount => "P06",
                CodeEventTypeCode.PexUnsolicitedInitialExperienceReport => "P07",
                CodeEventTypeCode.PexUnsolicitedUpdateExperienceReport => "P08",
                CodeEventTypeCode.SurSummaryExperienceReport => "P09",
                CodeEventTypeCode.PprPcProblemAdd => "PC1",
                CodeEventTypeCode.PprPcProblemUpdate => "PC2",
                CodeEventTypeCode.PprPcProblemDelete => "PC3",
                CodeEventTypeCode.QryPcProblemQuery => "PC4",
                CodeEventTypeCode.PrrPcProblemResponse => "PC5",
                CodeEventTypeCode.PglPcGoalAdd => "PC6",
                CodeEventTypeCode.PglPcGoalUpdate => "PC7",
                CodeEventTypeCode.PglPcGoalDelete => "PC8",
                CodeEventTypeCode.QryPcGoalQuery => "PC9",
                CodeEventTypeCode.PpvPcGoalResponse => "PCA",
                CodeEventTypeCode.PppPcPathwayProblemOrientedAdd => "PCB",
                CodeEventTypeCode.PppPcPathwayProblemOrientedUpdate => "PCC",
                CodeEventTypeCode.PppPcPathwayProblemOrientedDelete => "PCD",
                CodeEventTypeCode.QryPcPathwayProblemOrientedQuery => "PCE",
                CodeEventTypeCode.PtrPcPathwayProblemOrientedQueryResponse => "PCF",
                CodeEventTypeCode.PpgPcPathwayGoalOrientedAdd => "PCG",
                CodeEventTypeCode.PpgPcPathwayGoalOrientedUpdate => "PCH",
                CodeEventTypeCode.PpgPcPathwayGoalOrientedDelete => "PCJ",
                CodeEventTypeCode.QryPcPathwayGoalOrientedQuery => "PCK",
                CodeEventTypeCode.PptPcPathwayGoalOrientedQueryResponse => "PCL",
                CodeEventTypeCode.QryDsrQuerySentForImmediateResponse => "Q01",
                CodeEventTypeCode.QryQckQuerySentForDeferredResponse => "Q02",
                CodeEventTypeCode.DsrAckDeferredResponseToAQuery => "Q03",
                CodeEventTypeCode.EqqEmbeddedQueryLanguageQuery => "Q04",
                CodeEventTypeCode.UdmAckUnsolicitedDisplayUpdateMessage => "Q05",
                CodeEventTypeCode.OsqOsrQueryForOrderStatus => "Q06",
                CodeEventTypeCode.VqqVirtualTableQuery => "Q07",
                CodeEventTypeCode.SpqStoredProcedureRequest => "Q08",
                CodeEventTypeCode.RqqEventReplayQuery => "Q09",
                CodeEventTypeCode.OruAckUnsolicitedTransmissionOfObservation => "R01",
                CodeEventTypeCode.QryQueryForResultsOfObservation => "R02",
                CodeEventTypeCode.QryDsrDisplayOrientedResultsQueryUnsolUpdate => "R03",
                CodeEventTypeCode.OrfResponseToQueryTransmissionOfRequestedObservation => "R04",
                CodeEventTypeCode.QryDsrQueryForDisplayResults => "R05",
                CodeEventTypeCode.UdmUnsolicitedUpdateDisplayResults => "R06",
                CodeEventTypeCode.EdrEnhancedDisplayResponse => "R07",
                CodeEventTypeCode.TbrTabularDataResponse => "R08",
                CodeEventTypeCode.ErpEventReplayResponse => "R09",
                CodeEventTypeCode.R0rPharmacyPrescriptionOrderQueryResponse => "R0R",
                CodeEventTypeCode.RarPharmacyAdministrationInfoQueryResponse => "RAR",
                CodeEventTypeCode.RdrPharmacyDispenseInfoQueryResponse => "RDR",
                CodeEventTypeCode.RerPharmacyEncodedOrderInfoQueryResponse => "RER",
                CodeEventTypeCode.RgrPharmacyDoseInfoQueryResponse => "RGR",
                CodeEventTypeCode.RorPharmacyPrescriptionOrderQueryResponse => "ROR",
                CodeEventTypeCode.SrmSrrRequestNewAppointmentBooking => "S01",
                CodeEventTypeCode.SrmSrrRequestAppointmentRescheduling => "S02",
                CodeEventTypeCode.SrmSrrRequestAppointmentModification => "S03",
                CodeEventTypeCode.SrmSrrRequestAppointmentCancellation => "S04",
                CodeEventTypeCode.SrmSrrRequestAppointmentDiscontinuation => "S05",
                CodeEventTypeCode.SrmSrrRequestAppointmentDeletion => "S06",
                CodeEventTypeCode.SrmSrrRequestAdditionOfServiceOnAppointment => "S07",
                CodeEventTypeCode.SrmSrrRequestModificationOfServiceOnAppointment => "S08",
                CodeEventTypeCode.SrmSrrRequestCancellationOfServiceOnAppointment => "S09",
                CodeEventTypeCode.SrmSrrRequestDiscontinuationOfServiceOnAppointment => "S10",
                CodeEventTypeCode.SrmSrrRequestDeletionOfServiceOnAppointment => "S11",
                CodeEventTypeCode.SiuAckNotifyNewAppointmentBooking => "S12",
                CodeEventTypeCode.SiuAckNotifyAppointmentRescheduling => "S13",
                CodeEventTypeCode.SiuAckNotifyAppointmentModification => "S14",
                CodeEventTypeCode.SiuAckNotifyAppointmentCancellation => "S15",
                CodeEventTypeCode.SiuAckNotificationOfAppointmentDiscontinuation => "S16",
                CodeEventTypeCode.SiuAckNotifyAppointmentDeletion => "S17",
                CodeEventTypeCode.SiuAckNotifyAdditionOfServiceOnAppointment => "S18",
                CodeEventTypeCode.SiuAckNotifyModificationOfServiceOnAppointment => "S19",
                CodeEventTypeCode.SiuAckNotifyCancellationOfServiceOnAppointment => "S20",
                CodeEventTypeCode.SiuAckNotifyDiscontinuationOfServiceOnAppointment => "S21",
                CodeEventTypeCode.SiuAckNotifyDeletionOfServiceResourceOnAppointment => "S22",
                CodeEventTypeCode.SiuAckNotifyBlockedScheduleTimeSlots => "S23",
                CodeEventTypeCode.SiuAckNotifyOpenedUnblockedScheduleTimeSlots => "S24",
                CodeEventTypeCode.SqmSqrScheduleQueryMessageAndResponse => "S25",
                CodeEventTypeCode.SiuAckNotifyPatientDidNotShowUpForAppointment => "S26",
                CodeEventTypeCode.MdmAckOriginalDocument => "T01",
                CodeEventTypeCode.MdmAckOriginalDocumentNotifyAndContent => "T02",
                CodeEventTypeCode.MdmAckDocumentStatusChange => "T03",
                CodeEventTypeCode.MdmAckDocumentStatusChangeNotifyAndContent => "T04",
                CodeEventTypeCode.MdmAckDocumentAddendum => "T05",
                CodeEventTypeCode.MdmAckDocumentAddendumNotifyAndContent => "T06",
                CodeEventTypeCode.MdmAckDocumentEdit => "T07",
                CodeEventTypeCode.MdmAckDocumentEditNotifyAndContent => "T08",
                CodeEventTypeCode.MdmAckDocumentReplacement => "T09",
                CodeEventTypeCode.MdmAckDocumentReplacementNotifyAndContent => "T10",
                CodeEventTypeCode.MdmAckDocumentCancel => "T11",
                CodeEventTypeCode.QryDocDocumentQuery => "T12",
                CodeEventTypeCode.VxqQueryForVaccinationRecord => "V01",
                CodeEventTypeCode.VxxResponseToVaccinationQueryMultiplePidMatches => "V02",
                CodeEventTypeCode.VxrVaccinationRecordResponse => "V03",
                CodeEventTypeCode.VxuUnsolicitedVaccinationRecordUpdate => "V04",
                CodeEventTypeCode.MfqMfrMasterFilesQuery => "Varies",
                CodeEventTypeCode.OruWaveformResultUnsolicitedTransmission => "W01",
                CodeEventTypeCode.QrfWaveformResultResponseToQuery => "W02",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeEventTypeCode input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeFacilityType enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeFacilityType input)
        {
            return input switch
            {
                CodeFacilityType.AgentForForeignManufacturer => "A",
                CodeFacilityType.Distributor => "D",
                CodeFacilityType.Manufacturer => "M",
                CodeFacilityType.User => "U",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeFacilityType input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeFileLevelEventCode enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeFileLevelEventCode input)
        {
            return input switch
            {
                CodeFileLevelEventCode.ReplaceCurrentVersionOfMasterFile => "REP",
                CodeFileLevelEventCode.ChangeFileRecordsAsDefined => "UPD",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeFileLevelEventCode input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeFillerStatusCodes enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeFillerStatusCodes input)
        {
            return input switch
            {
                CodeFillerStatusCodes.Blocked => "Blocked",
                CodeFillerStatusCodes.Booked => "Booked",
                CodeFillerStatusCodes.Cancelled => "Cancelled",
                CodeFillerStatusCodes.Complete => "Complete",
                CodeFillerStatusCodes.Deleted => "Deleted",
                CodeFillerStatusCodes.Discontinued => "Discontinued",
                CodeFillerStatusCodes.Overbook => "Overbook",
                CodeFillerStatusCodes.Pending => "Pending",
                CodeFillerStatusCodes.Started => "Started",
                CodeFillerStatusCodes.Waitlist => "Waitlist",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeFillerStatusCodes input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeIdentifierType enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeIdentifierType input)
        {
            return input switch
            {
                CodeIdentifierType.AmericanExpress => "AM",
                CodeIdentifierType.AccountNumber => "AN",
                CodeIdentifierType.BirthRegistryNumber => "BR",
                CodeIdentifierType.DinersClubCard => "DI",
                CodeIdentifierType.DriversLicenseNumber => "DL",
                CodeIdentifierType.DoctorNumber => "DN",
                CodeIdentifierType.DiscoverCard => "DS",
                CodeIdentifierType.EmployeeNumber => "EI",
                CodeIdentifierType.EmployerNumber => "EN",
                CodeIdentifierType.FacilityId => "FI",
                CodeIdentifierType.GuarantorInternalIdentifier => "GI",
                CodeIdentifierType.GuarantorExternalIdentifier => "GN",
                CodeIdentifierType.LicenseNumber => "LN",
                CodeIdentifierType.LocalRegistryId => "LR",
                CodeIdentifierType.PatientMedicaidNumber => "MA",
                CodeIdentifierType.PatientsMedicareNumber => "MC",
                CodeIdentifierType.MedicalRecordNumber => "MR",
                CodeIdentifierType.Mastercard => "MS",
                CodeIdentifierType.NationalEmployerId => "NE",
                CodeIdentifierType.NationalHealthPlanId => "NH",
                CodeIdentifierType.NationalUniqueIndividualId => "NI",
                CodeIdentifierType.NationalPersonIdentifier => "NNxxx",
                CodeIdentifierType.NationalProviderIdentifier => "NPI",
                CodeIdentifierType.PatientInternalIdentifier => "PI",
                CodeIdentifierType.PersonNumber => "PN",
                CodeIdentifierType.ProviderNumber => "PRN",
                CodeIdentifierType.PatientExternalIdentifier => "PT",
                CodeIdentifierType.RailroadRetirementNumber => "RR",
                CodeIdentifierType.RegionalRegistryId => "RRI",
                CodeIdentifierType.StateLicense => "SL",
                CodeIdentifierType.StateRegistryId => "SR",
                CodeIdentifierType.SocialSecurityNumber => "SS",
                CodeIdentifierType.UnspecifiedIdentifier => "U",
                CodeIdentifierType.MedicareCmsUniversalPhysicianId => "UPIN",
                CodeIdentifierType.VisitNumber => "VN",
                CodeIdentifierType.Visa => "VS",
                CodeIdentifierType.WicIdentifier => "WC",
                CodeIdentifierType.OrganizationIdentifier => "XX",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeIdentifierType input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeIdentityMayBeDivulged enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeIdentityMayBeDivulged input)
        {
            return input switch
            {
                CodeIdentityMayBeDivulged.No => "N",
                CodeIdentityMayBeDivulged.NotApplicable => "NA",
                CodeIdentityMayBeDivulged.Yes => "Y",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeIdentityMayBeDivulged input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeIndirectExposureMechanism enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeIndirectExposureMechanism input)
        {
            return input switch
            {
                CodeIndirectExposureMechanism.BreastMilk => "B",
                CodeIndirectExposureMechanism.Father => "F",
                CodeIndirectExposureMechanism.Other => "O",
                CodeIndirectExposureMechanism.Transplacental => "P",
                CodeIndirectExposureMechanism.BloodProduct => "X",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeIndirectExposureMechanism input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeInsuranceCompanyContactReason enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeInsuranceCompanyContactReason input)
        {
            return input switch
            {
                CodeInsuranceCompanyContactReason.MedicareClaimStatus => "01",
                CodeInsuranceCompanyContactReason.MedicaidClaimStatus => "02",
                CodeInsuranceCompanyContactReason.NameAddressChange => "03",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeInsuranceCompanyContactReason input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeInterpretationCodes enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeInterpretationCodes input)
        {
            return input switch
            {
                CodeInterpretationCodes.OffScaleLow => "",
                CodeInterpretationCodes.OffScaleHigh => "",
                CodeInterpretationCodes.Abnormal => "A",
                CodeInterpretationCodes.CriticallyAbnormal => "AA",
                CodeInterpretationCodes.Better => "B",
                CodeInterpretationCodes.SignificantChangeDown => "D",
                CodeInterpretationCodes.High => "H",
                CodeInterpretationCodes.CriticallyHigh => "HH",
                CodeInterpretationCodes.Intermediate => "I",
                CodeInterpretationCodes.Low => "L",
                CodeInterpretationCodes.CriticallyLow => "LL",
                CodeInterpretationCodes.ModeratelySusceptible => "MS",
                CodeInterpretationCodes.Normal => "N",
                CodeInterpretationCodes.NoRangeDefinedOrNormalRangesDontApply => "null",
                CodeInterpretationCodes.Resistant => "R",
                CodeInterpretationCodes.Susceptible => "S",
                CodeInterpretationCodes.SignificantChangeUp => "U",
                CodeInterpretationCodes.VerySusceptible => "VS",
                CodeInterpretationCodes.Worse => "W",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeInterpretationCodes input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeInvocationEvent enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeInvocationEvent input)
        {
            return input switch
            {
                CodeInvocationEvent.OnDischarge => "D",
                CodeInvocationEvent.OnReceiptOfOrder => "O",
                CodeInvocationEvent.AtTimeServiceIsCompleted => "R",
                CodeInvocationEvent.AtTimeServiceIsStarted => "S",
                CodeInvocationEvent.AtDesignatedDateTime => "T",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeInvocationEvent input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeKindOfQuantity enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeKindOfQuantity input)
        {
            return input switch
            {
                CodeKindOfQuantity.Absorbance => "ABS",
                CodeKindOfQuantity.ConcentrationArbitrarySubstance => "ACNC",
                CodeKindOfQuantity.Activity => "ACT",
                CodeKindOfQuantity.Appearance => "APER",
                CodeKindOfQuantity.Arbitrary => "ARB",
                CodeKindOfQuantity.Area => "AREA",
                CodeKindOfQuantity.Aspect => "ASPECT",
                CodeKindOfQuantity.CatalyticActivity => "CACT",
                CodeKindOfQuantity.CatalyticContent => "CCNT",
                CodeKindOfQuantity.CatalyticConcentrationRatio => "CCRTO",
                CodeKindOfQuantity.CatalyticFraction => "CFR",
                CodeKindOfQuantity.Class => "CLAS",
                CodeKindOfQuantity.CatalyticConcentration => "CNC",
                CodeKindOfQuantity.Constant => "CNST",
                CodeKindOfQuantity.Coefficient => "COEF",
                CodeKindOfQuantity.Color => "COLOR",
                CodeKindOfQuantity.Consistency => "CONS",
                CodeKindOfQuantity.CatalyticRate => "CRAT",
                CodeKindOfQuantity.CatalyticRatio => "CRTO",
                CodeKindOfQuantity.Density => "DEN",
                CodeKindOfQuantity.Device => "DEV",
                CodeKindOfQuantity.Difference => "DIFF",
                CodeKindOfQuantity.Elasticity => "ELAS",
                CodeKindOfQuantity.ElectricalPotential => "ELPOT",
                CodeKindOfQuantity.ElectricalCurrent => "ELRAT",
                CodeKindOfQuantity.ElectricalResistance => "ELRES",
                CodeKindOfQuantity.Energy => "ENGR",
                CodeKindOfQuantity.Entitic => "ENT",
                CodeKindOfQuantity.EntiticCatalyticActivity => "ENTCAT",
                CodeKindOfQuantity.EntiticNumber => "ENTNUM",
                CodeKindOfQuantity.EntiticSubstanceOfAmount => "ENTSUB",
                CodeKindOfQuantity.EntiticVolume => "ENTVOL",
                CodeKindOfQuantity.Equilibrium => "EQL",
                CodeKindOfQuantity.MechanicalForce => "FORCE",
                CodeKindOfQuantity.Frequency => "FREQ",
                CodeKindOfQuantity.ImpressionInterpretationOfStudy => "IMP",
                CodeKindOfQuantity.KinematicViscosity => "KINV",
                CodeKindOfQuantity.Length => "LEN",
                CodeKindOfQuantity.LengthIncrement => "LINC",
                CodeKindOfQuantity.Liquefaction => "LIQ",
                CodeKindOfQuantity.Mass => "MASS",
                CodeKindOfQuantity.MassConcentration => "MCNC",
                CodeKindOfQuantity.MassContent => "MCNT",
                CodeKindOfQuantity.MassConcentrationRatio => "MCRTO",
                CodeKindOfQuantity.MassFraction => "MFR",
                CodeKindOfQuantity.MagneticFlux => "MGFLUX",
                CodeKindOfQuantity.MassIncrement => "MINC",
                CodeKindOfQuantity.Morphology => "MORPH",
                CodeKindOfQuantity.Motility => "MOTIL",
                CodeKindOfQuantity.MassRate => "MRAT",
                CodeKindOfQuantity.MassRatio => "MRTO",
                CodeKindOfQuantity.NumberConcentration => "NCNC",
                CodeKindOfQuantity.NumberContent => "NCNT",
                CodeKindOfQuantity.NumberFraction => "NFR",
                CodeKindOfQuantity.NumberRatio => "NRTO",
                CodeKindOfQuantity.Number => "NUM",
                CodeKindOfQuantity.OpticalDensity => "OD",
                CodeKindOfQuantity.Osmolality => "OSMOL",
                CodeKindOfQuantity.Pressure => "PRES",
                CodeKindOfQuantity.PresenceIdentityExistence => "PRID",
                CodeKindOfQuantity.PowerWattage => "PWR",
                CodeKindOfQuantity.Ranges => "RANGE",
                CodeKindOfQuantity.Ratios => "RATIO",
                CodeKindOfQuantity.ReciprocalRelativeTime => "RCRLTM",
                CodeKindOfQuantity.RelativeDensity => "RDEN",
                CodeKindOfQuantity.Relative => "REL",
                CodeKindOfQuantity.RelativeMassConcentration => "RLMCNC",
                CodeKindOfQuantity.RelativeSubstanceConcentration => "RLSCNC",
                CodeKindOfQuantity.RelativeTime => "RLTM",
                CodeKindOfQuantity.SaturationFraction => "SATFR",
                CodeKindOfQuantity.SubstanceConcentration => "SCNC",
                CodeKindOfQuantity.SubstanceConcentrationIncrement => "SCNCIN",
                CodeKindOfQuantity.SubstanceContent => "SCNT",
                CodeKindOfQuantity.SubstanceContentRate => "SCNTR",
                CodeKindOfQuantity.SubstanceConcentrationRatio => "SCRTO",
                CodeKindOfQuantity.SubstanceFraction => "SFR",
                CodeKindOfQuantity.Shape => "SHAPE",
                CodeKindOfQuantity.Smell => "SMELL",
                CodeKindOfQuantity.SubstanceRate => "SRAT",
                CodeKindOfQuantity.SubstanceRatio => "SRTO",
                CodeKindOfQuantity.SubstanceAmount => "SUB",
                CodeKindOfQuantity.Susceptibility => "SUSC",
                CodeKindOfQuantity.Taste => "TASTE",
                CodeKindOfQuantity.Temperature => "TEMP",
                CodeKindOfQuantity.TemperatureDifference => "TEMPDF",
                CodeKindOfQuantity.TemperatureIncrement => "TEMPIN",
                CodeKindOfQuantity.ThresholdMassConcentration => "THRMCNC",
                CodeKindOfQuantity.ThresholdSubstanceConcentration => "THRSCNC",
                CodeKindOfQuantity.Time => "TIME",
                CodeKindOfQuantity.DilutionFactor => "TITR",
                CodeKindOfQuantity.TimeDifference => "TMDF",
                CodeKindOfQuantity.TimeStampDateAndTime => "TMSTP",
                CodeKindOfQuantity.TimeRatio => "TRTO",
                CodeKindOfQuantity.Type => "TYPE",
                CodeKindOfQuantity.VolumeContent => "VCNT",
                CodeKindOfQuantity.Velocity => "VEL",
                CodeKindOfQuantity.VelocityRatio => "VELRT",
                CodeKindOfQuantity.VolumeFraction => "VFR",
                CodeKindOfQuantity.Viscosity => "VISC",
                CodeKindOfQuantity.Volume => "VOL",
                CodeKindOfQuantity.VolumeRate => "VRAT",
                CodeKindOfQuantity.VolumeRatio => "VRTO",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeKindOfQuantity input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeLevelOfCare enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeLevelOfCare input)
        {
            return input switch
            {
                CodeLevelOfCare.Ambulatory => "A",
                CodeLevelOfCare.CriticalCare => "C",
                CodeLevelOfCare.Emergency => "E",
                CodeLevelOfCare.Isolation => "F",
                CodeLevelOfCare.IntensiveCare => "N",
                CodeLevelOfCare.Routine => "R",
                CodeLevelOfCare.Surgery => "S",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeLevelOfCare input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeLivingArrangement enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeLivingArrangement input)
        {
            return input switch
            {
                CodeLivingArrangement.Alone => "A",
                CodeLivingArrangement.Family => "F",
                CodeLivingArrangement.Institution => "I",
                CodeLivingArrangement.Relative => "R",
                CodeLivingArrangement.SpouseOnly => "S",
                CodeLivingArrangement.Unknown => "U",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeLivingArrangement input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeLivingDependency enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeLivingDependency input)
        {
            return input switch
            {
                CodeLivingDependency.CommonBathDeprecated => "CB",
                CodeLivingDependency.SpouseDependentDeprecated => "D",
                CodeLivingDependency.MedicalSupervisionRequired => "M",
                CodeLivingDependency.SpouseDependent => "S",
                CodeLivingDependency.WalkUpDeprecated => "WU",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeLivingDependency input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeLivingWillCode enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeLivingWillCode input)
        {
            return input switch
            {
                CodeLivingWillCode.YesPatientHasLivingWillButNotOnFile => "F",
                CodeLivingWillCode.NoPatientDoesNotHaveLivingWillButInfoWasProvided => "I",
                CodeLivingWillCode.NoPatientDoesNotHaveLivingWillAndNoInfoWasProvided => "N",
                CodeLivingWillCode.Unknown => "U",
                CodeLivingWillCode.YesPatientHasLivingWill => "Y",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeLivingWillCode input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeLocationCharacteristicId enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeLocationCharacteristicId input)
        {
            return input switch
            {
                CodeLocationCharacteristicId.GenderOfPatientS => "GEN",
                CodeLocationCharacteristicId.Implant => "IMP",
                CodeLocationCharacteristicId.InfectiousDisease => "INF",
                CodeLocationCharacteristicId.LevelOfCare => "LCR",
                CodeLocationCharacteristicId.Licensed => "LIC",
                CodeLocationCharacteristicId.Overflow => "OVR",
                CodeLocationCharacteristicId.PrivacyLevel => "PRL",
                CodeLocationCharacteristicId.BedIsSetUp => "SET",
                CodeLocationCharacteristicId.Shadow => "SHA",
                CodeLocationCharacteristicId.Smoking => "SMK",
                CodeLocationCharacteristicId.BedIsStaffed => "STF",
                CodeLocationCharacteristicId.TeachingLocation => "TEA",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeLocationCharacteristicId input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeLocationEquipment enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeLocationEquipment input)
        {
            return input switch
            {
                CodeLocationEquipment.ElectroEncephalogram => "EEG",
                CodeLocationEquipment.ElectroCardiogram => "EKG",
                CodeLocationEquipment.InfusionPump => "INF",
                CodeLocationEquipment.IvPump => "IVP",
                CodeLocationEquipment.Oxygen => "OXY",
                CodeLocationEquipment.Suction => "SUC",
                CodeLocationEquipment.Ventilator => "VEN",
                CodeLocationEquipment.VitalSignsMonitor => "VIT",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeLocationEquipment input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeLocationRelationshipId enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeLocationRelationshipId input)
        {
            return input switch
            {
                CodeLocationRelationshipId.LocationAliasEs => "ALI",
                CodeLocationRelationshipId.NearestDietaryLocation => "DTY",
                CodeLocationRelationshipId.NearestLab => "LAB",
                CodeLocationRelationshipId.SecondNearestLab => "LB2",
                CodeLocationRelationshipId.ParentLocation => "PAR",
                CodeLocationRelationshipId.NearestPharmacy => "RX",
                CodeLocationRelationshipId.SecondNearestPharmacy => "RX2",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeLocationRelationshipId input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeMailClaimParty enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeMailClaimParty input)
        {
            return input switch
            {
                CodeMailClaimParty.Employer => "E",
                CodeMailClaimParty.Guarantor => "G",
                CodeMailClaimParty.InsuranceCompany => "I",
                CodeMailClaimParty.Other => "O",
                CodeMailClaimParty.Patient => "P",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeMailClaimParty input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeManufacturersOfVaccines enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeManufacturersOfVaccines input)
        {
            return input switch
            {
                CodeManufacturersOfVaccines.AbbottLaboratories => "AB",
                CodeManufacturersOfVaccines.AdamsLaboratoriesInc => "AD",
                CodeManufacturersOfVaccines.AlphaTherapeuticCorporation => "ALP",
                CodeManufacturersOfVaccines.Armour => "AR",
                CodeManufacturersOfVaccines.Aviron => "AVI",
                CodeManufacturersOfVaccines.BaxterHealthcareCorporationDeprecated => "BA",
                CodeManufacturersOfVaccines.BayerCorporation => "BAY",
                CodeManufacturersOfVaccines.BernaProducts => "BP",
                CodeManufacturersOfVaccines.BernaProductsCorporation => "BPC",
                CodeManufacturersOfVaccines.CenteonLLC => "CEN",
                CodeManufacturersOfVaccines.ChironCorporation => "CHI",
                CodeManufacturersOfVaccines.Connaught => "CON",
                CodeManufacturersOfVaccines.EvansMedicalLimited => "EVN",
                CodeManufacturersOfVaccines.GreerLaboratoriesInc => "GRE",
                CodeManufacturersOfVaccines.ImmunoInternationalAg => "IAG",
                CodeManufacturersOfVaccines.Merieux => "IM",
                CodeManufacturersOfVaccines.ImmunoUSInc => "IUS",
                CodeManufacturersOfVaccines.ResearchFoundationForMicrobialDiseasesOfOsaka => "JPN",
                CodeManufacturersOfVaccines.KoreaGreenCrossCorporation => "KGC",
                CodeManufacturersOfVaccines.Lederle => "LED",
                CodeManufacturersOfVaccines.MassachusettsPublicHealthBiologicLabs => "MA",
                CodeManufacturersOfVaccines.MedimmuneInc => "MED",
                CodeManufacturersOfVaccines.Miles => "MIL",
                CodeManufacturersOfVaccines.BioportCorporation => "MIP",
                CodeManufacturersOfVaccines.MerckCoInc => "MSD",
                CodeManufacturersOfVaccines.Nabi => "NAB",
                CodeManufacturersOfVaccines.NorthAmericanVaccineInc => "NAV",
                CodeManufacturersOfVaccines.NovartisPharmaceuticalCorporation => "NOV",
                CodeManufacturersOfVaccines.NewYorkBloodCenter => "NYB",
                CodeManufacturersOfVaccines.OrthoClinicalDiagnostics => "ORT",
                CodeManufacturersOfVaccines.OrganonTeknikaCorporation => "OTC",
                CodeManufacturersOfVaccines.OtherManufacturer => "OTH",
                CodeManufacturersOfVaccines.ParkedalePharmaceuticals => "PD",
                CodeManufacturersOfVaccines.SanofiPasteur => "PMC",
                CodeManufacturersOfVaccines.PraxisBiologics => "PRX",
                CodeManufacturersOfVaccines.SclavoInc => "SCL",
                CodeManufacturersOfVaccines.SwissSerumAndVaccineInst => "SI",
                CodeManufacturersOfVaccines.Glaxosmithkline => "SKB",
                CodeManufacturersOfVaccines.UnknownManufacturer => "UNK",
                CodeManufacturersOfVaccines.UsArmyMedicalResearchAndMaterialCommand => "USA",
                CodeManufacturersOfVaccines.WyethAyerstDeprecated => "WA",
                CodeManufacturersOfVaccines.WyethAyerst => "WAL",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeManufacturersOfVaccines input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeMaritalStatus enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeMaritalStatus input)
        {
            return input switch
            {
                CodeMaritalStatus.Separated => "A",
                CodeMaritalStatus.Divorced => "D",
                CodeMaritalStatus.Married => "M",
                CodeMaritalStatus.Single => "S",
                CodeMaritalStatus.Widowed => "W",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeMaritalStatus input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeMarketingBasis enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeMarketingBasis input)
        {
            return input switch
            {
                CodeMarketingBasis.Basis510KExempt => "510E",
                CodeMarketingBasis.Basis510K => "510K",
                CodeMarketingBasis.PostMarketingStudy522 => "522S",
                CodeMarketingBasis.PremarketingAuthorization => "PMA",
                CodeMarketingBasis.Preamendment => "PRE",
                CodeMarketingBasis.Transitional => "TXN",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeMarketingBasis input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeMasterfileActionCode enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeMasterfileActionCode input)
        {
            return input switch
            {
                CodeMasterfileActionCode.ReactivateDeactivatedRecord => "MAC",
                CodeMasterfileActionCode.AddRecordToMasterFile => "MAD",
                CodeMasterfileActionCode.Deactivate => "MDC",
                CodeMasterfileActionCode.DeleteRecordFromMasterFile => "MDL",
                CodeMasterfileActionCode.UpdateRecordForMasterFile => "MUP",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeMasterfileActionCode input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeMasterFileIdentifierCode enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeMasterFileIdentifierCode input)
        {
            return input switch
            {
                CodeMasterFileIdentifierCode.ChargeDescriptionMasterFile => "CDM",
                CodeMasterFileIdentifierCode.ClinicalStudyWithPhasesAndScheduledMasterFile => "CMA",
                CodeMasterFileIdentifierCode.ClinicalStudyWithoutPhasesButWithScheduledMasterFile => "CMB",
                CodeMasterFileIdentifierCode.LocationMasterFile => "LOC",
                CodeMasterFileIdentifierCode.NumericalObservationMasterFile => "OMA",
                CodeMasterFileIdentifierCode.CategoricalObservationMasterFile => "OMB",
                CodeMasterFileIdentifierCode.ObservationBatteriesMasterFile => "OMC",
                CodeMasterFileIdentifierCode.CalculatedObservationsMasterFile => "OMD",
                CodeMasterFileIdentifierCode.PractitionerMasterFile => "PRA",
                CodeMasterFileIdentifierCode.StaffMasterFile => "STF",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeMasterFileIdentifierCode input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeMessageErrorConditionCodes enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeMessageErrorConditionCodes input)
        {
            return input switch
            {
                CodeMessageErrorConditionCodes.MessageAccepted => "0",
                CodeMessageErrorConditionCodes.SegmentSequenceError => "100",
                CodeMessageErrorConditionCodes.RequiredFieldMissing => "101",
                CodeMessageErrorConditionCodes.DataTypeError => "102",
                CodeMessageErrorConditionCodes.TableValueNotFound => "103",
                CodeMessageErrorConditionCodes.UnsupportedMessageType => "200",
                CodeMessageErrorConditionCodes.UnsupportedEventCode => "201",
                CodeMessageErrorConditionCodes.UnsupportedProcessingId => "202",
                CodeMessageErrorConditionCodes.UnsupportedVersionId => "203",
                CodeMessageErrorConditionCodes.UnknownKeyIdentifier => "204",
                CodeMessageErrorConditionCodes.DuplicateKeyIdentifier => "205",
                CodeMessageErrorConditionCodes.ApplicationRecordLocked => "206",
                CodeMessageErrorConditionCodes.ApplicationError => "207",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeMessageErrorConditionCodes input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeMessageStructure enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeMessageStructure input)
        {
            return input switch
            {
                CodeMessageStructure.Varies => "ACK",
                CodeMessageStructure.AdrA19Deprecated => "ADR_A19",
                CodeMessageStructure.A01A04A08A13 => "ADT_A01",
                CodeMessageStructure.A02 => "ADT_A02",
                CodeMessageStructure.A03 => "ADT_A03",
                CodeMessageStructure.A06A07 => "ADT_A06",
                CodeMessageStructure.A09A10A11 => "ADT_A09",
                CodeMessageStructure.A12 => "ADT_A12",
                CodeMessageStructure.A16 => "ADT_A16",
                CodeMessageStructure.A17 => "ADT_A17",
                CodeMessageStructure.AdtA18Deprecated => "ADT_A18",
                CodeMessageStructure.A20 => "ADT_A20",
                CodeMessageStructure.A24 => "ADT_A24",
                CodeMessageStructure.A28A31Deprecated => "ADT_A28",
                CodeMessageStructure.AdtA30Deprecated => "ADT_A30",
                CodeMessageStructure.A37 => "ADT_A37",
                CodeMessageStructure.A38 => "ADT_A38",
                CodeMessageStructure.A39A40A41A42 => "ADT_A39",
                CodeMessageStructure.A43 => "ADT_A43",
                CodeMessageStructure.A45 => "ADT_A45",
                CodeMessageStructure.A50A51 => "ADT_A50",
                CodeMessageStructure.A19ARDDeprecated => "ARD_A19",
                CodeMessageStructure.P01 => "BAR_P01",
                CodeMessageStructure.P02 => "BAR_P02",
                CodeMessageStructure.P06 => "BAR_P06",
                CodeMessageStructure.C01C02C03C04C05C06C07C08 => "CRM_C01",
                CodeMessageStructure.C09C10C11C12 => "CSU_C09",
                CodeMessageStructure.P03 => "DFT_P03",
                CodeMessageStructure.DocT12Deprecated => "DOC_T12",
                CodeMessageStructure.Q01Deprecated => "DSR_Q01",
                CodeMessageStructure.Q03Deprecated => "DSR_Q03",
                CodeMessageStructure.R07Deprecated => "EDR_R07",
                CodeMessageStructure.Q04Deprecated => "EQQ_Q04",
                CodeMessageStructure.R09ERPDeprecated => "ERP_R09",
                CodeMessageStructure.T01T03T05T07T09T11 => "MDM_T01",
                CodeMessageStructure.T02T04T06T08T10 => "MDM_T02",
                CodeMessageStructure.P09MFDDeprecated => "MFD_P09",
                CodeMessageStructure.M01M02M03M04M05M06M07M08M09M10M11 => "MFK_M01",
                CodeMessageStructure.MfnM01Deprecated => "MFN_M01",
                CodeMessageStructure.M02 => "MFN_M02",
                CodeMessageStructure.M03Deprecated => "MFN_M03",
                CodeMessageStructure.M05 => "MFN_M05",
                CodeMessageStructure.M06 => "MFN_M06",
                CodeMessageStructure.M07 => "MFN_M07",
                CodeMessageStructure.M08 => "MFN_M08",
                CodeMessageStructure.M09 => "MFN_M09",
                CodeMessageStructure.M10 => "MFN_M10",
                CodeMessageStructure.M11 => "MFN_M11",
                CodeMessageStructure.OmdO01Deprecated => "OMD_O01",
                CodeMessageStructure.OmnO01Deprecated => "OMN_O01",
                CodeMessageStructure.OmsO01Deprecated => "OMS_O01",
                CodeMessageStructure.OrdO02Deprecated => "ORD_O02",
                CodeMessageStructure.R02R04Deprecated => "ORF_R02",
                CodeMessageStructure.O01ORMDeprecated => "ORM_O01",
                CodeMessageStructure.Q06ORMDeprecated => "ORM_Q06",
                CodeMessageStructure.OrnO02Deprecated => "ORN_O02",
                CodeMessageStructure.O02ORRDeprecated => "ORR_O02",
                CodeMessageStructure.Q06ORRDeprecated => "ORR_Q06",
                CodeMessageStructure.OrsO02Deprecated => "ORS_O02",
                CodeMessageStructure.R01 => "ORU_R01",
                CodeMessageStructure.W01Deprecated => "ORU_W01",
                CodeMessageStructure.Q06OSQDeprecated => "OSQ_Q06",
                CodeMessageStructure.Q06OSRDeprecated => "OSR_Q06",
                CodeMessageStructure.P07P08 => "PEX_P07",
                CodeMessageStructure.Pc6Pc7Pc8 => "PGL_PC6",
                CodeMessageStructure.I07Deprecated => "PIN_I07",
                CodeMessageStructure.PccPcgPchPcj => "PPG_PCG",
                CodeMessageStructure.PcbPcd => "PPP_PCB",
                CodeMessageStructure.Pc1Pc2Pc3 => "PPR_PC1",
                CodeMessageStructure.PclDeprecated => "PPT_PCL",
                CodeMessageStructure.PcaDeprecated => "PPV_PCA",
                CodeMessageStructure.Pc5Deprecated => "PRR_PC5",
                CodeMessageStructure.PcfDeprecated => "PTR_PCF",
                CodeMessageStructure.Q02QCKDeprecated => "QCK_Q02",
                CodeMessageStructure.A19QRYDeprecated => "QRY_A19",
                CodeMessageStructure.Pc4Pc9PcePckDeprecated => "QRY_PC4",
                CodeMessageStructure.Q01Q26Q27Q28Q29Q30Deprecated => "QRY_Q01",
                CodeMessageStructure.Q02QRYDeprecated => "QRY_Q02",
                CodeMessageStructure.R02Deprecated => "QRY_R02",
                CodeMessageStructure.T12Deprecated => "QRY_T12",
                CodeMessageStructure.RarDeprecated => "RAR_RAR",
                CodeMessageStructure.O01RASDeprecated => "RAS_O01",
                CodeMessageStructure.O022Deprecated => "RAS_O02",
                CodeMessageStructure.I05Deprecated => "RCI_I05",
                CodeMessageStructure.I06RCLDeprecated => "RCL_I06",
                CodeMessageStructure.O01RDEDeprecated => "RDE_O01",
                CodeMessageStructure.RdoO01Deprecated => "RDO_O01",
                CodeMessageStructure.Rdr => "RDR_RDR",
                CodeMessageStructure.O01RDSDeprecated => "RDS_O01",
                CodeMessageStructure.I12I13I14I15REF => "REF_I12",
                CodeMessageStructure.RerDeprecated => "RER_RER",
                CodeMessageStructure.RgrDeprecated => "RGR_RGR",
                CodeMessageStructure.O01RGVDeprecated => "RGV_O01",
                CodeMessageStructure.RorDeprecated => "ROR_ROR",
                CodeMessageStructure.I08I09I10I11RPA => "RPA_I08",
                CodeMessageStructure.I01I04Deprecated => "RPI_I0I",
                CodeMessageStructure.I02 => "RPL_I02",
                CodeMessageStructure.I03 => "RPR_I03",
                CodeMessageStructure.I08I09I10I11RQA => "RQA_I08",
                CodeMessageStructure.I05I06Deprecated => "RQC_I05",
                CodeMessageStructure.I06RQCDeprecated => "RQC_I06",
                CodeMessageStructure.I01I02I03Deprecated => "RQI_I0I",
                CodeMessageStructure.I04RQP => "RQP_I04",
                CodeMessageStructure.Q09Deprecated => "RQQ_Q09",
                CodeMessageStructure.O02RRADeprecated => "RRA_O02",
                CodeMessageStructure.O02RRDDeprecated => "RRD_O02",
                CodeMessageStructure.O02RREDeprecated => "RRE_O02",
                CodeMessageStructure.O02RRGDeprecated => "RRG_O02",
                CodeMessageStructure.I12I13I14I15RRI => "RRI_I12",
                CodeMessageStructure.RroO02Deprecated => "RRO_O02",
                CodeMessageStructure.S12S13S14S15S16S17S18S19S20S21S22S23S24S26 => "SIU_S12",
                CodeMessageStructure.Q08Deprecated => "SPQ_Q08",
                CodeMessageStructure.S25SQMDeprecated => "SQM_S25",
                CodeMessageStructure.S25SQRDeprecated => "SQR_S25",
                CodeMessageStructure.S01S02S03S04S05S06S07S08S09S10S11SRM => "SRM_S01",
                CodeMessageStructure.T12SRMDeprecated => "SRM_T12",
                CodeMessageStructure.S01S02S03S04S05S06S07S08S09S10S11SRR => "SRR_S01",
                CodeMessageStructure.T12SRRDeprecated => "SRR_T12",
                CodeMessageStructure.P09SURDeprecated => "SUR_P09",
                CodeMessageStructure.R09TBRDeprecated => "TBR_R09",
                CodeMessageStructure.Q05 => "UDM_Q05",
                CodeMessageStructure.Q07Deprecated => "VQQ_Q07",
                CodeMessageStructure.V01Deprecated => "VXQ_V01",
                CodeMessageStructure.V03Deprecated => "VXR_V03",
                CodeMessageStructure.V04 => "VXU_V04",
                CodeMessageStructure.V02Deprecated => "VXX_V02",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeMessageStructure input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeMessageType enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeMessageType input)
        {
            return input switch
            {
                CodeMessageType.GeneralAcknowledgment => "ACK",
                CodeMessageType.AdtResponseDeprecated => "ADR",
                CodeMessageType.AdtMessage => "ADT",
                CodeMessageType.AncillaryRptDeprecated => "ARD",
                CodeMessageType.AddChangeBillingAccount => "BAR",
                CodeMessageType.ClinicalStudyRegistration => "CRM",
                CodeMessageType.UnsolicitedStudyData => "CSU",
                CodeMessageType.DetailFinancialTransactions => "DFT",
                CodeMessageType.DocumentResponseDeprecated => "DOC",
                CodeMessageType.DisplayResponseDeprecated => "DSR",
                CodeMessageType.EnhancedDisplayResponseDeprecated => "EDR",
                CodeMessageType.EmbeddedQueryLanguageQueryDeprecated => "EQQ",
                CodeMessageType.EventReplayResponseDeprecated => "ERP",
                CodeMessageType.DelayedAcknowledgmentDeprecated => "MCF",
                CodeMessageType.MedicalDocumentManagement => "MDM",
                CodeMessageType.MasterFilesDelayedApplicationAcknowledgmentDeprecated => "MFD",
                CodeMessageType.MasterFilesApplicationAcknowledgment => "MFK",
                CodeMessageType.MasterFilesNotification => "MFN",
                CodeMessageType.MasterFilesQueryDeprecated => "MFQ",
                CodeMessageType.MasterFilesResponseDeprecated => "MFR",
                CodeMessageType.ApplicationManagementData => "NMD",
                CodeMessageType.ApplicationManagementQueryDeprecated => "NMQ",
                CodeMessageType.ApplicationManagementResponseDeprecated => "NMR",
                CodeMessageType.QueryForResultsOfObservationDeprecated => "ORF",
                CodeMessageType.PharmacyTreatmentOrderDeprecated => "ORM",
                CodeMessageType.GeneralOrderResponseToAnyOrmDeprecated => "ORR",
                CodeMessageType.UnsolicitedTransmissionOfObservation => "ORU",
                CodeMessageType.QueryResponseForOrderStatusOsqDeprecated => "OSQ",
                CodeMessageType.QueryResponseForOrderStatusOsrDeprecated => "OSR",
                CodeMessageType.ProductExperience => "PEX",
                CodeMessageType.PatientGoalMessage => "PGL",
                CodeMessageType.PatientInsuranceInformation => "PIN",
                CodeMessageType.PatientPathwayGoalOriented => "PPG",
                CodeMessageType.PatientPathwayProblemOriented => "PPP",
                CodeMessageType.PatientProblem => "PPR",
                CodeMessageType.PatientPathwayGoalOrientedResponseDeprecated => "PPT",
                CodeMessageType.PatientGoalResponseDeprecated => "PPV",
                CodeMessageType.PatientProblemResponseDeprecated => "PRR",
                CodeMessageType.PatientPathwayProblemOrientedResponseDeprecated => "PTR",
                CodeMessageType.QueryGeneralAcknowledgmentDeprecated => "QCK",
                CodeMessageType.QueryOriginalMode => "QRY",
                CodeMessageType.PharmacyTreatmentAdministrationInfoDeprecated => "RAR",
                CodeMessageType.PharmacyTreatmentAdministration => "RAS",
                CodeMessageType.ReturnClinicalInformation => "RCI",
                CodeMessageType.ReturnClinicalList => "RCL",
                CodeMessageType.PharmacyTreatmentEncodedOrder => "RDE",
                CodeMessageType.PharmacyTreatmentDispenseInfo => "RDR",
                CodeMessageType.PharmacyTreatmentDispense => "RDS",
                CodeMessageType.PatientReferral => "REF",
                CodeMessageType.PharmacyTreatmentEncodedOrderInformationDeprecated => "RER",
                CodeMessageType.PharmacyTreatmentDoseInformationDeprecated => "RGR",
                CodeMessageType.PharmacyTreatmentGive => "RGV",
                CodeMessageType.PharmacyTreatmentOrderResponseDeprecated => "ROR",
                CodeMessageType.ReturnPatientAuthorization => "RPA",
                CodeMessageType.ReturnPatientInfo => "RPI",
                CodeMessageType.ReturnPatientDisplayList => "RPL",
                CodeMessageType.ReturnPatientList => "RPR",
                CodeMessageType.RequestPatientAuthorization => "RQA",
                CodeMessageType.RequestClinicalInformation => "RQC",
                CodeMessageType.RequestPatientInformation => "RQI",
                CodeMessageType.RequestPatientDemographics => "RQP",
                CodeMessageType.EventReplayQueryDeprecated => "RQQ",
                CodeMessageType.PharmacyTreatmentAdministrationAcknowledgment => "RRA",
                CodeMessageType.PharmacyTreatmentDispenseAcknowledgment => "RRD",
                CodeMessageType.PharmacyTreatmentEncodedOrderAcknowledgment => "RRE",
                CodeMessageType.PharmacyTreatmentGiveAcknowledgment => "RRG",
                CodeMessageType.ReturnReferralInfo => "RRI",
                CodeMessageType.ScheduleInfoUnsolicited => "SIU",
                CodeMessageType.StoredProcedureRequestDeprecated => "SPQ",
                CodeMessageType.ScheduleQueryMessageDeprecated => "SQM",
                CodeMessageType.ScheduleQueryResponseDeprecated => "SQR",
                CodeMessageType.ScheduleRequestMessage => "SRM",
                CodeMessageType.ScheduledRequestResponse => "SRR",
                CodeMessageType.SummaryProductExperienceReportDeprecated => "SUR",
                CodeMessageType.TabularDataResponseDeprecated => "TBR",
                CodeMessageType.UnsolicitedDisplayUpdateMessage => "UDM",
                CodeMessageType.VirtualTableQueryDeprecated => "VQQ",
                CodeMessageType.QueryForVaccinationRecordDeprecated => "VXQ",
                CodeMessageType.VaccinationRecordResponseDeprecated => "VXR",
                CodeMessageType.UnsolicitedVaccinationRecordUpdate => "VXU",
                CodeMessageType.ResponseForVaccinationQueryWithMultiplePidMatchesDeprecated => "VXX",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeMessageType input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeMfnRecordLevelErrorReturn enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeMfnRecordLevelErrorReturn input)
        {
            return input switch
            {
                CodeMfnRecordLevelErrorReturn.SuccessfulPostingOfTheRecord => "S",
                CodeMfnRecordLevelErrorReturn.UnsuccessfulPostingOfTheRecord => "U",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeMfnRecordLevelErrorReturn input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeMilitaryRankGrade enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeMilitaryRankGrade input)
        {
            return input switch
            {
                CodeMilitaryRankGrade.Enlisted1 => "E1",
                CodeMilitaryRankGrade.Enlisted1To9 => "E1 ... E9",
                CodeMilitaryRankGrade.Enlisted2 => "E2",
                CodeMilitaryRankGrade.Enlisted3 => "E3",
                CodeMilitaryRankGrade.Enlisted4 => "E4",
                CodeMilitaryRankGrade.Enlisted5 => "E5",
                CodeMilitaryRankGrade.Enlisted6 => "E6",
                CodeMilitaryRankGrade.Enlisted7 => "E7",
                CodeMilitaryRankGrade.Enlisted8 => "E8",
                CodeMilitaryRankGrade.Enlisted9 => "E9",
                CodeMilitaryRankGrade.Officers1 => "O1",
                CodeMilitaryRankGrade.Officers => "O1 ... O10",
                CodeMilitaryRankGrade.Officers10 => "O10",
                CodeMilitaryRankGrade.Officers2 => "O2",
                CodeMilitaryRankGrade.Officers3 => "O3",
                CodeMilitaryRankGrade.Officers4 => "O4",
                CodeMilitaryRankGrade.Officers5 => "O5",
                CodeMilitaryRankGrade.Officers6 => "O6",
                CodeMilitaryRankGrade.Officers7 => "O7",
                CodeMilitaryRankGrade.Officers8 => "O8",
                CodeMilitaryRankGrade.Officers9 => "O9",
                CodeMilitaryRankGrade.WarrantOfficers1 => "W1",
                CodeMilitaryRankGrade.WarrantOfficers => "W1 ... W4",
                CodeMilitaryRankGrade.WarrantOfficers2 => "W2",
                CodeMilitaryRankGrade.WarrantOfficers3 => "W3",
                CodeMilitaryRankGrade.WarrantOfficers4 => "W4",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeMilitaryRankGrade input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeMilitaryService enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeMilitaryService input)
        {
            return input switch
            {
                CodeMilitaryService.Nato => "NATO",
                CodeMilitaryService.Noaa => "NOAA",
                CodeMilitaryService.UsArmy => "USA",
                CodeMilitaryService.UsAirForce => "USAF",
                CodeMilitaryService.UsCoastGuard => "USCG",
                CodeMilitaryService.UsMarineCorps => "USMC",
                CodeMilitaryService.UsNavy => "USN",
                CodeMilitaryService.UsPublicHealthService => "USPHS",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeMilitaryService input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeMilitaryStatus enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeMilitaryStatus input)
        {
            return input switch
            {
                CodeMilitaryStatus.ActiveDuty => "ACT",
                CodeMilitaryStatus.Deceased => "DEC",
                CodeMilitaryStatus.Retired => "RET",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeMilitaryStatus input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeMimeBase64EncodingCharacters enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeMimeBase64EncodingCharacters input)
        {
            return input switch
            {
                CodeMimeBase64EncodingCharacters.EqualsSign => "(pad)",
                CodeMimeBase64EncodingCharacters.A => "0",
                CodeMimeBase64EncodingCharacters.B => "1",
                CodeMimeBase64EncodingCharacters.K => "10",
                CodeMimeBase64EncodingCharacters.L => "11",
                CodeMimeBase64EncodingCharacters.M => "12",
                CodeMimeBase64EncodingCharacters.N => "13",
                CodeMimeBase64EncodingCharacters.O => "14",
                CodeMimeBase64EncodingCharacters.P => "15",
                CodeMimeBase64EncodingCharacters.Q => "16",
                CodeMimeBase64EncodingCharacters.R => "17",
                CodeMimeBase64EncodingCharacters.S => "18",
                CodeMimeBase64EncodingCharacters.T => "19",
                CodeMimeBase64EncodingCharacters.C => "2",
                CodeMimeBase64EncodingCharacters.U => "20",
                CodeMimeBase64EncodingCharacters.V => "21",
                CodeMimeBase64EncodingCharacters.W => "22",
                CodeMimeBase64EncodingCharacters.X => "23",
                CodeMimeBase64EncodingCharacters.Y => "24",
                CodeMimeBase64EncodingCharacters.Z => "25",
                CodeMimeBase64EncodingCharacters.a => "26",
                CodeMimeBase64EncodingCharacters.b => "27",
                CodeMimeBase64EncodingCharacters.c => "28",
                CodeMimeBase64EncodingCharacters.d => "29",
                CodeMimeBase64EncodingCharacters.D => "3",
                CodeMimeBase64EncodingCharacters.e => "30",
                CodeMimeBase64EncodingCharacters.f => "31",
                CodeMimeBase64EncodingCharacters.g => "32",
                CodeMimeBase64EncodingCharacters.h => "33",
                CodeMimeBase64EncodingCharacters.i => "34",
                CodeMimeBase64EncodingCharacters.j => "35",
                CodeMimeBase64EncodingCharacters.k => "36",
                CodeMimeBase64EncodingCharacters.l => "37",
                CodeMimeBase64EncodingCharacters.m => "38",
                CodeMimeBase64EncodingCharacters.n => "39",
                CodeMimeBase64EncodingCharacters.E => "4",
                CodeMimeBase64EncodingCharacters.o => "40",
                CodeMimeBase64EncodingCharacters.p => "41",
                CodeMimeBase64EncodingCharacters.q => "42",
                CodeMimeBase64EncodingCharacters.r => "43",
                CodeMimeBase64EncodingCharacters.s => "44",
                CodeMimeBase64EncodingCharacters.t => "45",
                CodeMimeBase64EncodingCharacters.u => "46",
                CodeMimeBase64EncodingCharacters.v => "47",
                CodeMimeBase64EncodingCharacters.w => "48",
                CodeMimeBase64EncodingCharacters.x => "49",
                CodeMimeBase64EncodingCharacters.F => "5",
                CodeMimeBase64EncodingCharacters.y => "50",
                CodeMimeBase64EncodingCharacters.z => "51",
                CodeMimeBase64EncodingCharacters.Number0 => "52",
                CodeMimeBase64EncodingCharacters.Number1 => "53",
                CodeMimeBase64EncodingCharacters.Number2 => "54",
                CodeMimeBase64EncodingCharacters.Number3 => "55",
                CodeMimeBase64EncodingCharacters.Number4 => "56",
                CodeMimeBase64EncodingCharacters.Number5 => "57",
                CodeMimeBase64EncodingCharacters.Number6 => "58",
                CodeMimeBase64EncodingCharacters.Number7 => "59",
                CodeMimeBase64EncodingCharacters.G => "6",
                CodeMimeBase64EncodingCharacters.Number8 => "60",
                CodeMimeBase64EncodingCharacters.Number9 => "61",
                CodeMimeBase64EncodingCharacters.PlusSign => "62",
                CodeMimeBase64EncodingCharacters.ForwardSlash => "63",
                CodeMimeBase64EncodingCharacters.H => "7",
                CodeMimeBase64EncodingCharacters.I => "8",
                CodeMimeBase64EncodingCharacters.J => "9",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeMimeBase64EncodingCharacters input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeModality enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeModality input)
        {
            return input switch
            {
                CodeModality.Angioscopy => "AS",
                CodeModality.BiomagneticImaging => "BS",
                CodeModality.ColorFlowDoppler => "CD",
                CodeModality.Colposcopy => "CP",
                CodeModality.ComputedRadiography => "CR",
                CodeModality.Cystoscopy => "CS",
                CodeModality.ComputedTomography => "CT",
                CodeModality.DuplexDoppler => "DD",
                CodeModality.Diapanography => "DG",
                CodeModality.DigitalMicroscopy => "DM",
                CodeModality.Echocardiography => "EC",
                CodeModality.Endoscopy => "ES",
                CodeModality.FluoresceinAngiography => "FA",
                CodeModality.Fundoscopy => "FS",
                CodeModality.Laparoscopy => "LP",
                CodeModality.LaserSurfaceScan => "LS",
                CodeModality.MagneticResonanceAngiography => "MA",
                CodeModality.MagneticResonanceSpectroscopy => "MS",
                CodeModality.NuclearMedicine => "NM",
                CodeModality.Other => "OT",
                CodeModality.PositronEmissionTomography => "PT",
                CodeModality.RadioFluoroscopy => "RF",
                CodeModality.SinglePhotonEmissionComputedTomography => "ST",
                CodeModality.Thermography => "TG",
                CodeModality.Ultrasound => "US",
                CodeModality.XRayAngiography => "XA",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeModality input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeMoneyOrPercentageIndicator enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeMoneyOrPercentageIndicator input)
        {
            return input switch
            {
                CodeMoneyOrPercentageIndicator.CurrencyAmount => "AT",
                CodeMoneyOrPercentageIndicator.Percentage => "PC",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeMoneyOrPercentageIndicator input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeNameAddressRepresentation enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeNameAddressRepresentation input)
        {
            return input switch
            {
                CodeNameAddressRepresentation.Alphabetic => "A",
                CodeNameAddressRepresentation.Ideographic => "I",
                CodeNameAddressRepresentation.Phonetic => "P",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeNameAddressRepresentation input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeNameType enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeNameType input)
        {
            return input switch
            {
                CodeNameType.Assigned => "A",
                CodeNameType.BirthName => "B",
                CodeNameType.AdoptedName => "C",
                CodeNameType.CustomaryName => "D",
                CodeNameType.OfficialRegistryName => "L",
                CodeNameType.MaidenName => "M",
                CodeNameType.NameOfPartnerSpouse => "P",
                CodeNameType.Pseudonym => "S",
                CodeNameType.IndigenousTribal => "T",
                CodeNameType.Unknown => "U",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeNameType input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeNatureOfAbnormalTesting enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeNatureOfAbnormalTesting input)
        {
            return input switch
            {
                CodeNatureOfAbnormalTesting.AgeBasedPopulation => "A",
                CodeNatureOfAbnormalTesting.None => "N",
                CodeNatureOfAbnormalTesting.RaceBasedPopulation => "R",
                CodeNatureOfAbnormalTesting.SexBasedPopulation => "S",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeNatureOfAbnormalTesting input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeNatureOfChallenge enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeNatureOfChallenge input)
        {
            return input switch
            {
                CodeNatureOfChallenge.FastingForPeriodSpecified => "CFST",
                CodeNatureOfChallenge.ExerciseCanBeQuantified => "EXCZ",
                CodeNatureOfChallenge.NoFluidIntakeForPeriodSpecified => "FFST",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeNatureOfChallenge input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeNatureOfServiceTestObservation enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeNatureOfServiceTestObservation input)
        {
            return input switch
            {
                CodeNatureOfServiceTestObservation.AtomicServiceTestObservation => "A",
                CodeNatureOfServiceTestObservation.SingleObservation => "C",
                CodeNatureOfServiceTestObservation.FunctionalProcedure => "F",
                CodeNatureOfServiceTestObservation.ProfileFromAtomicObservation => "P",
                CodeNatureOfServiceTestObservation.Superset => "S",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeNatureOfServiceTestObservation input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeObservationResultStatusCodesInterpretation enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeObservationResultStatusCodesInterpretation input)
        {
            return input switch
            {
                CodeObservationResultStatusCodesInterpretation.RecordIsCorrection => "C",
                CodeObservationResultStatusCodesInterpretation.DeletesTheObxRecord => "D",
                CodeObservationResultStatusCodesInterpretation.FinalResults => "F",
                CodeObservationResultStatusCodesInterpretation.SpecimenInLabResultsPending => "I",
                CodeObservationResultStatusCodesInterpretation.NotAsked => "N",
                CodeObservationResultStatusCodesInterpretation.OrderDetailDescription => "O",
                CodeObservationResultStatusCodesInterpretation.PreliminaryResults => "P",
                CodeObservationResultStatusCodesInterpretation.ResultsEnteredNotVerified => "R",
                CodeObservationResultStatusCodesInterpretation.PartialResults => "S",
                CodeObservationResultStatusCodesInterpretation.ResultsChangeToFinalWithoutRetransmit => "U",
                CodeObservationResultStatusCodesInterpretation.PostOriginalAsWrongEGTransmittedForWrongPatient => "W",
                CodeObservationResultStatusCodesInterpretation.ResultsCannotBeObtainedForThisObservation => "X",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeObservationResultStatusCodesInterpretation input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeOccurrenceCode enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeOccurrenceCode input)
        {
            return input switch
            {
                CodeOccurrenceCode.AutoAccident => "01",
                CodeOccurrenceCode.NoFaultInsuranceInvolved => "02",
                CodeOccurrenceCode.AccidentTortLiability => "03",
                CodeOccurrenceCode.AccidentEmploymentRelated => "04",
                CodeOccurrenceCode.OtherAccident => "05",
                CodeOccurrenceCode.CrimeVictim => "06",
                CodeOccurrenceCode.StartOfInfertilityTreatment => "09",
                CodeOccurrenceCode.LastMenstrualPeriod => "10",
                CodeOccurrenceCode.OnsetOfSymptomsIllness => "11",
                CodeOccurrenceCode.DateOfOnsetForChronicallyDependent => "12",
                CodeOccurrenceCode.DateOutpatientOccupationalTherapyPlanEstablishedOrReviewed => "17",
                CodeOccurrenceCode.DateOfRetirementPatientBeneficiary => "18",
                CodeOccurrenceCode.DateOfRetirementSpouse => "19",
                CodeOccurrenceCode.GuaranteeOfPaymentBegan => "20",
                CodeOccurrenceCode.UrNoticeReceived => "21",
                CodeOccurrenceCode.DateActiveCareEnded => "22",
                CodeOccurrenceCode.DateInsuranceDenied => "24",
                CodeOccurrenceCode.DateBenefitsTerminatedByPrimaryPayor => "25",
                CodeOccurrenceCode.DateSnfBedAvailable => "26",
                CodeOccurrenceCode.DateHomeHealthPlanEstablished => "27",
                CodeOccurrenceCode.SpousesDateOfBirth => "28",
                CodeOccurrenceCode.DateOutpatientPhysicalTherapyPlanEstablishedOrReviewed => "29",
                CodeOccurrenceCode.DateOutpatientSpeechPathologyPlanEstablishedOrReviewed => "30",
                CodeOccurrenceCode.DateBeneficiaryNotifiedOfIntentToBillAccommodations => "31",
                CodeOccurrenceCode.DateBeneficiaryNotifiedOfIntentToBillTreatments => "32",
                CodeOccurrenceCode.FirstDayOfMedicareCoordinationPeriodForEsrdBeneficiariesCoveredByEghp => "33",
                CodeOccurrenceCode.DateOfElectionOfExtendedCareFacilities => "34",
                CodeOccurrenceCode.DateTreatmentStartedForPT => "35",
                CodeOccurrenceCode.DateOfInpatientDischargeForCoveredTransplantPatients => "36",
                CodeOccurrenceCode.DateOfInpatientDischargeForNonCoveredTransplantPatient => "37",
                CodeOccurrenceCode.ScheduledDateOfAdmission => "40",
                CodeOccurrenceCode.DateOfFirstTestForPreAdmissionTesting => "41",
                CodeOccurrenceCode.DateOfDischarge => "42",
                CodeOccurrenceCode.ScheduledDateOfCanceledSurgery => "43",
                CodeOccurrenceCode.DateTreatmentStartedForOT => "44",
                CodeOccurrenceCode.DateTreatmentStartedForST => "45",
                CodeOccurrenceCode.DateTreatmentStartedForCardiacRehab => "46",
                CodeOccurrenceCode.PayerCodes47 => "47",
                CodeOccurrenceCode.PayerCodes47To49 => "47 ... 49",
                CodeOccurrenceCode.PayerCodes48 => "48",
                CodeOccurrenceCode.PayerCodes49 => "49",
                CodeOccurrenceCode.DateLienReleased => "50",
                CodeOccurrenceCode.DateTreatmentStartedForPsychiatricCare => "51",
                CodeOccurrenceCode.OccurrenceSpanCodesAndDates => "70",
                CodeOccurrenceCode.OccurrenceSpanCodesAndDates70To99 => "70 ... 99",
                CodeOccurrenceCode.OccurrenceSpanCodesAndDates71 => "71",
                CodeOccurrenceCode.OccurrenceSpanCodesAndDates72 => "72",
                CodeOccurrenceCode.OccurrenceSpanCodesAndDates73 => "73",
                CodeOccurrenceCode.OccurrenceSpanCodesAndDates74 => "74",
                CodeOccurrenceCode.OccurrenceSpanCodesAndDates75 => "75",
                CodeOccurrenceCode.OccurrenceSpanCodesAndDates76 => "76",
                CodeOccurrenceCode.OccurrenceSpanCodesAndDates77 => "77",
                CodeOccurrenceCode.OccurrenceSpanCodesAndDates78 => "78",
                CodeOccurrenceCode.OccurrenceSpanCodesAndDates79 => "79",
                CodeOccurrenceCode.OccurrenceSpanCodesAndDates80 => "80",
                CodeOccurrenceCode.OccurrenceSpanCodesAndDates81 => "81",
                CodeOccurrenceCode.OccurrenceSpanCodesAndDates82 => "82",
                CodeOccurrenceCode.OccurrenceSpanCodesAndDates83 => "83",
                CodeOccurrenceCode.OccurrenceSpanCodesAndDates84 => "84",
                CodeOccurrenceCode.OccurrenceSpanCodesAndDates85 => "85",
                CodeOccurrenceCode.OccurrenceSpanCodesAndDates86 => "86",
                CodeOccurrenceCode.OccurrenceSpanCodesAndDates87 => "87",
                CodeOccurrenceCode.OccurrenceSpanCodesAndDates88 => "88",
                CodeOccurrenceCode.OccurrenceSpanCodesAndDates89 => "89",
                CodeOccurrenceCode.OccurrenceSpanCodesAndDates90 => "90",
                CodeOccurrenceCode.OccurrenceSpanCodesAndDates91 => "91",
                CodeOccurrenceCode.OccurrenceSpanCodesAndDates92 => "92",
                CodeOccurrenceCode.OccurrenceSpanCodesAndDates93 => "93",
                CodeOccurrenceCode.OccurrenceSpanCodesAndDates94 => "94",
                CodeOccurrenceCode.OccurrenceSpanCodesAndDates95 => "95",
                CodeOccurrenceCode.OccurrenceSpanCodesAndDates96 => "96",
                CodeOccurrenceCode.OccurrenceSpanCodesAndDates97 => "97",
                CodeOccurrenceCode.OccurrenceSpanCodesAndDates98 => "98",
                CodeOccurrenceCode.OccurrenceSpanCodesAndDates99 => "99",
                CodeOccurrenceCode.BirthdateInsuredA => "A1",
                CodeOccurrenceCode.EffectiveDateInsuredAPolicy => "A2",
                CodeOccurrenceCode.BenefitsExhaustedPayerA => "A3",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeOccurrenceCode input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeOccurrenceSpan enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeOccurrenceSpan input)
        {
            return input switch
            {
                CodeOccurrenceSpan.QualifyingStayDatesForSnf => "70",
                CodeOccurrenceSpan.PriorStayDates => "71",
                CodeOccurrenceSpan.FirstLastVisit => "72",
                CodeOccurrenceSpan.BenefitEligibilityPeriod => "73",
                CodeOccurrenceSpan.NonCoveredLevelOfCare => "74",
                CodeOccurrenceSpan.SnfLevelOfCare => "75",
                CodeOccurrenceSpan.PatientLiability => "76",
                CodeOccurrenceSpan.ProviderLiabilityPeriod => "77",
                CodeOccurrenceSpan.SnfPriorStayDates => "78",
                CodeOccurrenceSpan.PayerCode => "79",
                CodeOccurrenceSpan.PsroUrApprovedStayDates => "M0",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeOccurrenceSpan input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeOrderControlCodes enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeOrderControlCodes input)
        {
            return input switch
            {
                CodeOrderControlCodes.OrderServiceRefillRequestApproval => "AF",
                CodeOrderControlCodes.CancelOrderServiceRequest => "CA",
                CodeOrderControlCodes.ChildOrderService => "CH",
                CodeOrderControlCodes.CombinedResult => "CN",
                CodeOrderControlCodes.CanceledAsRequested => "CR",
                CodeOrderControlCodes.DiscontinueOrderServiceRequest => "DC",
                CodeOrderControlCodes.DataErrors => "DE",
                CodeOrderControlCodes.OrderServiceRefillRequestDenied => "DF",
                CodeOrderControlCodes.DiscontinuedAsRequested => "DR",
                CodeOrderControlCodes.OrderServiceRefilledUnsolicited => "FU",
                CodeOrderControlCodes.HoldOrderRequest => "HD",
                CodeOrderControlCodes.OnHoldAsRequested => "HR",
                CodeOrderControlCodes.LinkOrderToPatientCareProblemOrGoal => "LI",
                CodeOrderControlCodes.NumberAssigned => "NA",
                CodeOrderControlCodes.NewOrderService => "NW",
                CodeOrderControlCodes.OrderServiceCanceled => "OC",
                CodeOrderControlCodes.OrderServiceDiscontinued => "OD",
                CodeOrderControlCodes.OrderServiceReleased => "OE",
                CodeOrderControlCodes.OrderServiceRefilledAsRequested => "OF",
                CodeOrderControlCodes.OrderServiceHeld => "OH",
                CodeOrderControlCodes.OrderServiceAcceptedOk => "OK",
                CodeOrderControlCodes.ReleasedAsRequested => "OR",
                CodeOrderControlCodes.ParentOrderService => "PA",
                CodeOrderControlCodes.ObservationsPerformedServiceToFollow => "RE",
                CodeOrderControlCodes.RefillOrderServiceRequest => "RF",
                CodeOrderControlCodes.ReleasePreviousHold => "RL",
                CodeOrderControlCodes.ReplacementOrder => "RO",
                CodeOrderControlCodes.OrderServiceReplaceRequest => "RP",
                CodeOrderControlCodes.ReplacedAsRequested => "RQ",
                CodeOrderControlCodes.RequestReceived => "RR",
                CodeOrderControlCodes.ReplacedUnsolicited => "RU",
                CodeOrderControlCodes.StatusChanged => "SC",
                CodeOrderControlCodes.SendOrderServiceNumber => "SN",
                CodeOrderControlCodes.ResponseToSendOrderServiceStatusRequest => "SR",
                CodeOrderControlCodes.SendOrderServiceStatusRequest => "SS",
                CodeOrderControlCodes.UnableToAcceptOrderService => "UA",
                CodeOrderControlCodes.UnableToCancel => "UC",
                CodeOrderControlCodes.UnableToDiscontinue => "UD",
                CodeOrderControlCodes.UnableToRefill => "UF",
                CodeOrderControlCodes.UnableToPutOnHold => "UH",
                CodeOrderControlCodes.UnableToReplace => "UM",
                CodeOrderControlCodes.UnlinkOrderServiceFromPatientCareProblemOrGoal => "UN",
                CodeOrderControlCodes.UnableToRelease => "UR",
                CodeOrderControlCodes.UnableToChange => "UX",
                CodeOrderControlCodes.ChangeOrderServiceRequest => "XO",
                CodeOrderControlCodes.ChangedAsRequested => "XR",
                CodeOrderControlCodes.OrderServiceChangedUnsol => "XX",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeOrderControlCodes input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeOrderStatus enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeOrderStatus input)
        {
            return input switch
            {
                CodeOrderStatus.SomeButNotAllResultsAvailable => "A",
                CodeOrderStatus.OrderWasCanceled => "CA",
                CodeOrderStatus.OrderIsCompleted => "CM",
                CodeOrderStatus.OrderWasDiscontinued => "DC",
                CodeOrderStatus.ErrorOrderNotFound => "ER",
                CodeOrderStatus.OrderIsOnHold => "HD",
                CodeOrderStatus.InProcessUnspecified => "IP",
                CodeOrderStatus.OrderHasBeenReplaced => "RP",
                CodeOrderStatus.InProcessScheduled => "SC",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeOrderStatus input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeOrganDonorCode enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeOrganDonorCode input)
        {
            return input switch
            {
                CodeOrganDonorCode.YesPatientIsDonorButDocumentationNotOnFile => "F",
                CodeOrganDonorCode.NoPatientIsNotDonorButInfoWasProvided => "I",
                CodeOrganDonorCode.NoPatientHasNotAgreedToBeDonor => "N",
                CodeOrganDonorCode.Unknown => "U",
                CodeOrganDonorCode.YesPatientIsDocumentedDonorAndDocumentationIsOnFile => "Y",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeOrganDonorCode input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeOrganizationalNameType enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeOrganizationalNameType input)
        {
            return input switch
            {
                CodeOrganizationalNameType.AliasName => "A",
                CodeOrganizationalNameType.DisplayName => "D",
                CodeOrganizationalNameType.LegalName => "L",
                CodeOrganizationalNameType.StockExchangeListingName => "SL",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeOrganizationalNameType input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeOutlierType enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeOutlierType input)
        {
            return input switch
            {
                CodeOutlierType.OutlierCost => "C",
                CodeOutlierType.OutlierDays => "D",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeOutlierType input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeOverride enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeOverride input)
        {
            return input switch
            {
                CodeOverride.OverrideAllowed => "A",
                CodeOverride.OverrideRequired => "R",
                CodeOverride.OverrideNotAllowed => "X",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeOverride input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodePatientClass enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodePatientClass input)
        {
            return input switch
            {
                CodePatientClass.Obstetrics => "B",
                CodePatientClass.Emergency => "E",
                CodePatientClass.Inpatient => "I",
                CodePatientClass.Outpatient => "O",
                CodePatientClass.Preadmit => "P",
                CodePatientClass.RecurringPatient => "R",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodePatientClass input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodePatientLocationType enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodePatientLocationType input)
        {
            return input switch
            {
                CodePatientLocationType.Bed => "B",
                CodePatientLocationType.Clinic => "C",
                CodePatientLocationType.Department => "D",
                CodePatientLocationType.ExamRoom => "E",
                CodePatientLocationType.OtherLocation => "L",
                CodePatientLocationType.NursingUnit => "N",
                CodePatientLocationType.OperatingRoom => "O",
                CodePatientLocationType.Room => "R",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodePatientLocationType input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodePatientOutcome enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodePatientOutcome input)
        {
            return input switch
            {
                CodePatientOutcome.Died => "D",
                CodePatientOutcome.FullyRecovered => "F",
                CodePatientOutcome.NotRecoveringUnchanged => "N",
                CodePatientOutcome.Recovering => "R",
                CodePatientOutcome.Sequelae => "S",
                CodePatientOutcome.Unknown => "U",
                CodePatientOutcome.Worsening => "W",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodePatientOutcome input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodePatientsRelationshiptoInsured enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodePatientsRelationshiptoInsured input)
        {
            return input switch
            {
                CodePatientsRelationshiptoInsured.PatientIsInsured => "01",
                CodePatientsRelationshiptoInsured.Spouse => "02",
                CodePatientsRelationshiptoInsured.NaturalChildInsuredFinancialResponsibility => "03",
                CodePatientsRelationshiptoInsured.NaturalChildInsuredDoesNotHaveFinancialResponsibility => "04",
                CodePatientsRelationshiptoInsured.StepChild => "05",
                CodePatientsRelationshiptoInsured.FosterChild => "06",
                CodePatientsRelationshiptoInsured.WardOfTheCourt => "07",
                CodePatientsRelationshiptoInsured.Employee => "08",
                CodePatientsRelationshiptoInsured.Unknown => "09",
                CodePatientsRelationshiptoInsured.HandicappedDependent => "10",
                CodePatientsRelationshiptoInsured.OrganDonor => "11",
                CodePatientsRelationshiptoInsured.CadaverDonor => "12",
                CodePatientsRelationshiptoInsured.Grandchild => "13",
                CodePatientsRelationshiptoInsured.NieceNephew => "14",
                CodePatientsRelationshiptoInsured.InjuredPlaintiff => "15",
                CodePatientsRelationshiptoInsured.SponsoredDependent => "16",
                CodePatientsRelationshiptoInsured.MinorDependentOfAMinorDependent => "17",
                CodePatientsRelationshiptoInsured.Parent => "18",
                CodePatientsRelationshiptoInsured.Grandparent => "19",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodePatientsRelationshiptoInsured input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodePolicyType enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodePolicyType input)
        {
            return input switch
            {
                CodePolicyType.SecondAncillary => "2ANC",
                CodePolicyType.SecondMajorMedical => "2MMD",
                CodePolicyType.ThirdMajorMedical => "3MMD",
                CodePolicyType.Ancillary => "ANC",
                CodePolicyType.MajorMedical => "MMD",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodePolicyType input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodePractitionerIdNumberType enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodePractitionerIdNumberType input)
        {
            return input switch
            {
                CodePractitionerIdNumberType.CountyNumber => "CY",
                CodePractitionerIdNumberType.DrugEnforcementAgencyNo => "DEA",
                CodePractitionerIdNumberType.GeneralLedgerNumber => "GL",
                CodePractitionerIdNumberType.LaborAndIndustriesNumberDeprecated => "L&I",
                CodePractitionerIdNumberType.MedicaidNumber => "MCD",
                CodePractitionerIdNumberType.MedicareNumber => "MCR",
                CodePractitionerIdNumberType.QaNumber => "QA",
                CodePractitionerIdNumberType.StateLicenseNumber => "SL",
                CodePractitionerIdNumberType.TaxIdNumber => "TAX",
                CodePractitionerIdNumberType.TrainingLicenseNumber => "TRL",
                CodePractitionerIdNumberType.UniquePhysicianIdNo => "UPIN",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodePractitionerIdNumberType input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodePreferredMethodOfContact enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodePreferredMethodOfContact input)
        {
            return input switch
            {
                CodePreferredMethodOfContact.BeeperNumber => "B",
                CodePreferredMethodOfContact.CellularPhoneNumber => "C",
                CodePreferredMethodOfContact.EmailAddress => "E",
                CodePreferredMethodOfContact.FaxNumber => "F",
                CodePreferredMethodOfContact.HomePhoneNumber => "H",
                CodePreferredMethodOfContact.OfficePhoneNumber => "O",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodePreferredMethodOfContact input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodePriceType enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodePriceType input)
        {
            return input switch
            {
                CodePriceType.AdministrativePriceOrHandlingFee => "AP",
                CodePriceType.DirectUnitCost => "DC",
                CodePriceType.IndirectUnitCost => "IC",
                CodePriceType.ProfessionalFeeForPerformingProvider => "PF",
                CodePriceType.TechnologyFeeForUseOfEquipment => "TF",
                CodePriceType.TotalPrice => "TP",
                CodePriceType.UnitPrice => "UP",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodePriceType input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodePrimaryKeyValueType enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodePrimaryKeyValueType input)
        {
            return input switch
            {
                CodePrimaryKeyValueType.CodedElement => "CE",
                CodePrimaryKeyValueType.PersonLocation => "PL",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodePrimaryKeyValueType input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodePrimaryObserversQualification enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodePrimaryObserversQualification input)
        {
            return input switch
            {
                CodePrimaryObserversQualification.HealthCareConsumerPatient => "C",
                CodePrimaryObserversQualification.OtherHealthProfessional => "H",
                CodePrimaryObserversQualification.LawyerAttorney => "L",
                CodePrimaryObserversQualification.MidLevelProfessional => "M",
                CodePrimaryObserversQualification.OtherNonHealthProfessional => "O",
                CodePrimaryObserversQualification.PhysicianOsteopathHomeopath => "P",
                CodePrimaryObserversQualification.Pharmacist => "R",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodePrimaryObserversQualification input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodePriority enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodePriority input)
        {
            return input switch
            {
                CodePriority.AsSoonAsPossible => "A",
                CodePriority.Preoperative => "P",
                CodePriority.Routine => "R",
                CodePriority.Stat => "S",
                CodePriority.TimingCritical => "T",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodePriority input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodePrivacyLevel enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodePrivacyLevel input)
        {
            return input switch
            {
                CodePrivacyLevel.Isolation => "F",
                CodePrivacyLevel.PrivateRoomMedicallyJustified => "J",
                CodePrivacyLevel.PrivateRoom => "P",
                CodePrivacyLevel.PrivateRoomDueToOverflow => "Q",
                CodePrivacyLevel.SemiPrivateRoom => "S",
                CodePrivacyLevel.Ward => "W",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodePrivacyLevel input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeProblemGoalActionCode enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeProblemGoalActionCode input)
        {
            return input switch
            {
                CodeProblemGoalActionCode.Add => "AD",
                CodeProblemGoalActionCode.Correct => "CO",
                CodeProblemGoalActionCode.Delete => "DE",
                CodeProblemGoalActionCode.Link => "LI",
                CodeProblemGoalActionCode.Unchanged => "UC",
                CodeProblemGoalActionCode.Unlink => "UN",
                CodeProblemGoalActionCode.Update => "UP",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeProblemGoalActionCode input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeProcedureFunctionalType enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeProcedureFunctionalType input)
        {
            return input switch
            {
                CodeProcedureFunctionalType.Anesthesia => "A",
                CodeProcedureFunctionalType.DiagnosticProcedure => "D",
                CodeProcedureFunctionalType.InvasiveProcedureNotClassified => "I",
                CodeProcedureFunctionalType.ProcedureForTreatment => "P",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeProcedureFunctionalType input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeProcedurePractitionerIdentifierCodeType enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeProcedurePractitionerIdentifierCodeType input)
        {
            return input switch
            {
                CodeProcedurePractitionerIdentifierCodeType.AnesthesiologistAnesthetist => "AN",
                CodeProcedurePractitionerIdentifierCodeType.AssistantSurgeon => "AS",
                CodeProcedurePractitionerIdentifierCodeType.CertifiedNurseMidwife => "CM",
                CodeProcedurePractitionerIdentifierCodeType.NursePractitioner => "NP",
                CodeProcedurePractitionerIdentifierCodeType.ProcedureMdSurgeon => "PR",
                CodeProcedurePractitionerIdentifierCodeType.PrimarySurgeon => "PS",
                CodeProcedurePractitionerIdentifierCodeType.Radiologist => "RD",
                CodeProcedurePractitionerIdentifierCodeType.Resident => "RS",
                CodeProcedurePractitionerIdentifierCodeType.ScrubNurse => "SN",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeProcedurePractitionerIdentifierCodeType input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeProcessingId enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeProcessingId input)
        {
            return input switch
            {
                CodeProcessingId.Debugging => "D",
                CodeProcessingId.Production => "P",
                CodeProcessingId.Training => "T",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeProcessingId input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeProcessingMode enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeProcessingMode input)
        {
            return input switch
            {
                CodeProcessingMode.Archive => "A",
                CodeProcessingMode.InitialLoad => "I",
                CodeProcessingMode.NotPresent => "Not present",
                CodeProcessingMode.RestoreFromArchive => "R",
                CodeProcessingMode.CurrentProcessing => "T",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeProcessingMode input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeProcessingPriority enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeProcessingPriority input)
        {
            return input switch
            {
                CodeProcessingPriority.AsSoonAsPossible => "A",
                CodeProcessingPriority.DoAtBedsideOrPortable => "B",
                CodeProcessingPriority.MeasureContinuously => "C",
                CodeProcessingPriority.Preoperative => "P",
                CodeProcessingPriority.Routine => "R",
                CodeProcessingPriority.Stat => "S",
                CodeProcessingPriority.TimingCritical => "T",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeProcessingPriority input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeProductSource enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeProductSource input)
        {
            return input switch
            {
                CodeProductSource.ActualProductWasEvaluated => "A",
                CodeProductSource.ProductFromSameLotWasEvaluated => "L",
                CodeProductSource.ProductFromNonRelatedInventoryWasEvaluated => "N",
                CodeProductSource.ProductFromReserveWasEvaluated => "R",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeProductSource input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeProviderBilling enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeProviderBilling input)
        {
            return input switch
            {
                CodeProviderBilling.InstitutionBillsForProvider => "I",
                CodeProviderBilling.ProviderDoesOwnBilling => "P",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeProviderBilling input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeProviderRole enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeProviderRole input)
        {
            return input switch
            {
                CodeProviderRole.ConsultingProvider => "CP",
                CodeProviderRole.PrimaryCareProvider => "PP",
                CodeProviderRole.ReferringProvider => "RP",
                CodeProviderRole.ReferredToProvider => "RT",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeProviderRole input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodePurgeStatusCode enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodePurgeStatusCode input)
        {
            return input switch
            {
                CodePurgeStatusCode.VisitMarkedForDeletion => "D",
                CodePurgeStatusCode.VisitMarkedInactive => "I",
                CodePurgeStatusCode.MarkedForPurge => "P",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodePurgeStatusCode input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeQuantityLimitedRequest enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeQuantityLimitedRequest input)
        {
            return input switch
            {
                CodeQuantityLimitedRequest.Characters => "CH",
                CodeQuantityLimitedRequest.Lines => "LI",
                CodeQuantityLimitedRequest.Pages => "PG",
                CodeQuantityLimitedRequest.Records => "RD",
                CodeQuantityLimitedRequest.LocallyDefined => "ZO",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeQuantityLimitedRequest input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeQuantityMethod enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeQuantityMethod input)
        {
            return input switch
            {
                CodeQuantityMethod.ActualCount => "A",
                CodeQuantityMethod.EstimatedSeeComment => "E",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeQuantityMethod input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeQueryPriority enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeQueryPriority input)
        {
            return input switch
            {
                CodeQueryPriority.Deferred => "D",
                CodeQueryPriority.Immediate => "I",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeQueryPriority input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeQueryResponseFormatCode enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeQueryResponseFormatCode input)
        {
            return input switch
            {
                CodeQueryResponseFormatCode.ResponseIsInDisplayFormat => "D",
                CodeQueryResponseFormatCode.ResponseIsInRecordOrientedFormat => "R",
                CodeQueryResponseFormatCode.ResponseIsInTabularFormat => "T",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeQueryResponseFormatCode input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeQueryResponseStatus enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeQueryResponseStatus input)
        {
            return input switch
            {
                CodeQueryResponseStatus.ApplicationError => "AE",
                CodeQueryResponseStatus.ApplicationReject => "AR",
                CodeQueryResponseStatus.NoDataFoundNoErrors => "NF",
                CodeQueryResponseStatus.DataFoundNoErrors => "OK",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeQueryResponseStatus input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeQueryResultsLevel enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeQueryResultsLevel input)
        {
            return input switch
            {
                CodeQueryResultsLevel.OrderPlusOrderStatus => "O",
                CodeQueryResultsLevel.ResultsWithoutBulkText => "R",
                CodeQueryResultsLevel.StatusOnly => "S",
                CodeQueryResultsLevel.FullResults => "T",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeQueryResultsLevel input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeReadmissionIndicator enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeReadmissionIndicator input)
        {
            return input switch
            {
                CodeReadmissionIndicator.ReAdmission => "R",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeReadmissionIndicator input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeReferralCategory enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeReferralCategory input)
        {
            return input switch
            {
                CodeReferralCategory.Ambulatory => "A",
                CodeReferralCategory.Emergency => "E",
                CodeReferralCategory.Inpatient => "I",
                CodeReferralCategory.Outpatient => "O",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeReferralCategory input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeReferralDisposition enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeReferralDisposition input)
        {
            return input switch
            {
                CodeReferralDisposition.AssumeManagement => "AM",
                CodeReferralDisposition.ReturnPatientAfterEvaluation => "RP",
                CodeReferralDisposition.SecondOpinion => "SO",
                CodeReferralDisposition.SendWrittenReport => "WR",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeReferralDisposition input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeReferralPriority enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeReferralPriority input)
        {
            return input switch
            {
                CodeReferralPriority.Asap => "A",
                CodeReferralPriority.Routine => "R",
                CodeReferralPriority.Stat => "S",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeReferralPriority input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeReferralReason enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeReferralReason input)
        {
            return input switch
            {
                CodeReferralReason.ProviderOrdered => "O",
                CodeReferralReason.PatientPreference => "P",
                CodeReferralReason.SecondOpinion => "S",
                CodeReferralReason.WorkLoad => "W",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeReferralReason input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeReferralStatus enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeReferralStatus input)
        {
            return input switch
            {
                CodeReferralStatus.Accepted => "A",
                CodeReferralStatus.Expired => "E",
                CodeReferralStatus.Pending => "P",
                CodeReferralStatus.Rejected => "R",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeReferralStatus input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeReferralType enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeReferralType input)
        {
            return input switch
            {
                CodeReferralType.HomeCare => "Hom",
                CodeReferralType.Laboratory => "Lab",
                CodeReferralType.Medical => "Med",
                CodeReferralType.Psychiatric => "Psy",
                CodeReferralType.Radiology => "Rad",
                CodeReferralType.SkilledNursing => "Skn",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeReferralType input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeRelatednessAssessment enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeRelatednessAssessment input)
        {
            return input switch
            {
                CodeRelatednessAssessment.HighlyProbable => "H",
                CodeRelatednessAssessment.Improbable => "I",
                CodeRelatednessAssessment.ModeratelyProbable => "M",
                CodeRelatednessAssessment.NotRelated => "N",
                CodeRelatednessAssessment.SomewhatProbable => "S",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeRelatednessAssessment input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeRelationalConjunction enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeRelationalConjunction input)
        {
            return input switch
            {
                CodeRelationalConjunction.Default => "AND",
                CodeRelationalConjunction.Or => "OR",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeRelationalConjunction input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeRelationalOperator enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeRelationalOperator input)
        {
            return input switch
            {
                CodeRelationalOperator.Contains => "CT",
                CodeRelationalOperator.Equal => "EQ",
                CodeRelationalOperator.GreaterThanOrEqual => "GE",
                CodeRelationalOperator.Generic => "GN",
                CodeRelationalOperator.GreaterThan => "GT",
                CodeRelationalOperator.LessThanOrEqual => "LE",
                CodeRelationalOperator.LessThan => "LT",
                CodeRelationalOperator.NotEqual => "NE",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeRelationalOperator input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeRelationshipModifier enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeRelationshipModifier input)
        {
            return input switch
            {
                CodeRelationshipModifier.BloodProductUnit => "BPU",
                CodeRelationshipModifier.Control => "CONTROL",
                CodeRelationshipModifier.Donor => "DONOR",
                CodeRelationshipModifier.Patient => "PATIENT",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeRelationshipModifier input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeReligion enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeReligion input)
        {
            return input switch
            {
                CodeReligion.Atheist => "A",
                CodeReligion.Baptist => "B",
                CodeReligion.Catholic => "C",
                CodeReligion.Episcopalian => "E",
                CodeReligion.Judaism => "J",
                CodeReligion.Lutheran => "L",
                CodeReligion.ChurchOfLatterDaySaintsMormon => "M",
                CodeReligion.Hindu => "N",
                CodeReligion.Protestant => "P",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeReligion input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeReportingPriority enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeReportingPriority input)
        {
            return input switch
            {
                CodeReportingPriority.CallBackResults => "C",
                CodeReportingPriority.RushReporting => "R",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeReportingPriority input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeReportPriority enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeReportPriority input)
        {
            return input switch
            {
                CodeReportPriority.Routine => "R",
                CodeReportPriority.Stat => "S",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeReportPriority input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeReportSource enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeReportSource input)
        {
            return input switch
            {
                CodeReportSource.ClinicalTrial => "C",
                CodeReportSource.DatabaseRegistryPoisonControlCenter => "D",
                CodeReportSource.Distributor => "E",
                CodeReportSource.HealthProfessional => "H",
                CodeReportSource.Literature => "L",
                CodeReportSource.ManufacturerMarketingAuthorityHolder => "M",
                CodeReportSource.NonHealthcareProfessional => "N",
                CodeReportSource.Other => "O",
                CodeReportSource.Patient => "P",
                CodeReportSource.RegulatoryAgency => "R",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeReportSource input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeReportTiming enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeReportTiming input)
        {
            return input switch
            {
                CodeReportTiming.TenDayReport => "10D",
                CodeReportTiming.FifteenDayReport => "15D",
                CodeReportTiming.ThirtyDayReport => "30D",
                CodeReportTiming.ThreeDayReport => "3D",
                CodeReportTiming.SevenDayReport => "7D",
                CodeReportTiming.AdditionalInformation => "AD",
                CodeReportTiming.Correction => "CO",
                CodeReportTiming.DeviceEvaluation => "DE",
                CodeReportTiming.Periodic => "PD",
                CodeReportTiming.RequestedInformation => "RQ",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeReportTiming input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeResponseFlag enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeResponseFlag input)
        {
            return input switch
            {
                CodeResponseFlag.AlsoOtherAssociatedSegments => "D",
                CodeResponseFlag.ReportExceptionsOnly => "E",
                CodeResponseFlag.PlusConfirmationsExplicitly => "F",
                CodeResponseFlag.OnlyMsaSegmentIsReturned => "N",
                CodeResponseFlag.ReplacementAndParentChild => "R",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeResponseFlag input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeResponseLevel enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeResponseLevel input)
        {
            return input switch
            {
                CodeResponseLevel.Always => "AL",
                CodeResponseLevel.ErrorReject => "ER",
                CodeResponseLevel.Never => "NE",
                CodeResponseLevel.Success => "SU",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeResponseLevel input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeResultStatus enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeResultStatus input)
        {
            return input switch
            {
                CodeResultStatus.SomeResultsAvailable => "A",
                CodeResultStatus.CorrectedFinal => "C",
                CodeResultStatus.FinalResults => "F",
                CodeResultStatus.NoResultsAvailableSpecimenReceivedProcedureIncomplete => "I",
                CodeResultStatus.OrderReceivedSpecimenNotYetReceived => "O",
                CodeResultStatus.Preliminary => "P",
                CodeResultStatus.ResultsStoredNotYetVerified => "R",
                CodeResultStatus.NoResultsAvailableProcedureScheduledButNotDone => "S",
                CodeResultStatus.NoResultsAvailableOrderCanceled => "X",
                CodeResultStatus.NoOrderOnRecordForThisTest => "Y",
                CodeResultStatus.NoRecordOfThisPatient => "Z",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeResultStatus input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeRoomType enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeRoomType input)
        {
            return input switch
            {
                CodeRoomType.SecondIntensiveCareUnit => "2ICU",
                CodeRoomType.SecondPrivateRoom => "2PRI",
                CodeRoomType.SecondSemiPrivateRoom => "2SPR",
                CodeRoomType.IntensiveCareUnit => "ICU",
                CodeRoomType.PrivateRoom => "PRI",
                CodeRoomType.SemiPrivateRoom => "SPR",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeRoomType input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeRouteOfAdministration enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeRouteOfAdministration input)
        {
            return input switch
            {
                CodeRouteOfAdministration.ApplyExternally => "AP",
                CodeRouteOfAdministration.Buccal => "B",
                CodeRouteOfAdministration.Dental => "DT",
                CodeRouteOfAdministration.Epidural => "EP",
                CodeRouteOfAdministration.EndotrachialTube => "ET",
                CodeRouteOfAdministration.GastrostomyTube => "GTT",
                CodeRouteOfAdministration.GuIrrigant => "GU",
                CodeRouteOfAdministration.IntraArterial => "IA",
                CodeRouteOfAdministration.Intrabursal => "IB",
                CodeRouteOfAdministration.Intracardiac => "IC",
                CodeRouteOfAdministration.Intracervical => "ICV",
                CodeRouteOfAdministration.Intradermal => "ID",
                CodeRouteOfAdministration.Inhalation => "IH",
                CodeRouteOfAdministration.IntrahepaticArtery => "IHA",
                CodeRouteOfAdministration.Intramuscular => "IM",
                CodeRouteOfAdministration.ImmerseBodyPart => "IMR",
                CodeRouteOfAdministration.Intranasal => "IN",
                CodeRouteOfAdministration.Intraocular => "IO",
                CodeRouteOfAdministration.Intraperitoneal => "IP",
                CodeRouteOfAdministration.Intrasynovial => "IS",
                CodeRouteOfAdministration.Intrathecal => "IT",
                CodeRouteOfAdministration.Intrauterine => "IU",
                CodeRouteOfAdministration.Intravenous => "IV",
                CodeRouteOfAdministration.MucousMembrane => "MM",
                CodeRouteOfAdministration.MouthThroat => "MTH",
                CodeRouteOfAdministration.Nasogastric => "NG",
                CodeRouteOfAdministration.NasalProngs => "NP",
                CodeRouteOfAdministration.Nasal => "NS",
                CodeRouteOfAdministration.NasotrachialTube => "NT",
                CodeRouteOfAdministration.Ophthalmic => "OP",
                CodeRouteOfAdministration.Otic => "OT",
                CodeRouteOfAdministration.OtherMiscellaneous => "OTH",
                CodeRouteOfAdministration.Perfusion => "PF",
                CodeRouteOfAdministration.Oral => "PO",
                CodeRouteOfAdministration.Rectal => "PR",
                CodeRouteOfAdministration.RebreatherMask => "RM",
                CodeRouteOfAdministration.Subcutaneous => "SC",
                CodeRouteOfAdministration.SoakedDressing => "SD",
                CodeRouteOfAdministration.Sublingual => "SL",
                CodeRouteOfAdministration.Transdermal => "TD",
                CodeRouteOfAdministration.Translingual => "TL",
                CodeRouteOfAdministration.Topical => "TP",
                CodeRouteOfAdministration.Tracheostomy => "TRA",
                CodeRouteOfAdministration.Urethral => "UR",
                CodeRouteOfAdministration.Vaginal => "VG",
                CodeRouteOfAdministration.Ventimask => "VM",
                CodeRouteOfAdministration.Wound => "WND",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeRouteOfAdministration input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeRXComponentType enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeRXComponentType input)
        {
            return input switch
            {
                CodeRXComponentType.Additive => "A",
                CodeRXComponentType.Base => "B",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeRXComponentType input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeSegmentActionCode enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeSegmentActionCode input)
        {
            return input switch
            {
                CodeSegmentActionCode.AddInsert => "A",
                CodeSegmentActionCode.Delete => "D",
                CodeSegmentActionCode.Update => "U",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeSegmentActionCode input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeSourceOfComment enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeSourceOfComment input)
        {
            return input switch
            {
                CodeSourceOfComment.AncillaryDepartmentIsSourceOfComment => "L",
                CodeSourceOfComment.OtherSystemIsSourceOfComment => "O",
                CodeSourceOfComment.OrdererIsSourceOfComment => "P",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeSourceOfComment input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeSourceType enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeSourceType input)
        {
            return input switch
            {
                CodeSourceType.Accept => "A",
                CodeSourceType.Initiate => "I",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeSourceType input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeSpecialtyType enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeSpecialtyType input)
        {
            return input switch
            {
                CodeSpecialtyType.Allergy => "ALC",
                CodeSpecialtyType.Ambulatory => "AMB",
                CodeSpecialtyType.Cancer => "CAN",
                CodeSpecialtyType.CoronaryCardiacCare => "CAR",
                CodeSpecialtyType.CriticalCare => "CCR",
                CodeSpecialtyType.Chiropractic => "CHI",
                CodeSpecialtyType.Education => "EDI",
                CodeSpecialtyType.Emergency => "EMR",
                CodeSpecialtyType.FamilyPlanning => "FPC",
                CodeSpecialtyType.IntensiveCare => "INT",
                CodeSpecialtyType.Isolation => "ISO",
                CodeSpecialtyType.Naturopathic => "NAT",
                CodeSpecialtyType.NewbornNurseryInfants => "NBI",
                CodeSpecialtyType.ObstetricsGynecology => "OBG",
                CodeSpecialtyType.Observation => "OBS",
                CodeSpecialtyType.OtherSpecialty => "OTH",
                CodeSpecialtyType.Pediatrics => "PED",
                CodeSpecialtyType.GeneralFamilyPractice => "PHY",
                CodeSpecialtyType.PediatricNeonatalIntensiveCare => "PIN",
                CodeSpecialtyType.PediatricPsychiatric => "PPS",
                CodeSpecialtyType.PediatricRehabilitation => "PRE",
                CodeSpecialtyType.PsychiatricIntensiveCare => "PSI",
                CodeSpecialtyType.Psychiatric => "PSY",
                CodeSpecialtyType.Rehabilitation => "REH",
                CodeSpecialtyType.Surgery => "SUR",
                CodeSpecialtyType.WalkInClinic => "WIC",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeSpecialtyType input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeSpecimenActionCode enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeSpecimenActionCode input)
        {
            return input switch
            {
                CodeSpecimenActionCode.AddOrderedTestsToExistingSpecimen => "A",
                CodeSpecimenActionCode.GeneratedOrderReflexOrder => "G",
                CodeSpecimenActionCode.LabToObtainSpecimenFromPatient => "L",
                CodeSpecimenActionCode.SpecimenObtainedByServiceOtherThanLab => "O",
                CodeSpecimenActionCode.PendingSpecimenOrderSentPriorToDelivery => "P",
                CodeSpecimenActionCode.RevisedOrder => "R",
                CodeSpecimenActionCode.ScheduleTheTestsSpecifiedBelow => "S",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeSpecimenActionCode input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeSpecimenSourceCodes enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeSpecimenSourceCodes input)
        {
            return input switch
            {
                CodeSpecimenSourceCodes.Abscess => "ABS",
                CodeSpecimenSourceCodes.AmnioticFluid => "AMN",
                CodeSpecimenSourceCodes.Aspirate => "ASP",
                CodeSpecimenSourceCodes.BloodBag => "BBL",
                CodeSpecimenSourceCodes.WholeBody => "BDY",
                CodeSpecimenSourceCodes.BileFluid => "BIFL",
                CodeSpecimenSourceCodes.WholeBlood => "BLD",
                CodeSpecimenSourceCodes.BloodArterial => "BLDA",
                CodeSpecimenSourceCodes.BloodCapillary => "BLDC",
                CodeSpecimenSourceCodes.BloodVenous => "BLDV",
                CodeSpecimenSourceCodes.Bone => "BON",
                CodeSpecimenSourceCodes.Basophils => "BPH",
                CodeSpecimenSourceCodes.BloodProductUnit => "BPU",
                CodeSpecimenSourceCodes.Burn => "BRN",
                CodeSpecimenSourceCodes.Bronchial => "BRO",
                CodeSpecimenSourceCodes.Breath => "BRTH",
                CodeSpecimenSourceCodes.Calculus => "CALC",
                CodeSpecimenSourceCodes.CordBloodCbld => "CBLD",
                CodeSpecimenSourceCodes.CardiacMuscle => "CDM",
                CodeSpecimenSourceCodes.Conjunctiva => "CNJT",
                CodeSpecimenSourceCodes.Cannula => "CNL",
                CodeSpecimenSourceCodes.Colostrum => "COL",
                CodeSpecimenSourceCodes.CerebralSpinalFluid => "CSF",
                CodeSpecimenSourceCodes.CatheterTip => "CTP",
                CodeSpecimenSourceCodes.Curettage => "CUR",
                CodeSpecimenSourceCodes.CervicalMucus => "CVM",
                CodeSpecimenSourceCodes.Cervix => "CVX",
                CodeSpecimenSourceCodes.Cyst => "CYST",
                CodeSpecimenSourceCodes.DialysisFluid => "DIAF",
                CodeSpecimenSourceCodes.DoseMedOrSubstance => "DOSE",
                CodeSpecimenSourceCodes.Drain => "DRN",
                CodeSpecimenSourceCodes.DuodenalFluid => "DUFL",
                CodeSpecimenSourceCodes.Ear => "EAR",
                CodeSpecimenSourceCodes.EarWax => "EARW",
                CodeSpecimenSourceCodes.Electrode => "ELT",
                CodeSpecimenSourceCodes.Endocardium => "ENDC",
                CodeSpecimenSourceCodes.Endometrium => "ENDM",
                CodeSpecimenSourceCodes.Eosinophils => "EOS",
                CodeSpecimenSourceCodes.ExhaledGasExhld => "EXHLD",
                CodeSpecimenSourceCodes.Eye => "EYE",
                CodeSpecimenSourceCodes.Fibroblasts => "FIB",
                CodeSpecimenSourceCodes.Fistula => "FIST",
                CodeSpecimenSourceCodes.Filter => "FLT",
                CodeSpecimenSourceCodes.BodyFluidUnsp => "FLU",
                CodeSpecimenSourceCodes.Gas => "GAS",
                CodeSpecimenSourceCodes.GastricFluidContents => "GAST",
                CodeSpecimenSourceCodes.Genital => "GEN",
                CodeSpecimenSourceCodes.GenitalCervix => "GENC",
                CodeSpecimenSourceCodes.GenitalLochia => "GENL",
                CodeSpecimenSourceCodes.GenitalVaginal => "GENV",
                CodeSpecimenSourceCodes.Hair => "HAR",
                CodeSpecimenSourceCodes.InhaledGas => "IHG",
                CodeSpecimenSourceCodes.Isolate => "ISLT",
                CodeSpecimenSourceCodes.IntubationTube => "IT",
                CodeSpecimenSourceCodes.Lamella => "LAM",
                CodeSpecimenSourceCodes.LiquidNos => "LIQ",
                CodeSpecimenSourceCodes.Line => "LN",
                CodeSpecimenSourceCodes.LineArterial => "LNA",
                CodeSpecimenSourceCodes.LineVenous => "LNV",
                CodeSpecimenSourceCodes.Lymphocytes => "LYM",
                CodeSpecimenSourceCodes.Macrophages => "MAC",
                CodeSpecimenSourceCodes.Marrow => "MAR",
                CodeSpecimenSourceCodes.MenstrualBlood => "MBLD",
                CodeSpecimenSourceCodes.Meconium => "MEC",
                CodeSpecimenSourceCodes.BreastMilk => "MILK",
                CodeSpecimenSourceCodes.Milk => "MLK",
                CodeSpecimenSourceCodes.Nail => "NAIL",
                CodeSpecimenSourceCodes.Nose => "NOS",
                CodeSpecimenSourceCodes.Other => "ORH",
                CodeSpecimenSourceCodes.PancreaticFluid => "PAFL",
                CodeSpecimenSourceCodes.Patient => "PAT",
                CodeSpecimenSourceCodes.Plasma => "PLAS",
                CodeSpecimenSourceCodes.PlasmaBag => "PLB",
                CodeSpecimenSourceCodes.Placenta => "PLC",
                CodeSpecimenSourceCodes.PleuralFluid => "PLR",
                CodeSpecimenSourceCodes.PolymorphonuclearNeutrophils => "PMN",
                CodeSpecimenSourceCodes.PlateletPoorPlasma => "PPP",
                CodeSpecimenSourceCodes.PlateletRichPlasma => "PRP",
                CodeSpecimenSourceCodes.PeritonealFluidAscites => "PRT",
                CodeSpecimenSourceCodes.Pus => "PUS",
                CodeSpecimenSourceCodes.Erythrocytes => "RBC",
                CodeSpecimenSourceCodes.RouteOfMedicine => "RT",
                CodeSpecimenSourceCodes.Saliva => "SAL",
                CodeSpecimenSourceCodes.SeminalFluidSem => "SEM",
                CodeSpecimenSourceCodes.Serum => "SER",
                CodeSpecimenSourceCodes.SkeletalMuscle => "SKM",
                CodeSpecimenSourceCodes.Skin => "SKN",
                CodeSpecimenSourceCodes.SynovialFluid => "SNV",
                CodeSpecimenSourceCodes.Spermatozoa => "SPRM",
                CodeSpecimenSourceCodes.Sputum => "SPT",
                CodeSpecimenSourceCodes.SputumCoughed => "SPTC",
                CodeSpecimenSourceCodes.SputumTrachealAspirate => "SPTT",
                CodeSpecimenSourceCodes.StoolFecal => "STL",
                CodeSpecimenSourceCodes.Stone => "STON",
                CodeSpecimenSourceCodes.Sweat => "SWT",
                CodeSpecimenSourceCodes.Tears => "TEAR",
                CodeSpecimenSourceCodes.Thrombocyte => "THRB",
                CodeSpecimenSourceCodes.Throat => "THRT",
                CodeSpecimenSourceCodes.TissueGallBladder => "TISG",
                CodeSpecimenSourceCodes.TissuePlacenta => "TISPL",
                CodeSpecimenSourceCodes.Tissue => "TISS",
                CodeSpecimenSourceCodes.TissueUlcer => "TISU",
                CodeSpecimenSourceCodes.TissueLargeIntestine => "TLGI",
                CodeSpecimenSourceCodes.TissueLung => "TLNG",
                CodeSpecimenSourceCodes.TissueSmallIntestine => "TSMI",
                CodeSpecimenSourceCodes.TubeNos => "TUB",
                CodeSpecimenSourceCodes.Ulcer => "ULC",
                CodeSpecimenSourceCodes.UmbilicalBlood => "UMB",
                CodeSpecimenSourceCodes.UnknownMedicine => "UMED",
                CodeSpecimenSourceCodes.Urine => "UR",
                CodeSpecimenSourceCodes.UrineCleanCatch => "URC",
                CodeSpecimenSourceCodes.UrineSediment => "URNS",
                CodeSpecimenSourceCodes.UrineCatheter => "URT",
                CodeSpecimenSourceCodes.Urethra => "URTH",
                CodeSpecimenSourceCodes.UnknownSubstance => "USUB",
                CodeSpecimenSourceCodes.Vomitus => "VOM",
                CodeSpecimenSourceCodes.Water => "WAT",
                CodeSpecimenSourceCodes.Leukocytes => "WBC",
                CodeSpecimenSourceCodes.Wick => "WICK",
                CodeSpecimenSourceCodes.Wound => "WND",
                CodeSpecimenSourceCodes.WoundAbscess => "WNDA",
                CodeSpecimenSourceCodes.WoundDrainage => "WNDD",
                CodeSpecimenSourceCodes.WoundExudate => "WNDE",
                CodeSpecimenSourceCodes.ToBeSpecifiedInAnotherPartOfMessage => "XXX",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeSpecimenSourceCodes input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeStatusOfEvaluation enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeStatusOfEvaluation input)
        {
            return input switch
            {
                CodeStatusOfEvaluation.EvaluationAnticipatedNotYetBegun => "A",
                CodeStatusOfEvaluation.ProductReceivedInConditionWhichMadeAnalysisImpossible => "C",
                CodeStatusOfEvaluation.ProductDiscardedNoFollowUp => "D",
                CodeStatusOfEvaluation.ProductRemainsImplantedNoFollowUp => "I",
                CodeStatusOfEvaluation.ProblemAlreadyKnownNoEvaluation => "K",
                CodeStatusOfEvaluation.Other => "O",
                CodeStatusOfEvaluation.EvaluationInProgress => "P",
                CodeStatusOfEvaluation.ProductUnderQuarantineNoFollowUp => "Q",
                CodeStatusOfEvaluation.ProductUnderRecall => "R",
                CodeStatusOfEvaluation.ProductUnavailableForFollowUp => "U",
                CodeStatusOfEvaluation.ProductNotMadeByCompany => "X",
                CodeStatusOfEvaluation.EvaluationCompleted => "Y",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeStatusOfEvaluation input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeStudentStatus enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeStudentStatus input)
        {
            return input switch
            {
                CodeStudentStatus.FullTimeStudent => "F",
                CodeStudentStatus.NotAStudent => "N",
                CodeStudentStatus.PartTimeStudent => "P",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeStudentStatus input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeSubstitutionStatus enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeSubstitutionStatus input)
        {
            return input switch
            {
                CodeSubstitutionStatus.NoProductSelectionIndicated => "0",
                CodeSubstitutionStatus.SubstitutionNotAllowedByPrescriber => "1",
                CodeSubstitutionStatus.SubstitutionAllowedPatientRequested => "2",
                CodeSubstitutionStatus.SubstitutionAllowedPharmacistSelected => "3",
                CodeSubstitutionStatus.SubstitutionAllowedGenericDrugNotInStock => "4",
                CodeSubstitutionStatus.SubstitutionAllowedDispensedAsGeneric => "5",
                CodeSubstitutionStatus.SubstitutionNotAllowedBrandMandatedByLaw => "7",
                CodeSubstitutionStatus.SubstitutionAllowedGenericNotAvailable => "8",
                CodeSubstitutionStatus.AGenericSubstitutionWasDispensed => "G",
                CodeSubstitutionStatus.NoSubstituteWasDispensed => "N",
                CodeSubstitutionStatus.TherapeuticSubstitutionWasDispensed => "T",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeSubstitutionStatus input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeSubtypeOfReferencedData enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeSubtypeOfReferencedData input)
        {
            return input switch
            {
                CodeSubtypeOfReferencedData.IsdnPcmAudioData => "BASIC",
                CodeSubtypeOfReferencedData.DigitalImagingAndCommunicationsInMedicine => "DICOM",
                CodeSubtypeOfReferencedData.FacsimileData => "FAX",
                CodeSubtypeOfReferencedData.GraphicsInterchangeFormat => "GIF",
                CodeSubtypeOfReferencedData.HypertextMarkupLanguage => "HTML",
                CodeSubtypeOfReferencedData.ElectronicInkDataJot10Standard => "JOT",
                CodeSubtypeOfReferencedData.JointPhotographicExpertsGroup => "JPEG",
                CodeSubtypeOfReferencedData.UninterpretedBinaryData => "Octet-stream",
                CodeSubtypeOfReferencedData.PictFormatImageData => "PICT",
                CodeSubtypeOfReferencedData.PostscriptProgram => "PostScript",
                CodeSubtypeOfReferencedData.RichTextFormat => "RTF",
                CodeSubtypeOfReferencedData.SgmlStandardGeneralizedMarkupLanguage => "SGML",
                CodeSubtypeOfReferencedData.TiffImageData => "TIFF",
                CodeSubtypeOfReferencedData.XmlExtensibleMarkupLanguage => "XML",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeSubtypeOfReferencedData input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeTelecommunicationEquipmentType enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeTelecommunicationEquipmentType input)
        {
            return input switch
            {
                CodeTelecommunicationEquipmentType.Beeper => "BP",
                CodeTelecommunicationEquipmentType.CellularOrMobilePhone => "CP",
                CodeTelecommunicationEquipmentType.Fax => "FX",
                CodeTelecommunicationEquipmentType.InternetAddress => "Internet",
                CodeTelecommunicationEquipmentType.Modem => "MD",
                CodeTelecommunicationEquipmentType.Telephone => "PH",
                CodeTelecommunicationEquipmentType.X400EmailAddress => "X.400",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeTelecommunicationEquipmentType input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeTelecommunicationUseCode enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeTelecommunicationUseCode input)
        {
            return input switch
            {
                CodeTelecommunicationUseCode.AnsweringServiceNumber => "ASN",
                CodeTelecommunicationUseCode.BeeperNumber => "BPN",
                CodeTelecommunicationUseCode.EmergencyNumber => "EMR",
                CodeTelecommunicationUseCode.NetworkEmailAddress => "NET",
                CodeTelecommunicationUseCode.OtherResidenceNumber => "ORN",
                CodeTelecommunicationUseCode.PrimaryResidenceNumber => "PRN",
                CodeTelecommunicationUseCode.VacationHomeNumber => "VHN",
                CodeTelecommunicationUseCode.WorkNumber => "WPN",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeTelecommunicationUseCode input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeTimeDelayPostChallenge enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeTimeDelayPostChallenge input)
        {
            return input switch
            {
                CodeTimeDelayPostChallenge.TenDays => "10D",
                CodeTimeDelayPostChallenge.TenMinutesPostChallenge => "10M",
                CodeTimeDelayPostChallenge.TwelveHoursPostChallenge => "12H",
                CodeTimeDelayPostChallenge.FifteenMinutesPostChallenge => "15M",
                CodeTimeDelayPostChallenge.OneHourPostChallenge => "1H",
                CodeTimeDelayPostChallenge.OneMonthPostChallenge => "1L",
                CodeTimeDelayPostChallenge.OneMinutePostChallenge => "1M",
                CodeTimeDelayPostChallenge.OneWeek => "1W",
                CodeTimeDelayPostChallenge.TwoAndAHalfHoursPostChallenge => "2.5H",
                CodeTimeDelayPostChallenge.TwentyMinutesPostChallenge => "20M",
                CodeTimeDelayPostChallenge.TwentyFourHoursPostChallenge => "24H",
                CodeTimeDelayPostChallenge.TwentyFiveMinutesPostChallenge => "25M",
                CodeTimeDelayPostChallenge.TwoDays => "2D",
                CodeTimeDelayPostChallenge.TwoHoursPostChallenge => "2H",
                CodeTimeDelayPostChallenge.TwoMonthsPostChallenge => "2L",
                CodeTimeDelayPostChallenge.TwoMinutesPostChallenge => "2M",
                CodeTimeDelayPostChallenge.TwoWeeks => "2W",
                CodeTimeDelayPostChallenge.ThirtyMinutesPostChallenge => "30M",
                CodeTimeDelayPostChallenge.ThreeDays => "3D",
                CodeTimeDelayPostChallenge.ThreeHoursPostChallenge => "3H",
                CodeTimeDelayPostChallenge.ThreeMonthsPostChallenge => "3L",
                CodeTimeDelayPostChallenge.ThreeMinutesPostChallenge => "3M",
                CodeTimeDelayPostChallenge.ThreeWeeks => "3W",
                CodeTimeDelayPostChallenge.FourDays => "4D",
                CodeTimeDelayPostChallenge.FourHoursPostChallenge => "4H",
                CodeTimeDelayPostChallenge.FourMinutesPostChallenge => "4M",
                CodeTimeDelayPostChallenge.FourWeeks => "4W",
                CodeTimeDelayPostChallenge.FiveDays => "5D",
                CodeTimeDelayPostChallenge.FiveHoursPostChallenge => "5H",
                CodeTimeDelayPostChallenge.FiveMinutesPostChallenge => "5M",
                CodeTimeDelayPostChallenge.SixDays => "6D",
                CodeTimeDelayPostChallenge.SixHoursPostChallenge => "6H",
                CodeTimeDelayPostChallenge.SixMinutesPostChallenge => "6M",
                CodeTimeDelayPostChallenge.SevenDays => "7D",
                CodeTimeDelayPostChallenge.SevenHoursPostChallenge => "7H",
                CodeTimeDelayPostChallenge.SevenMinutesPostChallenge => "7M",
                CodeTimeDelayPostChallenge.EightHoursPostChallenge => "8H",
                CodeTimeDelayPostChallenge.EightHoursAlignedOnNursingShifts => "8H SHIFT",
                CodeTimeDelayPostChallenge.EightMinutesPostChallenge => "8M",
                CodeTimeDelayPostChallenge.NineMinutesPostChallenge => "9M",
                CodeTimeDelayPostChallenge.Baseline => "BS",
                CodeTimeDelayPostChallenge.TimePostDrugDoseHighestDrugLevelReached => "PEAK",
                CodeTimeDelayPostChallenge.TimeFromChallengeOrDoseNotSpecified => "RANDOM",
                CodeTimeDelayPostChallenge.TimePostDrugDoseLowestDrugLevelReached => "TROUGH",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeTimeDelayPostChallenge input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeTimeSelectionCriteriaParameterClassCodes enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeTimeSelectionCriteriaParameterClassCodes input)
        {
            return input switch
            {
                CodeTimeSelectionCriteriaParameterClassCodes.Friday => "Fri",
                CodeTimeSelectionCriteriaParameterClassCodes.Monday => "Mon",
                CodeTimeSelectionCriteriaParameterClassCodes.IsPreferredEndTime => "Prefend",
                CodeTimeSelectionCriteriaParameterClassCodes.IsPreferredStartTime => "Prefstart",
                CodeTimeSelectionCriteriaParameterClassCodes.Saturday => "Sat",
                CodeTimeSelectionCriteriaParameterClassCodes.Sunday => "Sun",
                CodeTimeSelectionCriteriaParameterClassCodes.Thursday => "Thu",
                CodeTimeSelectionCriteriaParameterClassCodes.Tuesday => "Tue",
                CodeTimeSelectionCriteriaParameterClassCodes.Wednesday => "Wed",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeTimeSelectionCriteriaParameterClassCodes input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeTransactionType enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeTransactionType input)
        {
            return input switch
            {
                CodeTransactionType.Adjustment => "AJ",
                CodeTransactionType.Credit => "CD",
                CodeTransactionType.Charge => "CG",
                CodeTransactionType.Payment => "PY",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeTransactionType input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeTransportArranged enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeTransportArranged input)
        {
            return input switch
            {
                CodeTransportArranged.Arranged => "A",
                CodeTransportArranged.NotArranged => "N",
                CodeTransportArranged.Unknown => "U",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeTransportArranged input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeTransportationMode enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeTransportationMode input)
        {
            return input switch
            {
                CodeTransportationMode.CartPatientTravelsOnCartOrGurney => "CART",
                CodeTransportationMode.TheExaminingDeviceGoesToPatientsLocation => "PORT",
                CodeTransportationMode.PatientWalksToDiagnosticService => "WALK",
                CodeTransportationMode.Wheelchair => "WHLC",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeTransportationMode input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeTrayType enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeTrayType input)
        {
            return input switch
            {
                CodeTrayType.EarlyTray => "EARLY",
                CodeTrayType.GuestTray => "GUEST",
                CodeTrayType.LateTray => "LATE",
                CodeTrayType.TrayMessageOnly => "MSG",
                CodeTrayType.NoTray => "NO",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeTrayType input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeTypeOfAgreement enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeTypeOfAgreement input)
        {
            return input switch
            {
                CodeTypeOfAgreement.Maternity => "M",
                CodeTypeOfAgreement.Standard => "S",
                CodeTypeOfAgreement.Unified => "U",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeTypeOfAgreement input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeTypeOfReferencedData enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeTypeOfReferencedData input)
        {
            return input switch
            {
                CodeTypeOfReferencedData.OtherApplicationData => "AP",
                CodeTypeOfReferencedData.OtherApplicationDataDeprecated => "Application",
                CodeTypeOfReferencedData.AudioData => "AU",
                CodeTypeOfReferencedData.AudioDataDeprecated => "Audio",
                CodeTypeOfReferencedData.FormattedText => "FT",
                CodeTypeOfReferencedData.ImageData => "IM",
                CodeTypeOfReferencedData.ImageDataDeprecated => "Image",
                CodeTypeOfReferencedData.NonScannedImage => "NS",
                CodeTypeOfReferencedData.ScannedDocument => "SD",
                CodeTypeOfReferencedData.ScannedImage => "SI",
                CodeTypeOfReferencedData.MachineReadableTextDocument => "TEXT",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeTypeOfReferencedData input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeUniversalIdType enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeUniversalIdType input)
        {
            return input switch
            {
                CodeUniversalIdType.DomainNameSystem => "DNS",
                CodeUniversalIdType.GloballyUniqueIdentifier => "GUID",
                CodeUniversalIdType.CenHealthcareCodingIdentifier => "HCD",
                CodeUniversalIdType.Hl7RegistrationSchemes => "HL7",
                CodeUniversalIdType.IsoObjectIdentifier => "ISO",
                CodeUniversalIdType.LocalL => "L",
                CodeUniversalIdType.LocalLMN => "L,M,N",
                CodeUniversalIdType.LocalM => "M",
                CodeUniversalIdType.LocalN => "N",
                CodeUniversalIdType.Random => "Random",
                CodeUniversalIdType.UniversalUniqueIdentifier => "UUID",
                CodeUniversalIdType.X400MhsIdentifier => "x400",
                CodeUniversalIdType.X500DirectoryName => "x500",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeUniversalIdType input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeVaccinesAdministered enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeVaccinesAdministered input)
        {
            return input switch
            {
                CodeVaccinesAdministered.Dtp => "01",
                CodeVaccinesAdministered.Opv => "02",
                CodeVaccinesAdministered.Mmr => "03",
                CodeVaccinesAdministered.MR => "04",
                CodeVaccinesAdministered.Measles => "05",
                CodeVaccinesAdministered.Rubella => "06",
                CodeVaccinesAdministered.Mumps => "07",
                CodeVaccinesAdministered.HepBAdolescentOrPediatric => "08",
                CodeVaccinesAdministered.TdAdult09 => "09",
                CodeVaccinesAdministered.Ipv => "10",
                CodeVaccinesAdministered.Pertussis => "11",
                CodeVaccinesAdministered.DiphtheriaAntitoxin => "12",
                CodeVaccinesAdministered.Tig => "13",
                CodeVaccinesAdministered.IgNos => "14",
                CodeVaccinesAdministered.InfluenzaSplitInclPurifiedSurfaceAntigen => "15",
                CodeVaccinesAdministered.InfluenzaWhole => "16",
                CodeVaccinesAdministered.HibNos => "17",
                CodeVaccinesAdministered.RabiesIntramuscularInjection => "18",
                CodeVaccinesAdministered.Bcg => "19",
                CodeVaccinesAdministered.Dtap => "20",
                CodeVaccinesAdministered.Varicella => "21",
                CodeVaccinesAdministered.DtpHib => "22",
                CodeVaccinesAdministered.Plague => "23",
                CodeVaccinesAdministered.Anthrax => "24",
                CodeVaccinesAdministered.TyphoidOral => "25",
                CodeVaccinesAdministered.Cholera => "26",
                CodeVaccinesAdministered.BotulinumAntitoxin => "27",
                CodeVaccinesAdministered.DtPediatric => "28",
                CodeVaccinesAdministered.Cmvig => "29",
                CodeVaccinesAdministered.Hbig => "30",
                CodeVaccinesAdministered.HepAPediatricNos => "31",
                CodeVaccinesAdministered.Meningococcal => "32",
                CodeVaccinesAdministered.Pneumococcal => "33",
                CodeVaccinesAdministered.Rig => "34",
                CodeVaccinesAdministered.TetanusToxoid => "35",
                CodeVaccinesAdministered.Vzig => "36",
                CodeVaccinesAdministered.YellowFever => "37",
                CodeVaccinesAdministered.RubellaMumps => "38",
                CodeVaccinesAdministered.JapaneseEncephalitis => "39",
                CodeVaccinesAdministered.RabiesIntradermalInjection => "40",
                CodeVaccinesAdministered.TyphoidParenteral => "41",
                CodeVaccinesAdministered.HepBAdolescentHighRiskInfant2 => "42",
                CodeVaccinesAdministered.HepBAdult4 => "43",
                CodeVaccinesAdministered.HepBDialysis => "44",
                CodeVaccinesAdministered.HepBNos => "45",
                CodeVaccinesAdministered.HibPrpD => "46",
                CodeVaccinesAdministered.HibHboc => "47",
                CodeVaccinesAdministered.HibPrpT => "48",
                CodeVaccinesAdministered.HibPrpOmp => "49",
                CodeVaccinesAdministered.DtapHib => "50",
                CodeVaccinesAdministered.HibHepB => "51",
                CodeVaccinesAdministered.HepAAdult => "52",
                CodeVaccinesAdministered.TyphoidParenteralAkdUSMilitary => "53",
                CodeVaccinesAdministered.AdenovirusType4 => "54",
                CodeVaccinesAdministered.AdenovirusType7 => "55",
                CodeVaccinesAdministered.DengueFever => "56",
                CodeVaccinesAdministered.Hantavirus => "57",
                CodeVaccinesAdministered.HepC => "58",
                CodeVaccinesAdministered.HepE => "59",
                CodeVaccinesAdministered.HerpesSimplex2 => "60",
                CodeVaccinesAdministered.Hiv => "61",
                CodeVaccinesAdministered.HpvQuadrivalent => "62",
                CodeVaccinesAdministered.JuninVirus => "63",
                CodeVaccinesAdministered.Leishmaniasis => "64",
                CodeVaccinesAdministered.Leprosy => "65",
                CodeVaccinesAdministered.LymeDisease => "66",
                CodeVaccinesAdministered.Malaria => "67",
                CodeVaccinesAdministered.Melanoma => "68",
                CodeVaccinesAdministered.Parainfluenza3 => "69",
                CodeVaccinesAdministered.QFever => "70",
                CodeVaccinesAdministered.RsvIgiv => "71",
                CodeVaccinesAdministered.RheumaticFever => "72",
                CodeVaccinesAdministered.RiftValleyFever => "73",
                CodeVaccinesAdministered.RotavirusTetravalent => "74",
                CodeVaccinesAdministered.VacciniaSmallpox => "75",
                CodeVaccinesAdministered.StaphylococcusBacterioLysate => "76",
                CodeVaccinesAdministered.TickBorneEncephalitis => "77",
                CodeVaccinesAdministered.TularemiaVaccine => "78",
                CodeVaccinesAdministered.VacciniaImmuneGlobulin => "79",
                CodeVaccinesAdministered.VeeLive => "80",
                CodeVaccinesAdministered.VeeInactivated => "81",
                CodeVaccinesAdministered.AdenovirusNos1 => "82",
                CodeVaccinesAdministered.HepAPedAdol2Dose => "83",
                CodeVaccinesAdministered.HepAPedAdol3Dose => "84",
                CodeVaccinesAdministered.HepANos => "85",
                CodeVaccinesAdministered.Ig => "86",
                CodeVaccinesAdministered.Igiv => "87",
                CodeVaccinesAdministered.InfluenzaNos => "88",
                CodeVaccinesAdministered.PolioNos => "89",
                CodeVaccinesAdministered.RabiesNos => "90",
                CodeVaccinesAdministered.TyphoidNos => "91",
                CodeVaccinesAdministered.VeeNos => "92",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeVaccinesAdministered input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeValueCode enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeValueCode input)
        {
            return input switch
            {
                CodeValueCode.MostCommonSemiPrivateRate => "01",
                CodeValueCode.HospitalHasNoSemiPrivateRooms => "02",
                CodeValueCode.InpatientChargesCombinedBilled => "04",
                CodeValueCode.ProfessionalComponentIncludedInChargesAndBilledCarrier => "05",
                CodeValueCode.MedicareBloodDeductible => "06",
                CodeValueCode.MedicareLifeTimeReserveAmountInFirstYear => "08",
                CodeValueCode.MedicareCoInsuranceAmountInFirstYear => "09",
                CodeValueCode.LifetimeReserveAmountInSecondYear => "10",
                CodeValueCode.CoInsuranceAmountInSecondYear => "11",
                CodeValueCode.WorkingAgedBeneficiarySpouseWithEmployerGroupPlan => "12",
                CodeValueCode.EsrdBeneficiaryInMedicareCoordPeriodWithEmployerGroupPlan => "13",
                CodeValueCode.NoFault => "14",
                CodeValueCode.WorkersCompensation => "15",
                CodeValueCode.PhsOrOtherFederalAgency => "16",
                CodeValueCode.PayerCode => "17",
                CodeValueCode.Catastrophic => "21",
                CodeValueCode.Surplus => "22",
                CodeValueCode.RecurringMonthlyIncode => "23",
                CodeValueCode.MedicaidRateCode => "24",
                CodeValueCode.PreAdmissionTesting => "30",
                CodeValueCode.PatientLiabilityAmount => "31",
                CodeValueCode.PintsOfBloodFurnished => "37",
                CodeValueCode.BloodDeductiblePints => "38",
                CodeValueCode.PintsOfBloodReplaced => "39",
                CodeValueCode.NewCoverageNotImplementedByHmo => "40",
                CodeValueCode.BlackLung => "41",
                CodeValueCode.Va => "42",
                CodeValueCode.DisabledBeneficiaryUnderAge64WithLghp => "43",
                CodeValueCode.AmountFromPayerLessThanChargesButHigherThanPayment => "44",
                CodeValueCode.AccidentHour => "45",
                CodeValueCode.NumberOfGraceDays => "46",
                CodeValueCode.AnyLiabilityInsurance => "47",
                CodeValueCode.HemoglobinReading => "48",
                CodeValueCode.HematocritReading => "49",
                CodeValueCode.PhysicalTherapyVisits => "50",
                CodeValueCode.OccupationalTherapyVisits => "51",
                CodeValueCode.SpeechTherapyVisits => "52",
                CodeValueCode.CardiacRehabVisits => "53",
                CodeValueCode.SkilledNurseHomeVisitHours => "56",
                CodeValueCode.HomeHealthAideHomeVisitHours => "57",
                CodeValueCode.ArterialBloodGas => "58",
                CodeValueCode.OxygenSaturation => "59",
                CodeValueCode.HhaBranchMsa => "60",
                CodeValueCode.PeritonealDialysis => "67",
                CodeValueCode.EpoDrug => "68",
                CodeValueCode.PayerCodes70 => "70",
                CodeValueCode.PayerCodes70To72 => "70 ... 72",
                CodeValueCode.PayerCodes71 => "71",
                CodeValueCode.PayerCodes72 => "72",
                CodeValueCode.PayerCodes75 => "75",
                CodeValueCode.PayerCodes75To79 => "75 ... 79",
                CodeValueCode.PayerCodes76 => "76",
                CodeValueCode.PayerCodes77 => "77",
                CodeValueCode.PayerCodes78 => "78",
                CodeValueCode.PayerCodes79 => "79",
                CodeValueCode.PsychiatricVisits => "80",
                CodeValueCode.VisitsSubjectToCoPayment => "81",
                CodeValueCode.DeductiblePayerA => "A1",
                CodeValueCode.CoinsurancePayerA => "A2",
                CodeValueCode.EstimatedResponsibilityPayerA => "A3",
                CodeValueCode.ServiceExcludedOnPrimaryPolicy => "X0",
                CodeValueCode.SupplementalCoverage => "X4",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeValueCode input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeValueType enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeValueType input)
        {
            return input switch
            {
                CodeValueType.Address => "AD",
                CodeValueType.CodedEntry => "CE",
                CodeValueType.CodedElementWithFormattedValues => "CF",
                CodeValueType.CompositeIdWithCheckDigit => "CK",
                CodeValueType.CompositeIdAndName => "CN",
                CodeValueType.CompositePrice => "CP",
                CodeValueType.ExtendedCompositeIdWithCheckDigit => "CX",
                CodeValueType.Date => "DT",
                CodeValueType.EncapsulatedData => "ED",
                CodeValueType.FormattedText => "FT",
                CodeValueType.CodedValueForHl7DefinedTables => "ID",
                CodeValueType.Money => "MO",
                CodeValueType.NameWithDateAndLocation => "NDL",
                CodeValueType.Numeric => "NM",
                CodeValueType.PersonName => "PN",
                CodeValueType.ReferencePointer => "RP",
                CodeValueType.StructuredNumeric => "SN",
                CodeValueType.StringData => "ST",
                CodeValueType.Time => "TM",
                CodeValueType.TelephoneNumber => "TN",
                CodeValueType.TimeStampDateAndTime => "TS",
                CodeValueType.TextData => "TX",
                CodeValueType.ExtendedAddress => "XAD",
                CodeValueType.ExtendedCompositeIdNumberAndNameForPersons => "XCN",
                CodeValueType.ExtendedCompositeNameAndIdNumberForOrganizations => "OXN",
                CodeValueType.ExtendedPersonName => "XPN",
                CodeValueType.ExtendedTelecommunicationsNumber => "XTN",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeValueType input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeVersionId enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeVersionId input)
        {
            return input switch
            {
                CodeVersionId.Release20 => "2.0",
                CodeVersionId.Demo20 => "2.0D",
                CodeVersionId.Release21 => "2.1",
                CodeVersionId.Release22 => "2.2",
                CodeVersionId.Release23 => "2.3",
                CodeVersionId.Release231 => "2.3.1",
                CodeVersionId.Release232 => "2.3.2",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeVersionId input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeVisitIndicator enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeVisitIndicator input)
        {
            return input switch
            {
                CodeVisitIndicator.AccountLevel => "A",
                CodeVisitIndicator.VisitLevel => "V",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeVisitIndicator input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeWhatSubjectFilter enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeWhatSubjectFilter input)
        {
            return input switch
            {
                CodeWhatSubjectFilter.AdviceDiagnosis => "ADV",
                CodeWhatSubjectFilter.NursingUnitLookupExcludingEmptyBeds => "ANU",
                CodeWhatSubjectFilter.AccountNumberQuery => "APA",
                CodeWhatSubjectFilter.MedicalRecordNumberQuery => "APM",
                CodeWhatSubjectFilter.PatientNameLookup => "APN",
                CodeWhatSubjectFilter.PhysicianLookup => "APP",
                CodeWhatSubjectFilter.NursingUnitLookupIncludingEmptyBeds => "ARN",
                CodeWhatSubjectFilter.Cancel => "CAN",
                CodeWhatSubjectFilter.Demographics => "DEM",
                CodeWhatSubjectFilter.Financial => "FIN",
                CodeWhatSubjectFilter.Goals => "GOL",
                CodeWhatSubjectFilter.MostRecentInpatient => "MRI",
                CodeWhatSubjectFilter.MostRecentOutpatient => "MRO",
                CodeWhatSubjectFilter.NetworkClock => "NCK",
                CodeWhatSubjectFilter.NetworkStatusChange => "NSC",
                CodeWhatSubjectFilter.NetworkStatistic => "NST",
                CodeWhatSubjectFilter.Order => "ORD",
                CodeWhatSubjectFilter.Other => "OTH",
                CodeWhatSubjectFilter.Problems => "PRB",
                CodeWhatSubjectFilter.Procedure => "PRO",
                CodeWhatSubjectFilter.PharmacyAdministrationInfo => "RAR",
                CodeWhatSubjectFilter.PharmacyDispenseInfo => "RDR",
                CodeWhatSubjectFilter.PharmacyEncodedOrderInfo => "RER",
                CodeWhatSubjectFilter.Result => "RES",
                CodeWhatSubjectFilter.PharmacyGiveInfo => "RGR",
                CodeWhatSubjectFilter.PharmacyPrescriptionInfo => "ROR",
                CodeWhatSubjectFilter.AllScheduleRelatedInfo => "SAL",
                CodeWhatSubjectFilter.BookedSlotsOnIdentifiedSchedule => "SBK",
                CodeWhatSubjectFilter.BlockedSlotsOnIdentifiedSchedule => "SBL",
                CodeWhatSubjectFilter.OpenSlotsOnIdentifiedSchedule => "SOP",
                CodeWhatSubjectFilter.TimeSlotsAvailableForSingleAppointment => "SSA",
                CodeWhatSubjectFilter.TimeSlotsAvailableForRecurringAppointment => "SSR",
                CodeWhatSubjectFilter.Status => "STA",
                CodeWhatSubjectFilter.VaccineInformation => "VXI",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeWhatSubjectFilter input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeWhichDateTimeQualifier enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeWhichDateTimeQualifier input)
        {
            return input switch
            {
                CodeWhichDateTimeQualifier.AnyDateTimeWithinRange => "ANY",
                CodeWhichDateTimeQualifier.CollectionDateTime => "COL",
                CodeWhichDateTimeQualifier.OrderDateTime => "ORD",
                CodeWhichDateTimeQualifier.SpecimenReceiptDateTime => "RCT",
                CodeWhichDateTimeQualifier.ReportDateTime => "REP",
                CodeWhichDateTimeQualifier.ScheduleDateTime => "SCHED",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeWhichDateTimeQualifier input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeWhichDateTimeStatusQualifier enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeWhichDateTimeStatusQualifier input)
        {
            return input switch
            {
                CodeWhichDateTimeStatusQualifier.AnyStatus => "ANY",
                CodeWhichDateTimeStatusQualifier.CurrentFinalValueWhetherFinalOrCorrected => "CFN",
                CodeWhichDateTimeStatusQualifier.CorrectedOnly => "COR",
                CodeWhichDateTimeStatusQualifier.FinalOnly => "FIN",
                CodeWhichDateTimeStatusQualifier.Preliminary => "PRE",
                CodeWhichDateTimeStatusQualifier.ReportCompletionDateTime => "REP",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeWhichDateTimeStatusQualifier input) => EnumToCode(input);

        /// <summary>
        /// Converts the given CodeYesNoIndicator enum value into its HL7 equivalent code.
        /// </summary>
        /// <param name="input">An enum value to convert.</param>
        /// <returns>A string.</returns>
        public static string EnumToCode(CodeYesNoIndicator input)
        {
            return input switch
            {
                CodeYesNoIndicator.No => "N",
                CodeYesNoIndicator.Yes => "Y",
                _ => throw new NotImplementedException()
            };
        }

        /// <inheritdoc/>
        string IEnumHelper.EnumToCode(CodeYesNoIndicator input) => EnumToCode(input);
    }
}
