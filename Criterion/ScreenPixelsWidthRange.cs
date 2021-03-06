using EPiServer.Personalization.VisitorGroups;

namespace FiftyOneDegrees.Criterion
{
    [VisitorGroupCriterion(
        Category = "51Degrees Criteria",
        Description = "Ranged - Refers to the width of the device's screen in pixels. If the device is a desktop or laptop then an 'Unknown' value can be returned. This property is not applicable for a device that does not have a screen. For devices such as tablets or TV which are predominantly used in landscape mode, the pixel width will be the larger value compared to the pixel height.",
        DisplayName = "Screen Pixels Width (Range)",
        ScriptUrl = "ClientResources/Criteria/RangeCriterion.js",
        LanguagePath = "")]

    public class ScreenPixelsWidthRange : RangeCriterionBase<Models.ScreenPixelsWidthRange>
    {
    }
}
