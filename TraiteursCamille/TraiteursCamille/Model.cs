using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraiteursCamille
{
   
    public class Model
    {
        public string NameOfTheTraiteur { get; set; }
        public string Dirigeant { get; set; }
        public string ContactCommercial { get; set; }
        public string Adress { get; set; }
        public string TelephoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public string Fax { get; set; }
    }

    public class Rootobject
    {
        public Anchorsmap anchorsMap { get; set; }
        public Browserdetection browserDetection { get; set; }
        public Cloneddataitemsidsmap clonedDataItemsIdsMap { get; set; }
        public string currentUrl { get; set; }
        public Displayedpagesdata displayedPagesData { get; set; }
        public Dynamicpages dynamicPages { get; set; }
        public Externalstyles externalStyles { get; set; }
        public Fixedpagesurls fixedPagesUrls { get; set; }
        public Landingpagenavigationinfo landingPageNavigationInfo { get; set; }
        public Mediarichtextinnercomponents mediaRichTextInnerComponents { get; set; }
        public string persistentCacheKiller { get; set; }
        public Ssrspecific ssrSpecific { get; set; }
        public Svgshapes svgShapes { get; set; }
        public Tpawidgenativeaspectwarmupdata tpaWidgeNativeAspectWarmupData { get; set; }
        public Userwarmup userWarmup { get; set; }
        public Wixapps wixapps { get; set; }
    }

    public class Anchorsmap
    {
    }

    public class Browserdetection
    {
        public Browser browser { get; set; }
        public Os os { get; set; }
    }

    public class Browser
    {
        public bool chrome { get; set; }
        public string version { get; set; }
        public bool webkit { get; set; }
    }

    public class Os
    {
        public bool googleBot { get; set; }
        public bool mac { get; set; }
        public bool phone { get; set; }
        public bool tablet { get; set; }
    }

    public class Cloneddataitemsidsmap
    {
        public CompJiq6e6e6 compjiq6e6e6 { get; set; }
        public CompJiq6e6g8 compjiq6e6g8 { get; set; }
    }

    public class CompJiq6e6e6
    {
        public string dataItemjiq6e6e63 { get; set; }
        public string dataItemjj6xth6p1 { get; set; }
    }

    public class CompJiq6e6g8
    {
        public string dataItemjiq6e6ga { get; set; }
        public string dataItemjj6xt5yt1 { get; set; }
    }

    public class Displayedpagesdata
    {
        public Ai3xt ai3xt { get; set; }
        public Masterpage masterPage { get; set; }
    }

    public class Ai3xt
    {
        public Data data { get; set; }
        public string pageUriSEO { get; set; }
        public Structure structure { get; set; }
        public string title { get; set; }
    }

    public class Data
    {
        public Behaviors_Data behaviors_data { get; set; }
        public Component_Properties component_properties { get; set; }
        public Connections_Data connections_data { get; set; }
        public Design_Data design_data { get; set; }
        public Document_Data document_data { get; set; }
        public Mobile_Hints mobile_hints { get; set; }
        public Theme_Data theme_data { get; set; }
    }

    public class Behaviors_Data
    {
        public BehaviorJjpi7j5h behaviorjjpi7j5h { get; set; }
    }

    public class BehaviorJjpi7j5h
    {
        public string id { get; set; }
        public string items { get; set; }
        public string type { get; set; }
    }

    public class Component_Properties
    {
        public Mobile_PropitemJiq6e6fi mobile_propItemjiq6e6fi { get; set; }
        public Mobile_PropitemJj6xehyn mobile_propItemjj6xehyn { get; set; }
        public Mobile_PropitemJj6xf09k1 mobile_propItemjj6xf09k1 { get; set; }
        public Mobile_PropitemJj6xgzuc mobile_propItemjj6xgzuc { get; set; }
        public Mobile_PropitemJj6xhdbs mobile_propItemjj6xhdbs { get; set; }
        public Mobile_PropitemJj6xybxr mobile_propItemjj6xybxr { get; set; }
        public Mobile_PropitemJj6xyuou mobile_propItemjj6xyuou { get; set; }
        public PropitemJiq6e6e2 propItemjiq6e6e2 { get; set; }
        public PropitemJiq6e6e61 propItemjiq6e6e61 { get; set; }
        public PropitemJiq6e6eq propItemjiq6e6eq { get; set; }
        public PropitemJiq6e6fi propItemjiq6e6fi { get; set; }
        public PropitemJiq6e6g9 propItemjiq6e6g9 { get; set; }
        public PropitemJiq6ev82 propItemjiq6ev82 { get; set; }
        public PropitemJj6xehyn propItemjj6xehyn { get; set; }
        public PropitemJj6xf09k1 propItemjj6xf09k1 { get; set; }
        public PropitemJj6xgzuc propItemjj6xgzuc { get; set; }
        public PropitemJj6xhdbs propItemjj6xhdbs { get; set; }
        public PropitemJj6xjv5c propItemjj6xjv5c { get; set; }
        public PropitemJj6xuyg41 propItemjj6xuyg41 { get; set; }
        public PropitemJj6xybxr propItemjj6xybxr { get; set; }
        public PropitemJj6xyuou propItemjj6xyuou { get; set; }
        public PropitemJj74jg97 propItemjj74jg97 { get; set; }
    }

    public class Mobile_PropitemJiq6e6fi
    {
        public int brightness { get; set; }
        public Metadata metaData { get; set; }
        public bool packed { get; set; }
        public string type { get; set; }
    }

    public class Metadata
    {
        public bool autoGenerated { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Mobile_PropitemJj6xehyn
    {
        public int brightness { get; set; }
        public Metadata1 metaData { get; set; }
        public bool packed { get; set; }
        public string type { get; set; }
    }

    public class Metadata1
    {
        public bool autoGenerated { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Mobile_PropitemJj6xf09k1
    {
        public int brightness { get; set; }
        public Metadata2 metaData { get; set; }
        public bool packed { get; set; }
        public string type { get; set; }
    }

    public class Metadata2
    {
        public bool autoGenerated { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Mobile_PropitemJj6xgzuc
    {
        public int brightness { get; set; }
        public Metadata3 metaData { get; set; }
        public bool packed { get; set; }
        public string type { get; set; }
    }

    public class Metadata3
    {
        public bool autoGenerated { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Mobile_PropitemJj6xhdbs
    {
        public int brightness { get; set; }
        public Metadata4 metaData { get; set; }
        public bool packed { get; set; }
        public string type { get; set; }
    }

    public class Metadata4
    {
        public bool autoGenerated { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Mobile_PropitemJj6xybxr
    {
        public int brightness { get; set; }
        public Metadata5 metaData { get; set; }
        public bool packed { get; set; }
        public string type { get; set; }
    }

    public class Metadata5
    {
        public bool autoGenerated { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Mobile_PropitemJj6xyuou
    {
        public int brightness { get; set; }
        public Metadata6 metaData { get; set; }
        public bool packed { get; set; }
        public string type { get; set; }
    }

    public class Metadata6
    {
        public bool autoGenerated { get; set; }
        public string schemaVersion { get; set; }
    }

    public class PropitemJiq6e6e2
    {
        public int columnsMargin { get; set; }
        public int frameMargin { get; set; }
        public bool fullWidth { get; set; }
        public Metadata7 metaData { get; set; }
        public int rowMargin { get; set; }
        public int siteMargin { get; set; }
        public string type { get; set; }
    }

    public class Metadata7
    {
        public string schemaVersion { get; set; }
    }

    public class PropitemJiq6e6e61
    {
        public int alignment { get; set; }
        public Metadata8 metaData { get; set; }
        public string type { get; set; }
    }

    public class Metadata8
    {
        public string schemaVersion { get; set; }
    }

    public class PropitemJiq6e6eq
    {
        public int alignment { get; set; }
        public Metadata9 metaData { get; set; }
        public string type { get; set; }
    }

    public class Metadata9
    {
        public string schemaVersion { get; set; }
    }

    public class PropitemJiq6e6fi
    {
        public int brightness { get; set; }
        public Metadata10 metaData { get; set; }
        public bool packed { get; set; }
        public string type { get; set; }
    }

    public class Metadata10
    {
        public string schemaVersion { get; set; }
    }

    public class PropitemJiq6e6g9
    {
        public int alignment { get; set; }
        public Metadata11 metaData { get; set; }
        public string type { get; set; }
    }

    public class Metadata11
    {
        public string schemaVersion { get; set; }
    }

    public class PropitemJiq6ev82
    {
        public Desktop desktop { get; set; }
        public Metadata12 metaData { get; set; }
        public string type { get; set; }
    }

    public class Desktop
    {
        public int minHeight { get; set; }
    }

    public class Metadata12
    {
        public bool autoGenerated { get; set; }
        public string schemaVersion { get; set; }
    }

    public class PropitemJj6xehyn
    {
        public int brightness { get; set; }
        public Metadata13 metaData { get; set; }
        public bool packed { get; set; }
        public string type { get; set; }
    }

    public class Metadata13
    {
        public string schemaVersion { get; set; }
    }

    public class PropitemJj6xf09k1
    {
        public int brightness { get; set; }
        public Metadata14 metaData { get; set; }
        public bool packed { get; set; }
        public string type { get; set; }
    }

    public class Metadata14
    {
        public string schemaVersion { get; set; }
    }

    public class PropitemJj6xgzuc
    {
        public int brightness { get; set; }
        public Metadata15 metaData { get; set; }
        public bool packed { get; set; }
        public string type { get; set; }
    }

    public class Metadata15
    {
        public string schemaVersion { get; set; }
    }

    public class PropitemJj6xhdbs
    {
        public int brightness { get; set; }
        public Metadata16 metaData { get; set; }
        public bool packed { get; set; }
        public string type { get; set; }
    }

    public class Metadata16
    {
        public string schemaVersion { get; set; }
    }

    public class PropitemJj6xjv5c
    {
        public string align { get; set; }
        public int margin { get; set; }
        public Metadata17 metaData { get; set; }
        public string type { get; set; }
    }

    public class Metadata17
    {
        public string schemaVersion { get; set; }
    }

    public class PropitemJj6xuyg41
    {
        public string align { get; set; }
        public int margin { get; set; }
        public Metadata18 metaData { get; set; }
        public string type { get; set; }
    }

    public class Metadata18
    {
        public string schemaVersion { get; set; }
    }

    public class PropitemJj6xybxr
    {
        public int brightness { get; set; }
        public Metadata19 metaData { get; set; }
        public bool packed { get; set; }
        public string type { get; set; }
    }

    public class Metadata19
    {
        public string schemaVersion { get; set; }
    }

    public class PropitemJj6xyuou
    {
        public int brightness { get; set; }
        public Metadata20 metaData { get; set; }
        public bool packed { get; set; }
        public string type { get; set; }
    }

    public class Metadata20
    {
        public string schemaVersion { get; set; }
    }

    public class PropitemJj74jg97
    {
        public string displayMode { get; set; }
        public Metadata21 metaData { get; set; }
        public string onClickBehavior { get; set; }
        public string type { get; set; }
    }

    public class Metadata21
    {
        public bool autoGenerated { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Connections_Data
    {
        public ConnectionJiq4yttm connectionjiq4yttm { get; set; }
        public ConnectionJiq4yu0b connectionjiq4yu0b { get; set; }
        public ConnectionJiq6e6eb connectionjiq6e6eb { get; set; }
        public ConnectionJiq6e6ej connectionjiq6e6ej { get; set; }
        public ConnectionJiq6e6f1 connectionjiq6e6f1 { get; set; }
        public ConnectionJiq6e6fo connectionjiq6e6fo { get; set; }
        public ConnectionJiq6e6gj connectionjiq6e6gj { get; set; }
        public ConnectionJj6xehys connectionjj6xehys { get; set; }
        public ConnectionJj6xf09o1 connectionjj6xf09o1 { get; set; }
        public ConnectionJj6xgzue connectionjj6xgzue { get; set; }
        public ConnectionJj6xhdbu1 connectionjj6xhdbu1 { get; set; }
        public ConnectionJj6xjv5i connectionjj6xjv5i { get; set; }
        public ConnectionJj6xuyg6 connectionjj6xuyg6 { get; set; }
        public ConnectionJj6xybxs connectionjj6xybxs { get; set; }
        public ConnectionJj6xyuov1 connectionjj6xyuov1 { get; set; }
        public ConnectionJj74jg9h connectionjj74jg9h { get; set; }
    }

    public class ConnectionJiq4yttm
    {
        public string id { get; set; }
        public Item[] items { get; set; }
        public string type { get; set; }
    }

    public class Item
    {
        public string role { get; set; }
        public string type { get; set; }
    }

    public class ConnectionJiq4yu0b
    {
        public string id { get; set; }
        public Item1[] items { get; set; }
        public string type { get; set; }
    }

    public class Item1
    {
        public string role { get; set; }
        public string type { get; set; }
    }

    public class ConnectionJiq6e6eb
    {
        public string id { get; set; }
        public Item2[] items { get; set; }
        public string type { get; set; }
    }

    public class Item2
    {
        public string role { get; set; }
        public string type { get; set; }
        public string config { get; set; }
        public string controllerId { get; set; }
        public bool isPrimary { get; set; }
    }

    public class ConnectionJiq6e6ej
    {
        public string id { get; set; }
        public Item3[] items { get; set; }
        public string type { get; set; }
    }

    public class Item3
    {
        public string role { get; set; }
        public string type { get; set; }
    }

    public class ConnectionJiq6e6f1
    {
        public string id { get; set; }
        public Item4[] items { get; set; }
        public string type { get; set; }
    }

    public class Item4
    {
        public string role { get; set; }
        public string type { get; set; }
    }

    public class ConnectionJiq6e6fo
    {
        public string id { get; set; }
        public Item5[] items { get; set; }
        public string type { get; set; }
    }

    public class Item5
    {
        public string role { get; set; }
        public string type { get; set; }
    }

    public class ConnectionJiq6e6gj
    {
        public string id { get; set; }
        public Item6[] items { get; set; }
        public string type { get; set; }
    }

    public class Item6
    {
        public string role { get; set; }
        public string type { get; set; }
        public string config { get; set; }
        public string controllerId { get; set; }
        public bool isPrimary { get; set; }
    }

    public class ConnectionJj6xehys
    {
        public string id { get; set; }
        public Item7[] items { get; set; }
        public string type { get; set; }
    }

    public class Item7
    {
        public string role { get; set; }
        public string type { get; set; }
    }

    public class ConnectionJj6xf09o1
    {
        public string id { get; set; }
        public Item8[] items { get; set; }
        public string type { get; set; }
    }

    public class Item8
    {
        public string role { get; set; }
        public string type { get; set; }
        public string config { get; set; }
        public string controllerId { get; set; }
        public bool isPrimary { get; set; }
    }

    public class ConnectionJj6xgzue
    {
        public string id { get; set; }
        public Item9[] items { get; set; }
        public string type { get; set; }
    }

    public class Item9
    {
        public string role { get; set; }
        public string type { get; set; }
        public string config { get; set; }
        public string controllerId { get; set; }
        public bool isPrimary { get; set; }
    }

    public class ConnectionJj6xhdbu1
    {
        public string id { get; set; }
        public Item10[] items { get; set; }
        public string type { get; set; }
    }

    public class Item10
    {
        public string role { get; set; }
        public string type { get; set; }
    }

    public class ConnectionJj6xjv5i
    {
        public string id { get; set; }
        public Item11[] items { get; set; }
        public string type { get; set; }
    }

    public class Item11
    {
        public string role { get; set; }
        public string type { get; set; }
        public string config { get; set; }
        public string controllerId { get; set; }
        public bool isPrimary { get; set; }
    }

    public class ConnectionJj6xuyg6
    {
        public string id { get; set; }
        public Item12[] items { get; set; }
        public string type { get; set; }
    }

    public class Item12
    {
        public string role { get; set; }
        public string type { get; set; }
    }

    public class ConnectionJj6xybxs
    {
        public string id { get; set; }
        public Item13[] items { get; set; }
        public string type { get; set; }
    }

    public class Item13
    {
        public string role { get; set; }
        public string type { get; set; }
        public string config { get; set; }
        public string controllerId { get; set; }
        public bool isPrimary { get; set; }
    }

    public class ConnectionJj6xyuov1
    {
        public string id { get; set; }
        public Item14[] items { get; set; }
        public string type { get; set; }
    }

    public class Item14
    {
        public string role { get; set; }
        public string type { get; set; }
        public string config { get; set; }
        public string controllerId { get; set; }
        public bool isPrimary { get; set; }
    }

    public class ConnectionJj74jg9h
    {
        public string id { get; set; }
        public Item15[] items { get; set; }
        public string type { get; set; }
    }

    public class Item15
    {
        public string role { get; set; }
        public string type { get; set; }
        public string config { get; set; }
        public string controllerId { get; set; }
        public bool isPrimary { get; set; }
    }

    public class Design_Data
    {
        public DataitemJiq6e6e21 dataItemjiq6e6e21 { get; set; }
        public DataitemJiq6e6e4 dataItemjiq6e6e4 { get; set; }
        public DataitemJiq6e6e62 dataItemjiq6e6e62 { get; set; }
        public DataitemJiq6e6e63 dataItemjiq6e6e63 { get; set; }
        public DataitemJiq6e6e63_Runtime_837 dataItemjiq6e6e63_runtime_837 { get; set; }
        public DataitemJiq6e6er dataItemjiq6e6er { get; set; }
        public DataitemJiq6e6er1 dataItemjiq6e6er1 { get; set; }
        public DataitemJiq6e6g91 dataItemjiq6e6g91 { get; set; }
        public DataitemJiq6e6ga dataItemjiq6e6ga { get; set; }
        public DataitemJiq6e6ga_Runtime_839 dataItemjiq6e6ga_runtime_839 { get; set; }
        public DataitemJj6xt5yt1 dataItemjj6xt5yt1 { get; set; }
        public DataitemJj6xt5yt1_Runtime_840 dataItemjj6xt5yt1_runtime_840 { get; set; }
        public DataitemJj6xth6p1 dataItemjj6xth6p1 { get; set; }
        public DataitemJj6xth6p1_Runtime_838 dataItemjj6xth6p1_runtime_838 { get; set; }
    }

    public class DataitemJiq6e6e21
    {
        public string background { get; set; }
        public string charas { get; set; }
        public string id { get; set; }
        public Metadata22 metaData { get; set; }
        public string type { get; set; }
    }

    public class Metadata22
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class DataitemJiq6e6e4
    {
        public string alignType { get; set; }
        public string color { get; set; }
        public int colorOpacity { get; set; }
        public string colorOverlay { get; set; }
        public int colorOverlayOpacity { get; set; }
        public string fittingType { get; set; }
        public string id { get; set; }
        public Metadata23 metaData { get; set; }
        public string scrollType { get; set; }
        public string type { get; set; }
    }

    public class Metadata23
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class DataitemJiq6e6e62
    {
        public string background { get; set; }
        public string charas { get; set; }
        public object[] dataChangeBehaviors { get; set; }
        public string id { get; set; }
        public Metadata24 metaData { get; set; }
        public string type { get; set; }
    }

    public class Metadata24
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class DataitemJiq6e6e63
    {
        public string alignType { get; set; }
        public string color { get; set; }
        public int colorOpacity { get; set; }
        public string colorOverlay { get; set; }
        public int colorOverlayOpacity { get; set; }
        public string fittingType { get; set; }
        public string id { get; set; }
        public string mediaRef { get; set; }
        public Metadata25 metaData { get; set; }
        public string scrollType { get; set; }
        public string showOverlayForMediaType { get; set; }
        public string type { get; set; }
    }

    public class Metadata25
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class DataitemJiq6e6e63_Runtime_837
    {
        public string alignType { get; set; }
        public string color { get; set; }
        public int colorOpacity { get; set; }
        public string colorOverlay { get; set; }
        public int colorOverlayOpacity { get; set; }
        public string fittingType { get; set; }
        public string id { get; set; }
        public string mediaRef { get; set; }
        public Metadata26 metaData { get; set; }
        public string scrollType { get; set; }
        public string showOverlayForMediaType { get; set; }
        public string type { get; set; }
    }

    public class Metadata26
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class DataitemJiq6e6er
    {
        public string background { get; set; }
        public string charas { get; set; }
        public object[] dataChangeBehaviors { get; set; }
        public string id { get; set; }
        public Metadata27 metaData { get; set; }
        public string type { get; set; }
    }

    public class Metadata27
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class DataitemJiq6e6er1
    {
        public string alignType { get; set; }
        public string color { get; set; }
        public int colorOpacity { get; set; }
        public string colorOverlay { get; set; }
        public int colorOverlayOpacity { get; set; }
        public string fittingType { get; set; }
        public string id { get; set; }
        public Metadata28 metaData { get; set; }
        public string scrollType { get; set; }
        public string showOverlayForMediaType { get; set; }
        public string type { get; set; }
    }

    public class Metadata28
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class DataitemJiq6e6g91
    {
        public string background { get; set; }
        public string charas { get; set; }
        public object[] dataChangeBehaviors { get; set; }
        public string id { get; set; }
        public Metadata29 metaData { get; set; }
        public string type { get; set; }
    }

    public class Metadata29
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class DataitemJiq6e6ga
    {
        public string alignType { get; set; }
        public string color { get; set; }
        public int colorOpacity { get; set; }
        public string colorOverlay { get; set; }
        public int colorOverlayOpacity { get; set; }
        public string fittingType { get; set; }
        public string id { get; set; }
        public string mediaRef { get; set; }
        public Metadata30 metaData { get; set; }
        public string scrollType { get; set; }
        public string showOverlayForMediaType { get; set; }
        public string type { get; set; }
    }

    public class Metadata30
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class DataitemJiq6e6ga_Runtime_839
    {
        public string alignType { get; set; }
        public string color { get; set; }
        public int colorOpacity { get; set; }
        public string colorOverlay { get; set; }
        public int colorOverlayOpacity { get; set; }
        public string fittingType { get; set; }
        public string id { get; set; }
        public string mediaRef { get; set; }
        public Metadata31 metaData { get; set; }
        public string scrollType { get; set; }
        public string showOverlayForMediaType { get; set; }
        public string type { get; set; }
    }

    public class Metadata31
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class DataitemJj6xt5yt1
    {
        public string alt { get; set; }
        public Artist artist { get; set; }
        public string description { get; set; }
        public int height { get; set; }
        public string id { get; set; }
        public Metadata32 metaData { get; set; }
        public string title { get; set; }
        public string type { get; set; }
        public string uri { get; set; }
        public int width { get; set; }
    }

    public class Artist
    {
        public string id { get; set; }
        public string name { get; set; }
    }

    public class Metadata32
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class DataitemJj6xt5yt1_Runtime_840
    {
        public int height { get; set; }
        public string id { get; set; }
        public string title { get; set; }
        public string type { get; set; }
        public string uri { get; set; }
        public int width { get; set; }
    }

    public class DataitemJj6xth6p1
    {
        public string alt { get; set; }
        public Artist1 artist { get; set; }
        public string description { get; set; }
        public int height { get; set; }
        public string id { get; set; }
        public Metadata33 metaData { get; set; }
        public string title { get; set; }
        public string type { get; set; }
        public string uri { get; set; }
        public int width { get; set; }
    }

    public class Artist1
    {
        public string id { get; set; }
        public string name { get; set; }
    }

    public class Metadata33
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class DataitemJj6xth6p1_Runtime_838
    {
        public int height { get; set; }
        public string id { get; set; }
        public string title { get; set; }
        public string type { get; set; }
        public string uri { get; set; }
        public int width { get; set; }
    }

    public class Document_Data
    {
        public Ai3xt_Desktop_Bg ai3xt_desktop_bg { get; set; }
        public Ai3xt_Mobile_Bg ai3xt_mobile_bg { get; set; }
        public DataitemJiq4yu0a dataItemjiq4yu0a { get; set; }
        public DataitemJiq6e6fh1 dataItemjiq6e6fh1 { get; set; }
        public DataitemJj6xehym dataItemjj6xehym { get; set; }
        public DataitemJj6xf09k dataItemjj6xf09k { get; set; }
        public DataitemJj6xgzub dataItemjj6xgzub { get; set; }
        public DataitemJj6xhdbr dataItemjj6xhdbr { get; set; }
        public DataitemJj6xjv59 dataItemjj6xjv59 { get; set; }
        public DataitemJj6xjv59_Link dataItemjj6xjv59_link { get; set; }
        public DataitemJj6xuyg3 dataItemjj6xuyg3 { get; set; }
        public DataitemJj6xybxq dataItemjj6xybxq { get; set; }
        public DataitemJj6xyuot dataItemjj6xyuot { get; set; }
        public DataitemJj74jg93 dataItemjj74jg93 { get; set; }
        public DataitemJj75pri8 dataItemjj75pri8 { get; set; }
        public Textlink_Jj6xffcu textLink_jj6xffcu { get; set; }
    }

    public class Ai3xt_Desktop_Bg
    {
        public string alignType { get; set; }
        public string color { get; set; }
        public string colorOverlay { get; set; }
        public int colorOverlayOpacity { get; set; }
        public string fittingType { get; set; }
        public string id { get; set; }
        public Metadata34 metaData { get; set; }
        public string scrollType { get; set; }
        public string type { get; set; }
    }

    public class Metadata34
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Ai3xt_Mobile_Bg
    {
        public string alignType { get; set; }
        public string color { get; set; }
        public string colorOverlay { get; set; }
        public int colorOverlayOpacity { get; set; }
        public string fittingType { get; set; }
        public string id { get; set; }
        public Metadata35 metaData { get; set; }
        public string scrollType { get; set; }
        public string type { get; set; }
    }

    public class Metadata35
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class DataitemJiq4yu0a
    {
        public string applicationId { get; set; }
        public string controllerType { get; set; }
        public string id { get; set; }
        public Metadata36 metaData { get; set; }
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Metadata36
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class DataitemJiq6e6fh1
    {
        public string id { get; set; }
        public object[] linkList { get; set; }
        public Metadata37 metaData { get; set; }
        public string stylesMapId { get; set; }
        public string text { get; set; }
        public string type { get; set; }
    }

    public class Metadata37
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class DataitemJj6xehym
    {
        public string id { get; set; }
        public object[] linkList { get; set; }
        public Metadata38 metaData { get; set; }
        public string stylesMapId { get; set; }
        public string text { get; set; }
        public string type { get; set; }
    }

    public class Metadata38
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class DataitemJj6xf09k
    {
        public string id { get; set; }
        public object[] linkList { get; set; }
        public Metadata39 metaData { get; set; }
        public string stylesMapId { get; set; }
        public string text { get; set; }
        public string type { get; set; }
    }

    public class Metadata39
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class DataitemJj6xgzub
    {
        public string id { get; set; }
        public object[] linkList { get; set; }
        public Metadata40 metaData { get; set; }
        public string stylesMapId { get; set; }
        public string text { get; set; }
        public string type { get; set; }
    }

    public class Metadata40
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class DataitemJj6xhdbr
    {
        public string id { get; set; }
        public object[] linkList { get; set; }
        public Metadata41 metaData { get; set; }
        public string stylesMapId { get; set; }
        public string text { get; set; }
        public string type { get; set; }
    }

    public class Metadata41
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class DataitemJj6xjv59
    {
        public string id { get; set; }
        public string label { get; set; }
        public string link { get; set; }
        public Metadata42 metaData { get; set; }
        public string type { get; set; }
    }

    public class Metadata42
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class DataitemJj6xjv59_Link
    {
        public string id { get; set; }
        public string target { get; set; }
        public string type { get; set; }
        public string url { get; set; }
    }

    public class DataitemJj6xuyg3
    {
        public string id { get; set; }
        public string label { get; set; }
        public string link { get; set; }
        public Metadata43 metaData { get; set; }
        public string type { get; set; }
    }

    public class Metadata43
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class DataitemJj6xybxq
    {
        public string id { get; set; }
        public object[] linkList { get; set; }
        public Metadata44 metaData { get; set; }
        public string stylesMapId { get; set; }
        public string text { get; set; }
        public string type { get; set; }
    }

    public class Metadata44
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class DataitemJj6xyuot
    {
        public string id { get; set; }
        public object[] linkList { get; set; }
        public Metadata45 metaData { get; set; }
        public string stylesMapId { get; set; }
        public string text { get; set; }
        public string type { get; set; }
    }

    public class Metadata45
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class DataitemJj74jg93
    {
        public string alt { get; set; }
        public object crop { get; set; }
        public string description { get; set; }
        public int height { get; set; }
        public string id { get; set; }
        public Metadata46 metaData { get; set; }
        public string title { get; set; }
        public string type { get; set; }
        public string uri { get; set; }
        public int width { get; set; }
    }

    public class Metadata46
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class DataitemJj75pri8
    {
        public string id { get; set; }
        public Metadata47 metaData { get; set; }
        public string pageId { get; set; }
        public string target { get; set; }
        public string type { get; set; }
    }

    public class Metadata47
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Textlink_Jj6xffcu
    {
        public string id { get; set; }
        public Metadata48 metaData { get; set; }
        public string recipient { get; set; }
        public string subject { get; set; }
        public string type { get; set; }
    }

    public class Metadata48
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Mobile_Hints
    {
        public MobilehintsJiq4yttt mobileHintsjiq4yttt { get; set; }
        public MobilehintsJiq6e6h0 mobileHintsjiq6e6h0 { get; set; }
        public MobilehintsJiq6e6h01 mobileHintsjiq6e6h01 { get; set; }
        public MobilehintsJiq6e6h1 mobileHintsjiq6e6h1 { get; set; }
        public MobilehintsJiq6e6h31 mobileHintsjiq6e6h31 { get; set; }
        public MobilehintsJiq6e6h6 mobileHintsjiq6e6h6 { get; set; }
        public MobilehintsJj6xehyr mobileHintsjj6xehyr { get; set; }
        public MobilehintsJj6xf09o mobileHintsjj6xf09o { get; set; }
        public MobilehintsJj6xgzud mobileHintsjj6xgzud { get; set; }
        public MobilehintsJj6xhdbu mobileHintsjj6xhdbu { get; set; }
        public MobilehintsJj6xybxr1 mobileHintsjj6xybxr1 { get; set; }
        public MobilehintsJj6xyuov mobileHintsjj6xyuov { get; set; }
    }

    public class MobilehintsJiq4yttt
    {
        public bool hidden { get; set; }
        public string id { get; set; }
        public string type { get; set; }
    }

    public class MobilehintsJiq6e6h0
    {
        public string author { get; set; }
        public string id { get; set; }
        public string offsetOrigin { get; set; }
        public int offsetX { get; set; }
        public int offsetY { get; set; }
        public int orderIndex { get; set; }
        public int recommendedScale { get; set; }
        public int recommendedWidth { get; set; }
        public string type { get; set; }
    }

    public class MobilehintsJiq6e6h01
    {
        public string author { get; set; }
        public string id { get; set; }
        public string offsetOrigin { get; set; }
        public int offsetX { get; set; }
        public int offsetY { get; set; }
        public int orderIndex { get; set; }
        public int recommendedScale { get; set; }
        public int recommendedWidth { get; set; }
        public string type { get; set; }
    }

    public class MobilehintsJiq6e6h1
    {
        public string author { get; set; }
        public string id { get; set; }
        public string offsetOrigin { get; set; }
        public int offsetX { get; set; }
        public int offsetY { get; set; }
        public int orderIndex { get; set; }
        public int recommendedHeight { get; set; }
        public int recommendedScale { get; set; }
        public int recommendedWidth { get; set; }
        public string type { get; set; }
    }

    public class MobilehintsJiq6e6h31
    {
        public string author { get; set; }
        public string id { get; set; }
        public int recommendedHeight { get; set; }
        public float recommendedScale { get; set; }
        public int recommendedWidth { get; set; }
        public string type { get; set; }
    }

    public class MobilehintsJiq6e6h6
    {
        public string author { get; set; }
        public string id { get; set; }
        public int recommendedScale { get; set; }
        public int recommendedWidth { get; set; }
        public string type { get; set; }
    }

    public class MobilehintsJj6xehyr
    {
        public string author { get; set; }
        public string id { get; set; }
        public int recommendedHeight { get; set; }
        public float recommendedScale { get; set; }
        public int recommendedWidth { get; set; }
        public string type { get; set; }
    }

    public class MobilehintsJj6xf09o
    {
        public string author { get; set; }
        public string id { get; set; }
        public int recommendedHeight { get; set; }
        public float recommendedScale { get; set; }
        public int recommendedWidth { get; set; }
        public string type { get; set; }
    }

    public class MobilehintsJj6xgzud
    {
        public string author { get; set; }
        public string id { get; set; }
        public int recommendedHeight { get; set; }
        public float recommendedScale { get; set; }
        public int recommendedWidth { get; set; }
        public string type { get; set; }
    }

    public class MobilehintsJj6xhdbu
    {
        public string author { get; set; }
        public string id { get; set; }
        public int recommendedHeight { get; set; }
        public float recommendedScale { get; set; }
        public int recommendedWidth { get; set; }
        public string type { get; set; }
    }

    public class MobilehintsJj6xybxr1
    {
        public string author { get; set; }
        public string id { get; set; }
        public int recommendedHeight { get; set; }
        public float recommendedScale { get; set; }
        public int recommendedWidth { get; set; }
        public string type { get; set; }
    }

    public class MobilehintsJj6xyuov
    {
        public string author { get; set; }
        public string id { get; set; }
        public int recommendedHeight { get; set; }
        public float recommendedScale { get; set; }
        public int recommendedWidth { get; set; }
        public string type { get; set; }
    }

    public class Theme_Data
    {
    }

    public class Structure
    {
        public DESKTOP1 DESKTOP { get; set; }
        public MOBILE MOBILE { get; set; }
    }

    public class DESKTOP1
    {
        public Ai3xt1 ai3xt { get; set; }
        public CompJiq4ytzc compjiq4ytzc { get; set; }
        public CompJiq6e6dl compjiq6e6dl { get; set; }
        public CompJiq6e6e61 compjiq6e6e6 { get; set; }
        public CompJiq6e6eo compjiq6e6eo { get; set; }
        public CompJiq6e6fh compjiq6e6fh { get; set; }
        public CompJiq6e6g81 compjiq6e6g8 { get; set; }
        public CompJj6xehwb compjj6xehwb { get; set; }
        public CompJj6xf07r compjj6xf07r { get; set; }
        public CompJj6xgzsd compjj6xgzsd { get; set; }
        public CompJj6xhd9y compjj6xhd9y { get; set; }
        public CompJj6xjv40 compjj6xjv40 { get; set; }
        public CompJj6xuyed compjj6xuyed { get; set; }
        public CompJj6xybvu compjj6xybvu { get; set; }
        public CompJj6xyumv compjj6xyumv { get; set; }
        public CompJj74jg7l compjj74jg7l { get; set; }
    }

    public class Ai3xt1
    {
        public string componentType { get; set; }
        public string[] components { get; set; }
        public string connectionQuery { get; set; }
        public string dataQuery { get; set; }
        public string id { get; set; }
        public Layout layout { get; set; }
        public string mobileHintsQuery { get; set; }
        public string propertyQuery { get; set; }
        public string skin { get; set; }
        public string styleId { get; set; }
        public string type { get; set; }
    }

    public class Layout
    {
        public bool fixedPosition { get; set; }
        public int height { get; set; }
        public int rotationInDegrees { get; set; }
        public int scale { get; set; }
        public int width { get; set; }
        public int x { get; set; }
        public int y { get; set; }
    }

    public class CompJiq4ytzc
    {
        public string componentType { get; set; }
        public string connectionQuery { get; set; }
        public string dataQuery { get; set; }
        public string id { get; set; }
        public Layout1 layout { get; set; }
        public string parent { get; set; }
        public string styleId { get; set; }
        public string type { get; set; }
    }

    public class Layout1
    {
        public bool fixedPosition { get; set; }
        public int height { get; set; }
        public int rotationInDegrees { get; set; }
        public int scale { get; set; }
        public int width { get; set; }
        public int x { get; set; }
        public int y { get; set; }
    }

    public class CompJiq6e6dl
    {
        public string componentType { get; set; }
        public string[] components { get; set; }
        public string connectionQuery { get; set; }
        public string designQuery { get; set; }
        public string id { get; set; }
        public Layout2 layout { get; set; }
        public string mobileHintsQuery { get; set; }
        public string parent { get; set; }
        public string propertyQuery { get; set; }
        public string styleId { get; set; }
        public string type { get; set; }
    }

    public class Layout2
    {
        public bool fixedPosition { get; set; }
        public int height { get; set; }
        public int rotationInDegrees { get; set; }
        public int scale { get; set; }
        public int width { get; set; }
        public int x { get; set; }
        public int y { get; set; }
    }

    public class CompJiq6e6e61
    {
        public string componentType { get; set; }
        public object[] components { get; set; }
        public string connectionQuery { get; set; }
        public string designQuery { get; set; }
        public string id { get; set; }
        public Layout3 layout { get; set; }
        public string mobileHintsQuery { get; set; }
        public string parent { get; set; }
        public string propertyQuery { get; set; }
        public string styleId { get; set; }
        public string type { get; set; }
    }

    public class Layout3
    {
        public bool fixedPosition { get; set; }
        public int height { get; set; }
        public int rotationInDegrees { get; set; }
        public int scale { get; set; }
        public int width { get; set; }
        public int x { get; set; }
        public int y { get; set; }
    }

    public class CompJiq6e6eo
    {
        public string componentType { get; set; }
        public string[] components { get; set; }
        public string connectionQuery { get; set; }
        public string designQuery { get; set; }
        public string id { get; set; }
        public Layout4 layout { get; set; }
        public string mobileHintsQuery { get; set; }
        public string parent { get; set; }
        public string propertyQuery { get; set; }
        public string styleId { get; set; }
        public string type { get; set; }
    }

    public class Layout4
    {
        public bool fixedPosition { get; set; }
        public int height { get; set; }
        public int rotationInDegrees { get; set; }
        public int scale { get; set; }
        public int width { get; set; }
        public int x { get; set; }
        public int y { get; set; }
    }

    public class CompJiq6e6fh
    {
        public string componentType { get; set; }
        public string connectionQuery { get; set; }
        public string dataQuery { get; set; }
        public string id { get; set; }
        public Layout5 layout { get; set; }
        public string mobileHintsQuery { get; set; }
        public string parent { get; set; }
        public string propertyQuery { get; set; }
        public string skin { get; set; }
        public string styleId { get; set; }
        public string type { get; set; }
    }

    public class Layout5
    {
        public bool fixedPosition { get; set; }
        public int height { get; set; }
        public int rotationInDegrees { get; set; }
        public int scale { get; set; }
        public int width { get; set; }
        public int x { get; set; }
        public int y { get; set; }
    }

    public class CompJiq6e6g81
    {
        public string componentType { get; set; }
        public object[] components { get; set; }
        public string connectionQuery { get; set; }
        public string designQuery { get; set; }
        public string id { get; set; }
        public Layout6 layout { get; set; }
        public string mobileHintsQuery { get; set; }
        public string parent { get; set; }
        public string propertyQuery { get; set; }
        public string styleId { get; set; }
        public string type { get; set; }
    }

    public class Layout6
    {
        public bool fixedPosition { get; set; }
        public int height { get; set; }
        public int rotationInDegrees { get; set; }
        public int scale { get; set; }
        public int width { get; set; }
        public int x { get; set; }
        public int y { get; set; }
    }

    public class CompJj6xehwb
    {
        public string componentType { get; set; }
        public string connectionQuery { get; set; }
        public string dataQuery { get; set; }
        public string id { get; set; }
        public Layout7 layout { get; set; }
        public string mobileHintsQuery { get; set; }
        public string parent { get; set; }
        public string propertyQuery { get; set; }
        public string skin { get; set; }
        public string styleId { get; set; }
        public string type { get; set; }
    }

    public class Layout7
    {
        public bool fixedPosition { get; set; }
        public int height { get; set; }
        public int rotationInDegrees { get; set; }
        public int scale { get; set; }
        public int width { get; set; }
        public int x { get; set; }
        public int y { get; set; }
    }

    public class CompJj6xf07r
    {
        public string componentType { get; set; }
        public string connectionQuery { get; set; }
        public string dataQuery { get; set; }
        public string id { get; set; }
        public Layout8 layout { get; set; }
        public string mobileHintsQuery { get; set; }
        public string parent { get; set; }
        public string propertyQuery { get; set; }
        public string skin { get; set; }
        public string styleId { get; set; }
        public string type { get; set; }
    }

    public class Layout8
    {
        public bool fixedPosition { get; set; }
        public int height { get; set; }
        public int rotationInDegrees { get; set; }
        public int scale { get; set; }
        public int width { get; set; }
        public int x { get; set; }
        public int y { get; set; }
    }

    public class CompJj6xgzsd
    {
        public string componentType { get; set; }
        public string connectionQuery { get; set; }
        public string dataQuery { get; set; }
        public string id { get; set; }
        public Layout9 layout { get; set; }
        public string mobileHintsQuery { get; set; }
        public string parent { get; set; }
        public string propertyQuery { get; set; }
        public string skin { get; set; }
        public string styleId { get; set; }
        public string type { get; set; }
    }

    public class Layout9
    {
        public bool fixedPosition { get; set; }
        public int height { get; set; }
        public int rotationInDegrees { get; set; }
        public int scale { get; set; }
        public int width { get; set; }
        public int x { get; set; }
        public int y { get; set; }
    }

    public class CompJj6xhd9y
    {
        public string componentType { get; set; }
        public string connectionQuery { get; set; }
        public string dataQuery { get; set; }
        public string id { get; set; }
        public Layout10 layout { get; set; }
        public string mobileHintsQuery { get; set; }
        public string parent { get; set; }
        public string propertyQuery { get; set; }
        public string skin { get; set; }
        public string styleId { get; set; }
        public string type { get; set; }
    }

    public class Layout10
    {
        public bool fixedPosition { get; set; }
        public int height { get; set; }
        public int rotationInDegrees { get; set; }
        public int scale { get; set; }
        public int width { get; set; }
        public int x { get; set; }
        public int y { get; set; }
    }

    public class CompJj6xjv40
    {
        public string behaviorQuery { get; set; }
        public string componentType { get; set; }
        public string connectionQuery { get; set; }
        public string dataQuery { get; set; }
        public string id { get; set; }
        public Layout11 layout { get; set; }
        public string mobileHintsQuery { get; set; }
        public string parent { get; set; }
        public string propertyQuery { get; set; }
        public string skin { get; set; }
        public string styleId { get; set; }
        public string type { get; set; }
    }

    public class Layout11
    {
        public bool fixedPosition { get; set; }
        public int height { get; set; }
        public int rotationInDegrees { get; set; }
        public int scale { get; set; }
        public int width { get; set; }
        public int x { get; set; }
        public int y { get; set; }
    }

    public class CompJj6xuyed
    {
        public string componentType { get; set; }
        public string connectionQuery { get; set; }
        public string dataQuery { get; set; }
        public string id { get; set; }
        public Layout12 layout { get; set; }
        public string mobileHintsQuery { get; set; }
        public string parent { get; set; }
        public string propertyQuery { get; set; }
        public string skin { get; set; }
        public string styleId { get; set; }
        public string type { get; set; }
    }

    public class Layout12
    {
        public bool fixedPosition { get; set; }
        public int height { get; set; }
        public int rotationInDegrees { get; set; }
        public int scale { get; set; }
        public int width { get; set; }
        public int x { get; set; }
        public int y { get; set; }
    }

    public class CompJj6xybvu
    {
        public string componentType { get; set; }
        public string connectionQuery { get; set; }
        public string dataQuery { get; set; }
        public string id { get; set; }
        public Layout13 layout { get; set; }
        public string mobileHintsQuery { get; set; }
        public string parent { get; set; }
        public string propertyQuery { get; set; }
        public string skin { get; set; }
        public string styleId { get; set; }
        public string type { get; set; }
    }

    public class Layout13
    {
        public bool fixedPosition { get; set; }
        public int height { get; set; }
        public int rotationInDegrees { get; set; }
        public int scale { get; set; }
        public int width { get; set; }
        public int x { get; set; }
        public int y { get; set; }
    }

    public class CompJj6xyumv
    {
        public string componentType { get; set; }
        public string connectionQuery { get; set; }
        public string dataQuery { get; set; }
        public string id { get; set; }
        public Layout14 layout { get; set; }
        public string mobileHintsQuery { get; set; }
        public string parent { get; set; }
        public string propertyQuery { get; set; }
        public string skin { get; set; }
        public string styleId { get; set; }
        public string type { get; set; }
    }

    public class Layout14
    {
        public bool fixedPosition { get; set; }
        public int height { get; set; }
        public int rotationInDegrees { get; set; }
        public int scale { get; set; }
        public int width { get; set; }
        public int x { get; set; }
        public int y { get; set; }
    }

    public class CompJj74jg7l
    {
        public string componentType { get; set; }
        public string connectionQuery { get; set; }
        public string dataQuery { get; set; }
        public string id { get; set; }
        public Layout15 layout { get; set; }
        public string parent { get; set; }
        public string propertyQuery { get; set; }
        public string skin { get; set; }
        public string styleId { get; set; }
        public string type { get; set; }
    }

    public class Layout15
    {
        public bool fixedPosition { get; set; }
        public int height { get; set; }
        public int rotationInDegrees { get; set; }
        public int scale { get; set; }
        public int width { get; set; }
        public int x { get; set; }
        public int y { get; set; }
    }

    public class MOBILE
    {
        public Ai3xt2 ai3xt { get; set; }
        public CompJiq4ytzc1 compjiq4ytzc { get; set; }
        public CompJiq6e6dl1 compjiq6e6dl { get; set; }
        public CompJiq6e6e62 compjiq6e6e6 { get; set; }
        public CompJiq6e6eo1 compjiq6e6eo { get; set; }
        public CompJiq6e6fh1 compjiq6e6fh { get; set; }
        public CompJiq6e6g82 compjiq6e6g8 { get; set; }
        public CompJj6xehwb1 compjj6xehwb { get; set; }
        public CompJj6xf07r1 compjj6xf07r { get; set; }
        public CompJj6xgzsd1 compjj6xgzsd { get; set; }
        public CompJj6xhd9y1 compjj6xhd9y { get; set; }
        public CompJj6xjv401 compjj6xjv40 { get; set; }
        public CompJj6xuyed1 compjj6xuyed { get; set; }
        public CompJj6xybvu1 compjj6xybvu { get; set; }
        public CompJj6xyumv1 compjj6xyumv { get; set; }
        public CompJj74jg7l1 compjj74jg7l { get; set; }
    }

    public class Ai3xt2
    {
        public string componentType { get; set; }
        public string[] components { get; set; }
        public string connectionQuery { get; set; }
        public string dataQuery { get; set; }
        public string id { get; set; }
        public Layout16 layout { get; set; }
        public string mobileHintsQuery { get; set; }
        public string propertyQuery { get; set; }
        public string skin { get; set; }
        public string styleId { get; set; }
        public string type { get; set; }
    }

    public class Layout16
    {
        public bool fixedPosition { get; set; }
        public int height { get; set; }
        public int rotationInDegrees { get; set; }
        public int scale { get; set; }
        public int width { get; set; }
        public int x { get; set; }
        public int y { get; set; }
    }

    public class CompJiq4ytzc1
    {
        public string componentType { get; set; }
        public string connectionQuery { get; set; }
        public string dataQuery { get; set; }
        public string id { get; set; }
        public Layout17 layout { get; set; }
        public string parent { get; set; }
        public string styleId { get; set; }
        public string type { get; set; }
    }

    public class Layout17
    {
        public bool fixedPosition { get; set; }
        public int height { get; set; }
        public int rotationInDegrees { get; set; }
        public int scale { get; set; }
        public int width { get; set; }
        public int x { get; set; }
        public int y { get; set; }
    }

    public class CompJiq6e6dl1
    {
        public string componentType { get; set; }
        public string[] components { get; set; }
        public string connectionQuery { get; set; }
        public string designQuery { get; set; }
        public string id { get; set; }
        public Layout18 layout { get; set; }
        public string mobileHintsQuery { get; set; }
        public string parent { get; set; }
        public string propertyQuery { get; set; }
        public string styleId { get; set; }
        public string type { get; set; }
    }

    public class Layout18
    {
        public bool fixedPosition { get; set; }
        public int height { get; set; }
        public int rotationInDegrees { get; set; }
        public int scale { get; set; }
        public int width { get; set; }
        public int x { get; set; }
        public int y { get; set; }
    }

    public class CompJiq6e6e62
    {
        public string componentType { get; set; }
        public object[] components { get; set; }
        public string connectionQuery { get; set; }
        public string designQuery { get; set; }
        public string id { get; set; }
        public Layout19 layout { get; set; }
        public string mobileHintsQuery { get; set; }
        public string parent { get; set; }
        public string propertyQuery { get; set; }
        public string styleId { get; set; }
        public string type { get; set; }
    }

    public class Layout19
    {
        public bool fixedPosition { get; set; }
        public int height { get; set; }
        public int rotationInDegrees { get; set; }
        public int scale { get; set; }
        public int width { get; set; }
        public int x { get; set; }
        public int y { get; set; }
    }

    public class CompJiq6e6eo1
    {
        public string componentType { get; set; }
        public string[] components { get; set; }
        public string connectionQuery { get; set; }
        public string designQuery { get; set; }
        public string id { get; set; }
        public Layout20 layout { get; set; }
        public string mobileHintsQuery { get; set; }
        public string parent { get; set; }
        public string propertyQuery { get; set; }
        public string styleId { get; set; }
        public string type { get; set; }
    }

    public class Layout20
    {
        public bool fixedPosition { get; set; }
        public int height { get; set; }
        public int rotationInDegrees { get; set; }
        public int scale { get; set; }
        public int width { get; set; }
        public int x { get; set; }
        public int y { get; set; }
    }

    public class CompJiq6e6fh1
    {
        public string componentType { get; set; }
        public string connectionQuery { get; set; }
        public string dataQuery { get; set; }
        public string id { get; set; }
        public Layout21 layout { get; set; }
        public string mobileHintsQuery { get; set; }
        public string parent { get; set; }
        public string propertyQuery { get; set; }
        public string skin { get; set; }
        public string styleId { get; set; }
        public string type { get; set; }
    }

    public class Layout21
    {
        public bool fixedPosition { get; set; }
        public int height { get; set; }
        public int rotationInDegrees { get; set; }
        public float scale { get; set; }
        public int width { get; set; }
        public int x { get; set; }
        public int y { get; set; }
    }

    public class CompJiq6e6g82
    {
        public string componentType { get; set; }
        public object[] components { get; set; }
        public string connectionQuery { get; set; }
        public string designQuery { get; set; }
        public string id { get; set; }
        public Layout22 layout { get; set; }
        public string mobileHintsQuery { get; set; }
        public string parent { get; set; }
        public string propertyQuery { get; set; }
        public string styleId { get; set; }
        public string type { get; set; }
    }

    public class Layout22
    {
        public bool fixedPosition { get; set; }
        public int height { get; set; }
        public int rotationInDegrees { get; set; }
        public int scale { get; set; }
        public int width { get; set; }
        public int x { get; set; }
        public int y { get; set; }
    }

    public class CompJj6xehwb1
    {
        public string componentType { get; set; }
        public string connectionQuery { get; set; }
        public string dataQuery { get; set; }
        public string id { get; set; }
        public Layout23 layout { get; set; }
        public string mobileHintsQuery { get; set; }
        public string parent { get; set; }
        public string propertyQuery { get; set; }
        public string skin { get; set; }
        public string styleId { get; set; }
        public string type { get; set; }
    }

    public class Layout23
    {
        public bool fixedPosition { get; set; }
        public int height { get; set; }
        public int rotationInDegrees { get; set; }
        public float scale { get; set; }
        public int width { get; set; }
        public int x { get; set; }
        public int y { get; set; }
    }

    public class CompJj6xf07r1
    {
        public string componentType { get; set; }
        public string connectionQuery { get; set; }
        public string dataQuery { get; set; }
        public string id { get; set; }
        public Layout24 layout { get; set; }
        public string mobileHintsQuery { get; set; }
        public string parent { get; set; }
        public string propertyQuery { get; set; }
        public string skin { get; set; }
        public string styleId { get; set; }
        public string type { get; set; }
    }

    public class Layout24
    {
        public bool fixedPosition { get; set; }
        public int height { get; set; }
        public int rotationInDegrees { get; set; }
        public float scale { get; set; }
        public int width { get; set; }
        public int x { get; set; }
        public int y { get; set; }
    }

    public class CompJj6xgzsd1
    {
        public string componentType { get; set; }
        public string connectionQuery { get; set; }
        public string dataQuery { get; set; }
        public string id { get; set; }
        public Layout25 layout { get; set; }
        public string mobileHintsQuery { get; set; }
        public string parent { get; set; }
        public string propertyQuery { get; set; }
        public string skin { get; set; }
        public string styleId { get; set; }
        public string type { get; set; }
    }

    public class Layout25
    {
        public bool fixedPosition { get; set; }
        public int height { get; set; }
        public int rotationInDegrees { get; set; }
        public float scale { get; set; }
        public int width { get; set; }
        public int x { get; set; }
        public int y { get; set; }
    }

    public class CompJj6xhd9y1
    {
        public string componentType { get; set; }
        public string connectionQuery { get; set; }
        public string dataQuery { get; set; }
        public string id { get; set; }
        public Layout26 layout { get; set; }
        public string mobileHintsQuery { get; set; }
        public string parent { get; set; }
        public string propertyQuery { get; set; }
        public string skin { get; set; }
        public string styleId { get; set; }
        public string type { get; set; }
    }

    public class Layout26
    {
        public bool fixedPosition { get; set; }
        public int height { get; set; }
        public int rotationInDegrees { get; set; }
        public float scale { get; set; }
        public int width { get; set; }
        public int x { get; set; }
        public int y { get; set; }
    }

    public class CompJj6xjv401
    {
        public string behaviorQuery { get; set; }
        public string componentType { get; set; }
        public string connectionQuery { get; set; }
        public string dataQuery { get; set; }
        public string id { get; set; }
        public Layout27 layout { get; set; }
        public string mobileHintsQuery { get; set; }
        public string parent { get; set; }
        public string propertyQuery { get; set; }
        public string styleId { get; set; }
        public string type { get; set; }
    }

    public class Layout27
    {
        public bool fixedPosition { get; set; }
        public int height { get; set; }
        public int rotationInDegrees { get; set; }
        public float scale { get; set; }
        public int width { get; set; }
        public int x { get; set; }
        public int y { get; set; }
    }

    public class CompJj6xuyed1
    {
        public string componentType { get; set; }
        public string connectionQuery { get; set; }
        public string dataQuery { get; set; }
        public string id { get; set; }
        public Layout28 layout { get; set; }
        public string mobileHintsQuery { get; set; }
        public string parent { get; set; }
        public string propertyQuery { get; set; }
        public string styleId { get; set; }
        public string type { get; set; }
    }

    public class Layout28
    {
        public bool fixedPosition { get; set; }
        public int height { get; set; }
        public int rotationInDegrees { get; set; }
        public float scale { get; set; }
        public int width { get; set; }
        public int x { get; set; }
        public int y { get; set; }
    }

    public class CompJj6xybvu1
    {
        public string componentType { get; set; }
        public string connectionQuery { get; set; }
        public string dataQuery { get; set; }
        public string id { get; set; }
        public Layout29 layout { get; set; }
        public string mobileHintsQuery { get; set; }
        public string parent { get; set; }
        public string propertyQuery { get; set; }
        public string skin { get; set; }
        public string styleId { get; set; }
        public string type { get; set; }
    }

    public class Layout29
    {
        public bool fixedPosition { get; set; }
        public int height { get; set; }
        public int rotationInDegrees { get; set; }
        public float scale { get; set; }
        public int width { get; set; }
        public int x { get; set; }
        public int y { get; set; }
    }

    public class CompJj6xyumv1
    {
        public string componentType { get; set; }
        public string connectionQuery { get; set; }
        public string dataQuery { get; set; }
        public string id { get; set; }
        public Layout30 layout { get; set; }
        public string mobileHintsQuery { get; set; }
        public string parent { get; set; }
        public string propertyQuery { get; set; }
        public string skin { get; set; }
        public string styleId { get; set; }
        public string type { get; set; }
    }

    public class Layout30
    {
        public bool fixedPosition { get; set; }
        public int height { get; set; }
        public int rotationInDegrees { get; set; }
        public float scale { get; set; }
        public int width { get; set; }
        public int x { get; set; }
        public int y { get; set; }
    }

    public class CompJj74jg7l1
    {
        public string componentType { get; set; }
        public string connectionQuery { get; set; }
        public string dataQuery { get; set; }
        public string id { get; set; }
        public Layout31 layout { get; set; }
        public string parent { get; set; }
        public string propertyQuery { get; set; }
        public string styleId { get; set; }
        public string type { get; set; }
    }

    public class Layout31
    {
        public bool fixedPosition { get; set; }
        public int height { get; set; }
        public int rotationInDegrees { get; set; }
        public int scale { get; set; }
        public int width { get; set; }
        public int x { get; set; }
        public int y { get; set; }
    }

    public class Masterpage
    {
        public Data1 data { get; set; }
        public Structure1 structure { get; set; }
    }

    public class Data1
    {
        public Behaviors_Data1 behaviors_data { get; set; }
        public Component_Properties1 component_properties { get; set; }
        public Connections_Data1 connections_data { get; set; }
        public Design_Data1 design_data { get; set; }
        public Document_Data1 document_data { get; set; }
        public Mobile_Hints1 mobile_hints { get; set; }
        public Theme_Data1 theme_data { get; set; }
    }

    public class Behaviors_Data1
    {
    }

    public class Component_Properties1
    {
        public SITE_PAGES SITE_PAGES { get; set; }
        public TINY_MENU TINY_MENU { get; set; }
        public Mobile_PropitemJ2hkvwtx mobile_propItemj2hkvwtx { get; set; }
        public Mobile_PropitemJ2hkyb98 mobile_propItemj2hkyb98 { get; set; }
        public Mobile_PropitemJ5806vi1 mobile_propItemj5806vi1 { get; set; }
        public Mobile_PropitemJmhheynl1 mobile_propItemjmhheynl1 { get; set; }
        public PropitemJ2a70t05 propItemj2a70t05 { get; set; }
        public PropitemJ2a78xk2 propItemj2a78xk2 { get; set; }
        public PropitemJ2bmypmh propItemj2bmypmh { get; set; }
        public PropitemJ2hkvwtx propItemj2hkvwtx { get; set; }
        public PropitemJ2hkwwya propItemj2hkwwya { get; set; }
        public PropitemJ2hkyb98 propItemj2hkyb98 { get; set; }
        public PropitemJ3blw2w6 propItemj3blw2w6 { get; set; }
        public PropitemJ5806vi1 propItemj5806vi1 { get; set; }
        public PropitemJ58bjlp7 propItemj58bjlp7 { get; set; }
        public PropitemJ58bpu8r propItemj58bpu8r { get; set; }
        public PropitemJ58dn2xc propItemj58dn2xc { get; set; }
        public PropitemJ5hvoayd propItemj5hvoayd { get; set; }
        public PropitemJ5hvpd2m propItemj5hvpd2m { get; set; }
        public PropitemJ9y1lr63 propItemj9y1lr63 { get; set; }
        public PropitemJgdpjt9q propItemjgdpjt9q { get; set; }
        public PropitemJgdpjtah propItemjgdpjtah { get; set; }
        public PropitemJhw1023g propItemjhw1023g { get; set; }
        public PropitemJmhheynl1 propItemjmhheynl1 { get; set; }
    }

    public class SITE_PAGES
    {
        public Metadata49 metaData { get; set; }
        public string transition { get; set; }
        public string type { get; set; }
    }

    public class Metadata49
    {
        public string schemaVersion { get; set; }
    }

    public class TINY_MENU
    {
        public string direction { get; set; }
        public Metadata50 metaData { get; set; }
        public string type { get; set; }
    }

    public class Metadata50
    {
        public bool autoGenerated { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Mobile_PropitemJ2hkvwtx
    {
        public int bgScale { get; set; }
        public string gallery { get; set; }
        public int iconSize { get; set; }
        public Metadata51 metaData { get; set; }
        public string orientation { get; set; }
        public int spacing { get; set; }
        public string type { get; set; }
    }

    public class Metadata51
    {
        public bool autoGenerated { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Mobile_PropitemJ2hkyb98
    {
        public int brightness { get; set; }
        public Metadata52 metaData { get; set; }
        public string overrideAlignment { get; set; }
        public bool packed { get; set; }
        public string type { get; set; }
    }

    public class Metadata52
    {
        public bool autoGenerated { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Mobile_PropitemJ5806vi1
    {
        public int brightness { get; set; }
        public Metadata53 metaData { get; set; }
        public bool packed { get; set; }
        public string type { get; set; }
    }

    public class Metadata53
    {
        public bool autoGenerated { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Mobile_PropitemJmhheynl1
    {
        public int brightness { get; set; }
        public Metadata54 metaData { get; set; }
        public string overrideAlignment { get; set; }
        public bool packed { get; set; }
        public string type { get; set; }
    }

    public class Metadata54
    {
        public bool autoGenerated { get; set; }
        public string schemaVersion { get; set; }
    }

    public class PropitemJ2a70t05
    {
        public string alignButtons { get; set; }
        public string alignText { get; set; }
        public Metadata55 metaData { get; set; }
        public string moreButtonLabel { get; set; }
        public int moreItemHeight { get; set; }
        public bool rtl { get; set; }
        public bool sameWidthButtons { get; set; }
        public bool stretchButtonsToMenuWidth { get; set; }
        public string type { get; set; }
    }

    public class Metadata55
    {
        public string schemaVersion { get; set; }
    }

    public class PropitemJ2a78xk2
    {
        public string displayMode { get; set; }
        public Metadata56 metaData { get; set; }
        public string onClickBehavior { get; set; }
        public string type { get; set; }
    }

    public class Metadata56
    {
        public string schemaVersion { get; set; }
    }

    public class PropitemJ2bmypmh
    {
        public string align { get; set; }
        public int margin { get; set; }
        public Metadata57 metaData { get; set; }
        public string type { get; set; }
    }

    public class Metadata57
    {
        public string schemaVersion { get; set; }
    }

    public class PropitemJ2hkvwtx
    {
        public int bgScale { get; set; }
        public string gallery { get; set; }
        public int iconSize { get; set; }
        public Metadata58 metaData { get; set; }
        public string orientation { get; set; }
        public int spacing { get; set; }
        public string type { get; set; }
    }

    public class Metadata58
    {
        public string schemaVersion { get; set; }
    }

    public class PropitemJ2hkwwya
    {
        public int brightness { get; set; }
        public Metadata59 metaData { get; set; }
        public bool packed { get; set; }
        public string type { get; set; }
    }

    public class Metadata59
    {
        public string schemaVersion { get; set; }
    }

    public class PropitemJ2hkyb98
    {
        public int brightness { get; set; }
        public Metadata60 metaData { get; set; }
        public bool packed { get; set; }
        public string type { get; set; }
    }

    public class Metadata60
    {
        public string schemaVersion { get; set; }
    }

    public class PropitemJ3blw2w6
    {
        public string align { get; set; }
        public int margin { get; set; }
        public Metadata61 metaData { get; set; }
        public string type { get; set; }
    }

    public class Metadata61
    {
        public string schemaVersion { get; set; }
    }

    public class PropitemJ5806vi1
    {
        public int brightness { get; set; }
        public Metadata62 metaData { get; set; }
        public bool packed { get; set; }
        public string type { get; set; }
    }

    public class Metadata62
    {
        public string schemaVersion { get; set; }
    }

    public class PropitemJ58bjlp7
    {
        public string displayMode { get; set; }
        public Metadata63 metaData { get; set; }
        public string onClickBehavior { get; set; }
        public string type { get; set; }
    }

    public class Metadata63
    {
        public string schemaVersion { get; set; }
    }

    public class PropitemJ58bpu8r
    {
        public string displayMode { get; set; }
        public Metadata64 metaData { get; set; }
        public string onClickBehavior { get; set; }
        public string type { get; set; }
    }

    public class Metadata64
    {
        public string schemaVersion { get; set; }
    }

    public class PropitemJ58dn2xc
    {
        public string displayMode { get; set; }
        public Metadata65 metaData { get; set; }
        public string onClickBehavior { get; set; }
        public string type { get; set; }
    }

    public class Metadata65
    {
        public string schemaVersion { get; set; }
    }

    public class PropitemJ5hvoayd
    {
        public string displayMode { get; set; }
        public Metadata66 metaData { get; set; }
        public string onClickBehavior { get; set; }
        public string type { get; set; }
    }

    public class Metadata66
    {
        public string schemaVersion { get; set; }
    }

    public class PropitemJ5hvpd2m
    {
        public string displayMode { get; set; }
        public Metadata67 metaData { get; set; }
        public string onClickBehavior { get; set; }
        public string type { get; set; }
    }

    public class Metadata67
    {
        public string schemaVersion { get; set; }
    }

    public class PropitemJ9y1lr63
    {
        public string align { get; set; }
        public int margin { get; set; }
        public Metadata68 metaData { get; set; }
        public string type { get; set; }
    }

    public class Metadata68
    {
        public string schemaVersion { get; set; }
    }

    public class PropitemJgdpjt9q
    {
        public int columnsMargin { get; set; }
        public int frameMargin { get; set; }
        public bool fullWidth { get; set; }
        public Metadata69 metaData { get; set; }
        public int rowMargin { get; set; }
        public int siteMargin { get; set; }
        public string type { get; set; }
    }

    public class Metadata69
    {
        public string schemaVersion { get; set; }
    }

    public class PropitemJgdpjtah
    {
        public int alignment { get; set; }
        public Metadata70 metaData { get; set; }
        public string type { get; set; }
    }

    public class Metadata70
    {
        public string schemaVersion { get; set; }
    }

    public class PropitemJhw1023g
    {
        public string displayMode { get; set; }
        public Metadata71 metaData { get; set; }
        public string onClickBehavior { get; set; }
        public string type { get; set; }
    }

    public class Metadata71
    {
        public string schemaVersion { get; set; }
    }

    public class PropitemJmhheynl1
    {
        public int brightness { get; set; }
        public Metadata72 metaData { get; set; }
        public bool packed { get; set; }
        public string type { get; set; }
    }

    public class Metadata72
    {
        public string schemaVersion { get; set; }
    }

    public class Connections_Data1
    {
        public TINY_MENU_CONNECTION TINY_MENU_CONNECTION { get; set; }
        public ConnectionJgrp2xuz connectionjgrp2xuz { get; set; }
        public ConnectionJgrp2xyk connectionjgrp2xyk { get; set; }
        public ConnectionJgrp2y22 connectionjgrp2y22 { get; set; }
        public ConnectionJgrp2y5r connectionjgrp2y5r { get; set; }
        public ConnectionJgrp2y9h connectionjgrp2y9h { get; set; }
        public ConnectionJgrp2yd7 connectionjgrp2yd7 { get; set; }
        public ConnectionJgrp2ygs connectionjgrp2ygs { get; set; }
        public ConnectionJgrp2yka connectionjgrp2yka { get; set; }
        public ConnectionJgrp2yno connectionjgrp2yno { get; set; }
        public ConnectionJgrp2yr4 connectionjgrp2yr4 { get; set; }
        public ConnectionJgrp2yue connectionjgrp2yue { get; set; }
        public ConnectionJgrp2yxq connectionjgrp2yxq { get; set; }
        public ConnectionJgrp2z13 connectionjgrp2z13 { get; set; }
        public ConnectionJgrp2z4f connectionjgrp2z4f { get; set; }
        public ConnectionJgrp2z7o connectionjgrp2z7o { get; set; }
        public ConnectionJgrp2zb1 connectionjgrp2zb1 { get; set; }
        public ConnectionJgrp2zee connectionjgrp2zee { get; set; }
        public ConnectionJgrp2zhp connectionjgrp2zhp { get; set; }
        public ConnectionJgrp2zkz connectionjgrp2zkz { get; set; }
        public ConnectionJgrp2zod connectionjgrp2zod { get; set; }
        public ConnectionJgrpccd2 connectionjgrpccd2 { get; set; }
        public ConnectionJhw10245 connectionjhw10245 { get; set; }
        public ConnectionJmhheynm connectionjmhheynm { get; set; }
    }

    public class TINY_MENU_CONNECTION
    {
        public string id { get; set; }
        public Item16[] items { get; set; }
        public string type { get; set; }
    }

    public class Item16
    {
        public string role { get; set; }
        public string type { get; set; }
    }

    public class ConnectionJgrp2xuz
    {
        public string id { get; set; }
        public Item17[] items { get; set; }
        public string type { get; set; }
    }

    public class Item17
    {
        public string role { get; set; }
        public string type { get; set; }
    }

    public class ConnectionJgrp2xyk
    {
        public string id { get; set; }
        public Item18[] items { get; set; }
        public string type { get; set; }
    }

    public class Item18
    {
        public string role { get; set; }
        public string type { get; set; }
    }

    public class ConnectionJgrp2y22
    {
        public string id { get; set; }
        public Item19[] items { get; set; }
        public string type { get; set; }
    }

    public class Item19
    {
        public string role { get; set; }
        public string type { get; set; }
    }

    public class ConnectionJgrp2y5r
    {
        public string id { get; set; }
        public Item20[] items { get; set; }
        public string type { get; set; }
    }

    public class Item20
    {
        public string role { get; set; }
        public string type { get; set; }
    }

    public class ConnectionJgrp2y9h
    {
        public string id { get; set; }
        public Item21[] items { get; set; }
        public string type { get; set; }
    }

    public class Item21
    {
        public string role { get; set; }
        public string type { get; set; }
    }

    public class ConnectionJgrp2yd7
    {
        public string id { get; set; }
        public Item22[] items { get; set; }
        public string type { get; set; }
    }

    public class Item22
    {
        public string role { get; set; }
        public string type { get; set; }
    }

    public class ConnectionJgrp2ygs
    {
        public string id { get; set; }
        public Item23[] items { get; set; }
        public string type { get; set; }
    }

    public class Item23
    {
        public string role { get; set; }
        public string type { get; set; }
    }

    public class ConnectionJgrp2yka
    {
        public string id { get; set; }
        public Item24[] items { get; set; }
        public string type { get; set; }
    }

    public class Item24
    {
        public string role { get; set; }
        public string type { get; set; }
    }

    public class ConnectionJgrp2yno
    {
        public string id { get; set; }
        public Item25[] items { get; set; }
        public string type { get; set; }
    }

    public class Item25
    {
        public string role { get; set; }
        public string type { get; set; }
    }

    public class ConnectionJgrp2yr4
    {
        public string id { get; set; }
        public Item26[] items { get; set; }
        public string type { get; set; }
    }

    public class Item26
    {
        public string role { get; set; }
        public string type { get; set; }
    }

    public class ConnectionJgrp2yue
    {
        public string id { get; set; }
        public Item27[] items { get; set; }
        public string type { get; set; }
    }

    public class Item27
    {
        public string role { get; set; }
        public string type { get; set; }
    }

    public class ConnectionJgrp2yxq
    {
        public string id { get; set; }
        public Item28[] items { get; set; }
        public string type { get; set; }
    }

    public class Item28
    {
        public string role { get; set; }
        public string type { get; set; }
    }

    public class ConnectionJgrp2z13
    {
        public string id { get; set; }
        public Item29[] items { get; set; }
        public string type { get; set; }
    }

    public class Item29
    {
        public string role { get; set; }
        public string type { get; set; }
    }

    public class ConnectionJgrp2z4f
    {
        public string id { get; set; }
        public Item30[] items { get; set; }
        public string type { get; set; }
    }

    public class Item30
    {
        public string role { get; set; }
        public string type { get; set; }
    }

    public class ConnectionJgrp2z7o
    {
        public string id { get; set; }
        public Item31[] items { get; set; }
        public string type { get; set; }
    }

    public class Item31
    {
        public string role { get; set; }
        public string type { get; set; }
    }

    public class ConnectionJgrp2zb1
    {
        public string id { get; set; }
        public Item32[] items { get; set; }
        public string type { get; set; }
    }

    public class Item32
    {
        public string role { get; set; }
        public string type { get; set; }
    }

    public class ConnectionJgrp2zee
    {
        public string id { get; set; }
        public Item33[] items { get; set; }
        public string type { get; set; }
    }

    public class Item33
    {
        public string role { get; set; }
        public string type { get; set; }
    }

    public class ConnectionJgrp2zhp
    {
        public string id { get; set; }
        public Item34[] items { get; set; }
        public string type { get; set; }
    }

    public class Item34
    {
        public string role { get; set; }
        public string type { get; set; }
    }

    public class ConnectionJgrp2zkz
    {
        public string id { get; set; }
        public Item35[] items { get; set; }
        public string type { get; set; }
    }

    public class Item35
    {
        public string role { get; set; }
        public string type { get; set; }
    }

    public class ConnectionJgrp2zod
    {
        public string id { get; set; }
        public Item36[] items { get; set; }
        public string type { get; set; }
    }

    public class Item36
    {
        public string role { get; set; }
        public string type { get; set; }
    }

    public class ConnectionJgrpccd2
    {
        public string id { get; set; }
        public Item37[] items { get; set; }
        public string type { get; set; }
    }

    public class Item37
    {
        public string role { get; set; }
        public string type { get; set; }
    }

    public class ConnectionJhw10245
    {
        public string id { get; set; }
        public Item38[] items { get; set; }
        public string type { get; set; }
    }

    public class Item38
    {
        public string role { get; set; }
        public string type { get; set; }
    }

    public class ConnectionJmhheynm
    {
        public string id { get; set; }
        public Item39[] items { get; set; }
        public string type { get; set; }
    }

    public class Item39
    {
        public string role { get; set; }
        public string type { get; set; }
    }

    public class Design_Data1
    {
        public DataitemJgdpjt9r dataItemjgdpjt9r { get; set; }
        public DataitemJgdpjt9s dataItemjgdpjt9s { get; set; }
        public DataitemJgdpjtai dataItemjgdpjtai { get; set; }
        public DataitemJgdpjtaj dataItemjgdpjtaj { get; set; }
    }

    public class DataitemJgdpjt9r
    {
        public string background { get; set; }
        public string id { get; set; }
        public Metadata73 metaData { get; set; }
        public string type { get; set; }
    }

    public class Metadata73
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class DataitemJgdpjt9s
    {
        public string alignType { get; set; }
        public string color { get; set; }
        public int colorOpacity { get; set; }
        public string colorOverlay { get; set; }
        public int colorOverlayOpacity { get; set; }
        public string fittingType { get; set; }
        public string id { get; set; }
        public Metadata74 metaData { get; set; }
        public string scrollType { get; set; }
        public string type { get; set; }
    }

    public class Metadata74
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class DataitemJgdpjtai
    {
        public string background { get; set; }
        public string charas { get; set; }
        public object[] dataChangeBehaviors { get; set; }
        public string id { get; set; }
        public Metadata75 metaData { get; set; }
        public string type { get; set; }
    }

    public class Metadata75
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class DataitemJgdpjtaj
    {
        public string alignType { get; set; }
        public string color { get; set; }
        public float colorOpacity { get; set; }
        public string colorOverlay { get; set; }
        public int colorOverlayOpacity { get; set; }
        public string fittingType { get; set; }
        public string id { get; set; }
        public Metadata76 metaData { get; set; }
        public string scrollType { get; set; }
        public string showOverlayForMediaType { get; set; }
        public string type { get; set; }
    }

    public class Metadata76
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Document_Data1
    {
        public _1Fti _1fti { get; set; }
        public CUSTOM_MAIN_MENU CUSTOM_MAIN_MENU { get; set; }
        public CUSTOM_MENUS CUSTOM_MENUS { get; set; }
        public MAIN_MENU MAIN_MENU { get; set; }
        public TINY_MENU1 TINY_MENU { get; set; }
        public Ai3xt3 ai3xt { get; set; }
        public Apppart22zi appPart22zi { get; set; }
        public Appvars_61F33d5030024882Ae86D319c1a249ab appVars_61f33d5030024882ae86d319c1a249ab { get; set; }
        public Bfx3w bfx3w { get; set; }
        public Bmi23nr bmi23nr { get; set; }
        public C1dmp c1dmp { get; set; }
        public C1dmp_Iw1yd7y7_Bg c1dmp_iw1yd7y7_bg { get; set; }
        public Custombgimg24ta customBgImg24ta { get; set; }
        public DataitemJ13id86f dataItemj13id86f { get; set; }
        public DataitemJ13id86o dataItemj13id86o { get; set; }
        public DataitemJ13idlsm dataItemj13idlsm { get; set; }
        public DataitemJ13idlsw dataItemj13idlsw { get; set; }
        public DataitemJ13j1hhn dataItemj13j1hhn { get; set; }
        public DataitemJ13j2c15 dataItemj13j2c15 { get; set; }
        public DataitemJ13j2c1j dataItemj13j2c1j { get; set; }
        public DataitemJ2a6pyhj dataItemj2a6pyhj { get; set; }
        public DataitemJ2a6pyht dataItemj2a6pyht { get; set; }
        public DataitemJ2a78xk1 dataItemj2a78xk1 { get; set; }
        public DataitemJ2a79d7r dataItemj2a79d7r { get; set; }
        public DataitemJ2bmypmg dataItemj2bmypmg { get; set; }
        public DataitemJ2bmzvv1 dataItemj2bmzvv1 { get; set; }
        public DataitemJ2bmzvv11 dataItemj2bmzvv11 { get; set; }
        public DataitemJ2bneb0g dataItemj2bneb0g { get; set; }
        public DataitemJ2hirfyb dataItemj2hirfyb { get; set; }
        public DataitemJ2hirfyb1 dataItemj2hirfyb1 { get; set; }
        public DataitemJ2hirg0x dataItemj2hirg0x { get; set; }
        public DataitemJ2hirg0x1 dataItemj2hirg0x1 { get; set; }
        public DataitemJ2hkvwto dataItemj2hkvwto { get; set; }
        public DataitemJ2hkvwto1 dataItemj2hkvwto1 { get; set; }
        public DataitemJ2hkvwtu2 dataItemj2hkvwtu2 { get; set; }
        public DataitemJ2hkwwy9 dataItemj2hkwwy9 { get; set; }
        public DataitemJ2hkyb97 dataItemj2hkyb97 { get; set; }
        public DataitemJ2hl6a54 dataItemj2hl6a54 { get; set; }
        public DataitemJ2hl6a541 dataItemj2hl6a541 { get; set; }
        public DataitemJ3blw2w5 dataItemj3blw2w5 { get; set; }
        public DataitemJ3bncwtx dataItemj3bncwtx { get; set; }
        public DataitemJ3bncwtx1 dataItemj3bncwtx1 { get; set; }
        public DataitemJ4dyeipz dataItemj4dyeipz { get; set; }
        public DataitemJ4dyeipz1 dataItemj4dyeipz1 { get; set; }
        public DataitemJ4ny92y1 dataItemj4ny92y1 { get; set; }
        public DataitemJ4ny92y2 dataItemj4ny92y2 { get; set; }
        public DataitemJ5806vhy dataItemj5806vhy { get; set; }
        public DataitemJ58bjlp6 dataItemj58bjlp6 { get; set; }
        public DataitemJ58bpu8p dataItemj58bpu8p { get; set; }
        public DataitemJ58bu6qc dataItemj58bu6qc { get; set; }
        public DataitemJ58butay dataItemj58butay { get; set; }
        public DataitemJ58dn2xb dataItemj58dn2xb { get; set; }
        public DataitemJ58dvw22 dataItemj58dvw22 { get; set; }
        public DataitemJ5hvoay6 dataItemj5hvoay6 { get; set; }
        public DataitemJ5hvpd2l dataItemj5hvpd2l { get; set; }
        public DataitemJ5hwacpm dataItemj5hwacpm { get; set; }
        public DataitemJ5hwb4jy dataItemj5hwb4jy { get; set; }
        public DataitemJ7abm80n dataItemj7abm80n { get; set; }
        public DataitemJ7abm80n1 dataItemj7abm80n1 { get; set; }
        public DataitemJ7zzukhm dataItemj7zzukhm { get; set; }
        public DataitemJ7zzukhm1 dataItemj7zzukhm1 { get; set; }
        public DataitemJ8a9760q dataItemj8a9760q { get; set; }
        public DataitemJ9y1lr60 dataItemj9y1lr60 { get; set; }
        public DataitemJ9y1mu2z dataItemj9y1mu2z { get; set; }
        public DataitemJg4v6trp dataItemjg4v6trp { get; set; }
        public DataitemJg4v6trp1 dataItemjg4v6trp1 { get; set; }
        public DataitemJg5at6bm dataItemjg5at6bm { get; set; }
        public DataitemJg5at6bn dataItemjg5at6bn { get; set; }
        public DataitemJg6c64kn dataItemjg6c64kn { get; set; }
        public DataitemJg6c64kn1 dataItemjg6c64kn1 { get; set; }
        public DataitemJgf6he4x dataItemjgf6he4x { get; set; }
        public DataitemJggdt3nr dataItemjggdt3nr { get; set; }
        public DataitemJhw1023c dataItemjhw1023c { get; set; }
        public DataitemJhw1fv5m dataItemjhw1fv5m { get; set; }
        public DataitemJiq4ytt7 dataItemjiq4ytt7 { get; set; }
        public DataitemJiq4ytt71 dataItemjiq4ytt71 { get; set; }
        public DataitemJj8keiw3 dataItemjj8keiw3 { get; set; }
        public DataitemJj8keiw31 dataItemjj8keiw31 { get; set; }
        public DataitemJja16l3a dataItemjja16l3a { get; set; }
        public DataitemJja16l3a1 dataItemjja16l3a1 { get; set; }
        public DataitemJja171ea dataItemjja171ea { get; set; }
        public DataitemJja171ea1 dataItemjja171ea1 { get; set; }
        public DataitemJja177ho dataItemjja177ho { get; set; }
        public DataitemJja177ho1 dataItemjja177ho1 { get; set; }
        public DataitemJja17fqb dataItemjja17fqb { get; set; }
        public DataitemJja17fqb1 dataItemjja17fqb1 { get; set; }
        public DataitemJlzb8zcj dataItemjlzb8zcj { get; set; }
        public DataitemJlzb8zcj1 dataItemjlzb8zcj1 { get; set; }
        public DataitemJmhheynl dataItemjmhheynl { get; set; }
        public E1ym1 e1ym1 { get; set; }
        public E4jlk e4jlk { get; set; }
        public Eixbx eixbx { get; set; }
        public Fjayw fjayw { get; set; }
        public Gmmt9 gmmt9 { get; set; }
        public H3lrw h3lrw { get; set; }
        public I35k6 i35k6 { get; set; }
        public Iynz9 iynz9 { get; set; }
        public Ma897 ma897 { get; set; }
        public Masterpage1 masterPage { get; set; }
        public P3eb1 p3eb1 { get; set; }
        public Pst14 pst14 { get; set; }
        public R6p4e r6p4e { get; set; }
        public Sxcn6 sxcn6 { get; set; }
        public Textlink_Jmhhgsfe textLink_jmhhgsfe { get; set; }
        public Uca7v uca7v { get; set; }
        public Vn92i vn92i { get; set; }
        public Ygaqm ygaqm { get; set; }
    }

    public class _1Fti
    {
        public string id { get; set; }
        public Metadata77 metaData { get; set; }
        public string pageId { get; set; }
        public string target { get; set; }
        public string type { get; set; }
    }

    public class Metadata77
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class CUSTOM_MAIN_MENU
    {
        public string id { get; set; }
        public string[] items { get; set; }
        public Metadata78 metaData { get; set; }
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Metadata78
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class CUSTOM_MENUS
    {
        public string id { get; set; }
        public string[] menus { get; set; }
        public Metadata79 metaData { get; set; }
        public string type { get; set; }
    }

    public class Metadata79
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class MAIN_MENU
    {
        public string id { get; set; }
        public object[] items { get; set; }
        public Metadata80 metaData { get; set; }
        public string type { get; set; }
    }

    public class Metadata80
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class TINY_MENU1
    {
        public string id { get; set; }
        public Metadata81 metaData { get; set; }
        public string type { get; set; }
    }

    public class Metadata81
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Ai3xt3
    {
        public string descriptionSEO { get; set; }
        public bool hidePage { get; set; }
        public bool hideTitle { get; set; }
        public string icon { get; set; }
        public string id { get; set; }
        public bool indexable { get; set; }
        public bool isLandingPage { get; set; }
        public bool isMobileLandingPage { get; set; }
        public bool isPopup { get; set; }
        public Metadata82 metaData { get; set; }
        public string metaKeywordsSEO { get; set; }
        public Pagebackgrounds pageBackgrounds { get; set; }
        public Pagesecurity pageSecurity { get; set; }
        public string pageTitleSEO { get; set; }
        public string pageUriSEO { get; set; }
        public string title { get; set; }
        public int tpaApplicationId { get; set; }
        public Translationdata translationData { get; set; }
        public string type { get; set; }
        public bool underConstruction { get; set; }
    }

    public class Metadata82
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Pagebackgrounds
    {
        public Desktop2 desktop { get; set; }
        public Mobile1 mobile { get; set; }
    }

    public class Desktop2
    {
        public bool custom { get; set; }
        public bool isPreset { get; set; }
        public string _ref { get; set; }
    }

    public class Mobile1
    {
        public bool custom { get; set; }
        public bool isPreset { get; set; }
        public string mediaSizing { get; set; }
        public string _ref { get; set; }
    }

    public class Pagesecurity
    {
        public string dialogLanguage { get; set; }
        public string passwordDigest { get; set; }
        public bool requireLogin { get; set; }
    }

    public class Translationdata
    {
        public bool uriSEOTranslated { get; set; }
    }

    public class Apppart22zi
    {
        public string appInnerID { get; set; }
        public object[] appLogicCustomizations { get; set; }
        public Applogicparams appLogicParams { get; set; }
        public string appPartName { get; set; }
        public string id { get; set; }
        public Metadata83 metaData { get; set; }
        public string type { get; set; }
        public string viewName { get; set; }
    }

    public class Applogicparams
    {
    }

    public class Metadata83
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Appvars_61F33d5030024882Ae86D319c1a249ab
    {
        public string appDefId { get; set; }
        public string id { get; set; }
        public Metadata84 metaData { get; set; }
        public string type { get; set; }
        public Vars vars { get; set; }
    }

    public class Metadata84
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Vars
    {
        public Applicationactivestate applicationActiveState { get; set; }
    }

    public class Applicationactivestate
    {
        public string type { get; set; }
        public string value { get; set; }
    }

    public class Bfx3w
    {
        public string descriptionSEO { get; set; }
        public bool hidePage { get; set; }
        public bool hideTitle { get; set; }
        public string icon { get; set; }
        public string id { get; set; }
        public bool indexable { get; set; }
        public bool isLandingPage { get; set; }
        public bool isMobileLandingPage { get; set; }
        public bool isPopup { get; set; }
        public Metadata85 metaData { get; set; }
        public string metaKeywordsSEO { get; set; }
        public Pagebackgrounds1 pageBackgrounds { get; set; }
        public Pagesecurity1 pageSecurity { get; set; }
        public string pageTitleSEO { get; set; }
        public string pageUriSEO { get; set; }
        public string title { get; set; }
        public int tpaApplicationId { get; set; }
        public Translationdata1 translationData { get; set; }
        public string type { get; set; }
        public bool underConstruction { get; set; }
    }

    public class Metadata85
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Pagebackgrounds1
    {
        public Desktop3 desktop { get; set; }
        public Mobile2 mobile { get; set; }
    }

    public class Desktop3
    {
        public bool custom { get; set; }
        public bool isPreset { get; set; }
        public string _ref { get; set; }
    }

    public class Mobile2
    {
        public bool custom { get; set; }
        public bool isPreset { get; set; }
        public string mediaSizing { get; set; }
        public string _ref { get; set; }
    }

    public class Pagesecurity1
    {
        public string dialogLanguage { get; set; }
        public string passwordDigest { get; set; }
        public bool requireLogin { get; set; }
    }

    public class Translationdata1
    {
        public bool uriSEOTranslated { get; set; }
    }

    public class Bmi23nr
    {
        public string id { get; set; }
        public bool isVisible { get; set; }
        public bool isVisibleMobile { get; set; }
        public string[] items { get; set; }
        public string label { get; set; }
        public string link { get; set; }
        public Metadata86 metaData { get; set; }
        public string type { get; set; }
    }

    public class Metadata86
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class C1dmp
    {
        public string descriptionSEO { get; set; }
        public bool hidePage { get; set; }
        public bool hideTitle { get; set; }
        public string icon { get; set; }
        public string id { get; set; }
        public bool ignoreBottomBottomAnchors { get; set; }
        public bool indexable { get; set; }
        public bool isLandingPage { get; set; }
        public bool isMobileLandingPage { get; set; }
        public bool isPopup { get; set; }
        public Metadata87 metaData { get; set; }
        public string metaKeywordsSEO { get; set; }
        public string ogImage { get; set; }
        public Pagebackgrounds2 pageBackgrounds { get; set; }
        public Pagesecurity2 pageSecurity { get; set; }
        public string pageTitleSEO { get; set; }
        public string pageUriSEO { get; set; }
        public string title { get; set; }
        public int tpaApplicationId { get; set; }
        public Translationdata2 translationData { get; set; }
        public string type { get; set; }
        public bool underConstruction { get; set; }
    }

    public class Metadata87
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Pagebackgrounds2
    {
        public Desktop4 desktop { get; set; }
        public Mobile3 mobile { get; set; }
    }

    public class Desktop4
    {
        public bool custom { get; set; }
        public bool isPreset { get; set; }
        public string _ref { get; set; }
    }

    public class Mobile3
    {
        public bool custom { get; set; }
        public bool isPreset { get; set; }
        public string mediaSizing { get; set; }
        public string _ref { get; set; }
    }

    public class Pagesecurity2
    {
        public bool requireLogin { get; set; }
    }

    public class Translationdata2
    {
        public bool uriSEOTranslated { get; set; }
    }

    public class C1dmp_Iw1yd7y7_Bg
    {
        public string alignType { get; set; }
        public string color { get; set; }
        public string fittingType { get; set; }
        public string id { get; set; }
        public Metadata88 metaData { get; set; }
        public string scrollType { get; set; }
        public string type { get; set; }
    }

    public class Metadata88
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Custombgimg24ta
    {
        public string alignType { get; set; }
        public string color { get; set; }
        public string colorOverlay { get; set; }
        public int colorOverlayOpacity { get; set; }
        public string fittingType { get; set; }
        public string id { get; set; }
        public Metadata89 metaData { get; set; }
        public string scrollType { get; set; }
        public string type { get; set; }
    }

    public class Metadata89
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class DataitemJ13id86f
    {
        public string id { get; set; }
        public bool isVisible { get; set; }
        public bool isVisibleMobile { get; set; }
        public object[] items { get; set; }
        public string label { get; set; }
        public string link { get; set; }
        public Metadata90 metaData { get; set; }
        public string type { get; set; }
    }

    public class Metadata90
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class DataitemJ13id86o
    {
        public string anchorDataId { get; set; }
        public string anchorName { get; set; }
        public string id { get; set; }
        public Metadata91 metaData { get; set; }
        public string pageId { get; set; }
        public string type { get; set; }
    }

    public class Metadata91
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class DataitemJ13idlsm
    {
        public string id { get; set; }
        public bool isVisible { get; set; }
        public bool isVisibleMobile { get; set; }
        public object[] items { get; set; }
        public string label { get; set; }
        public string link { get; set; }
        public Metadata92 metaData { get; set; }
        public string type { get; set; }
    }

    public class Metadata92
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class DataitemJ13idlsw
    {
        public string anchorDataId { get; set; }
        public string anchorName { get; set; }
        public string id { get; set; }
        public Metadata93 metaData { get; set; }
        public string pageId { get; set; }
        public string type { get; set; }
    }

    public class Metadata93
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class DataitemJ13j1hhn
    {
        public string id { get; set; }
        public bool isVisible { get; set; }
        public bool isVisibleMobile { get; set; }
        public object[] items { get; set; }
        public string label { get; set; }
        public string link { get; set; }
        public Metadata94 metaData { get; set; }
        public string type { get; set; }
    }

    public class Metadata94
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class DataitemJ13j2c15
    {
        public string id { get; set; }
        public bool isVisible { get; set; }
        public bool isVisibleMobile { get; set; }
        public object[] items { get; set; }
        public string label { get; set; }
        public string link { get; set; }
        public Metadata95 metaData { get; set; }
        public string type { get; set; }
    }

    public class Metadata95
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class DataitemJ13j2c1j
    {
        public string anchorDataId { get; set; }
        public string anchorName { get; set; }
        public string id { get; set; }
        public Metadata96 metaData { get; set; }
        public string pageId { get; set; }
        public string type { get; set; }
    }

    public class Metadata96
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class DataitemJ2a6pyhj
    {
        public string id { get; set; }
        public bool isVisible { get; set; }
        public bool isVisibleMobile { get; set; }
        public object[] items { get; set; }
        public string label { get; set; }
        public string link { get; set; }
        public Metadata97 metaData { get; set; }
        public string type { get; set; }
    }

    public class Metadata97
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class DataitemJ2a6pyht
    {
        public string anchorDataId { get; set; }
        public string anchorName { get; set; }
        public string id { get; set; }
        public Metadata98 metaData { get; set; }
        public string pageId { get; set; }
        public string type { get; set; }
    }

    public class Metadata98
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class DataitemJ2a78xk1
    {
        public string alt { get; set; }
        public string description { get; set; }
        public int height { get; set; }
        public string id { get; set; }
        public string link { get; set; }
        public Metadata99 metaData { get; set; }
        public string title { get; set; }
        public string type { get; set; }
        public string uri { get; set; }
        public int width { get; set; }
    }

    public class Metadata99
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class DataitemJ2a79d7r
    {
        public string id { get; set; }
        public Metadata100 metaData { get; set; }
        public string pageId { get; set; }
        public string type { get; set; }
    }

    public class Metadata100
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class DataitemJ2bmypmg
    {
        public string id { get; set; }
        public string label { get; set; }
        public string link { get; set; }
        public Metadata101 metaData { get; set; }
        public string type { get; set; }
    }

    public class Metadata101
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class DataitemJ2bmzvv1
    {
        public string id { get; set; }
        public bool isVisible { get; set; }
        public bool isVisibleMobile { get; set; }
        public object[] items { get; set; }
        public string label { get; set; }
        public string link { get; set; }
        public Metadata102 metaData { get; set; }
        public string type { get; set; }
    }

    public class Metadata102
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class DataitemJ2bmzvv11
    {
        public string id { get; set; }
        public Metadata103 metaData { get; set; }
        public string pageId { get; set; }
        public string target { get; set; }
        public string type { get; set; }
    }

    public class Metadata103
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class DataitemJ2bneb0g
    {
        public string id { get; set; }
        public Metadata104 metaData { get; set; }
        public string pageId { get; set; }
        public string type { get; set; }
    }

    public class Metadata104
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class DataitemJ2hirfyb
    {
        public string id { get; set; }
        public bool isVisible { get; set; }
        public bool isVisibleMobile { get; set; }
        public object[] items { get; set; }
        public string label { get; set; }
        public string link { get; set; }
        public Metadata105 metaData { get; set; }
        public string type { get; set; }
    }

    public class Metadata105
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class DataitemJ2hirfyb1
    {
        public string id { get; set; }
        public Metadata106 metaData { get; set; }
        public string pageId { get; set; }
        public string target { get; set; }
        public string type { get; set; }
    }

    public class Metadata106
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class DataitemJ2hirg0x
    {
        public string id { get; set; }
        public bool isVisible { get; set; }
        public bool isVisibleMobile { get; set; }
        public object[] items { get; set; }
        public string label { get; set; }
        public string link { get; set; }
        public Metadata107 metaData { get; set; }
        public string type { get; set; }
    }

    public class Metadata107
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class DataitemJ2hirg0x1
    {
        public string id { get; set; }
        public Metadata108 metaData { get; set; }
        public string pageId { get; set; }
        public string target { get; set; }
        public string type { get; set; }
    }

    public class Metadata108
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class DataitemJ2hkvwto
    {
        public string id { get; set; }
        public string[] items { get; set; }
        public Metadata109 metaData { get; set; }
        public string type { get; set; }
    }

    public class Metadata109
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class DataitemJ2hkvwto1
    {
        public string alt { get; set; }
        public string description { get; set; }
        public int height { get; set; }
        public string id { get; set; }
        public string link { get; set; }
        public Metadata110 metaData { get; set; }
        public string title { get; set; }
        public string type { get; set; }
        public string uri { get; set; }
        public int width { get; set; }
    }

    public class Metadata110
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class DataitemJ2hkvwtu2
    {
        public string alt { get; set; }
        public string description { get; set; }
        public int height { get; set; }
        public string id { get; set; }
        public string link { get; set; }
        public Metadata111 metaData { get; set; }
        public string title { get; set; }
        public string type { get; set; }
        public string uri { get; set; }
        public int width { get; set; }
    }

    public class Metadata111
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class DataitemJ2hkwwy9
    {
        public string id { get; set; }
        public object[] linkList { get; set; }
        public Metadata112 metaData { get; set; }
        public string stylesMapId { get; set; }
        public string text { get; set; }
        public string type { get; set; }
    }

    public class Metadata112
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class DataitemJ2hkyb97
    {
        public string id { get; set; }
        public object[] linkList { get; set; }
        public Metadata113 metaData { get; set; }
        public string stylesMapId { get; set; }
        public string text { get; set; }
        public string type { get; set; }
    }

    public class Metadata113
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class DataitemJ2hl6a54
    {
        public string id { get; set; }
        public bool isVisible { get; set; }
        public bool isVisibleMobile { get; set; }
        public string[] items { get; set; }
        public string label { get; set; }
        public string link { get; set; }
        public Metadata114 metaData { get; set; }
        public string type { get; set; }
    }

    public class Metadata114
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class DataitemJ2hl6a541
    {
        public string id { get; set; }
        public Metadata115 metaData { get; set; }
        public string pageId { get; set; }
        public string target { get; set; }
        public string type { get; set; }
    }

    public class Metadata115
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class DataitemJ3blw2w5
    {
        public string id { get; set; }
        public string label { get; set; }
        public string link { get; set; }
        public Metadata116 metaData { get; set; }
        public string type { get; set; }
    }

    public class Metadata116
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class DataitemJ3bncwtx
    {
        public string id { get; set; }
        public bool isVisible { get; set; }
        public bool isVisibleMobile { get; set; }
        public object[] items { get; set; }
        public string label { get; set; }
        public string link { get; set; }
        public Metadata117 metaData { get; set; }
        public string type { get; set; }
    }

    public class Metadata117
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class DataitemJ3bncwtx1
    {
        public string id { get; set; }
        public Metadata118 metaData { get; set; }
        public string pageId { get; set; }
        public string target { get; set; }
        public string type { get; set; }
    }

    public class Metadata118
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class DataitemJ4dyeipz
    {
        public string id { get; set; }
        public bool isVisible { get; set; }
        public bool isVisibleMobile { get; set; }
        public object[] items { get; set; }
        public string label { get; set; }
        public string link { get; set; }
        public Metadata119 metaData { get; set; }
        public string type { get; set; }
    }

    public class Metadata119
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class DataitemJ4dyeipz1
    {
        public string id { get; set; }
        public Metadata120 metaData { get; set; }
        public string pageId { get; set; }
        public string target { get; set; }
        public string type { get; set; }
    }

    public class Metadata120
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class DataitemJ4ny92y1
    {
        public string id { get; set; }
        public Metadata121 metaData { get; set; }
        public string target { get; set; }
        public string type { get; set; }
        public string url { get; set; }
    }

    public class Metadata121
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class DataitemJ4ny92y2
    {
        public string id { get; set; }
        public Metadata122 metaData { get; set; }
        public string target { get; set; }
        public string type { get; set; }
        public string url { get; set; }
    }

    public class Metadata122
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class DataitemJ5806vhy
    {
        public string id { get; set; }
        public object[] linkList { get; set; }
        public Metadata123 metaData { get; set; }
        public string stylesMapId { get; set; }
        public string text { get; set; }
        public string type { get; set; }
    }

    public class Metadata123
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class DataitemJ58bjlp6
    {
        public string alt { get; set; }
        public Crop crop { get; set; }
        public string description { get; set; }
        public int height { get; set; }
        public string id { get; set; }
        public string link { get; set; }
        public Metadata124 metaData { get; set; }
        public string title { get; set; }
        public string type { get; set; }
        public string uri { get; set; }
        public int width { get; set; }
    }

    public class Crop
    {
        public int height { get; set; }
        public int width { get; set; }
        public int x { get; set; }
        public int y { get; set; }
    }

    public class Metadata124
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class DataitemJ58bpu8p
    {
        public string alt { get; set; }
        public string description { get; set; }
        public int height { get; set; }
        public string id { get; set; }
        public string link { get; set; }
        public Metadata125 metaData { get; set; }
        public string title { get; set; }
        public string type { get; set; }
        public string uri { get; set; }
        public int width { get; set; }
    }

    public class Metadata125
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class DataitemJ58bu6qc
    {
        public string id { get; set; }
        public Metadata126 metaData { get; set; }
        public string target { get; set; }
        public string type { get; set; }
        public string url { get; set; }
    }

    public class Metadata126
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class DataitemJ58butay
    {
        public string id { get; set; }
        public Metadata127 metaData { get; set; }
        public string target { get; set; }
        public string type { get; set; }
        public string url { get; set; }
    }

    public class Metadata127
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class DataitemJ58dn2xb
    {
        public string alt { get; set; }
        public string description { get; set; }
        public int height { get; set; }
        public string id { get; set; }
        public string link { get; set; }
        public Metadata128 metaData { get; set; }
        public string title { get; set; }
        public string type { get; set; }
        public string uri { get; set; }
        public int width { get; set; }
    }

    public class Metadata128
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class DataitemJ58dvw22
    {
        public string id { get; set; }
        public Metadata129 metaData { get; set; }
        public string pageId { get; set; }
        public string type { get; set; }
    }

    public class Metadata129
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class DataitemJ5hvoay6
    {
        public string alt { get; set; }
        public string description { get; set; }
        public int height { get; set; }
        public string id { get; set; }
        public string link { get; set; }
        public Metadata130 metaData { get; set; }
        public string title { get; set; }
        public string type { get; set; }
        public string uri { get; set; }
        public int width { get; set; }
    }

    public class Metadata130
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class DataitemJ5hvpd2l
    {
        public string alt { get; set; }
        public string description { get; set; }
        public int height { get; set; }
        public string id { get; set; }
        public string link { get; set; }
        public Metadata131 metaData { get; set; }
        public string title { get; set; }
        public string type { get; set; }
        public string uri { get; set; }
        public int width { get; set; }
    }

    public class Metadata131
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class DataitemJ5hwacpm
    {
        public string id { get; set; }
        public Metadata132 metaData { get; set; }
        public string target { get; set; }
        public string type { get; set; }
        public string url { get; set; }
    }

    public class Metadata132
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class DataitemJ5hwb4jy
    {
        public string id { get; set; }
        public Metadata133 metaData { get; set; }
        public string target { get; set; }
        public string type { get; set; }
        public string url { get; set; }
    }

    public class Metadata133
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class DataitemJ7abm80n
    {
        public string alt { get; set; }
        public int height { get; set; }
        public string id { get; set; }
        public string link { get; set; }
        public Metadata134 metaData { get; set; }
        public string title { get; set; }
        public string type { get; set; }
        public string uri { get; set; }
        public int width { get; set; }
    }

    public class Metadata134
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class DataitemJ7abm80n1
    {
        public string id { get; set; }
        public Metadata135 metaData { get; set; }
        public string target { get; set; }
        public string type { get; set; }
        public string url { get; set; }
    }

    public class Metadata135
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class DataitemJ7zzukhm
    {
        public string id { get; set; }
        public bool isVisible { get; set; }
        public bool isVisibleMobile { get; set; }
        public object[] items { get; set; }
        public string label { get; set; }
        public string link { get; set; }
        public Metadata136 metaData { get; set; }
        public string type { get; set; }
    }

    public class Metadata136
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class DataitemJ7zzukhm1
    {
        public string id { get; set; }
        public Metadata137 metaData { get; set; }
        public string pageId { get; set; }
        public string target { get; set; }
        public string type { get; set; }
    }

    public class Metadata137
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class DataitemJ8a9760q
    {
        public string id { get; set; }
        public string menuRef { get; set; }
        public Metadata138 metaData { get; set; }
        public string type { get; set; }
    }

    public class Metadata138
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class DataitemJ9y1lr60
    {
        public string id { get; set; }
        public string label { get; set; }
        public string link { get; set; }
        public Metadata139 metaData { get; set; }
        public string type { get; set; }
    }

    public class Metadata139
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class DataitemJ9y1mu2z
    {
        public string id { get; set; }
        public Metadata140 metaData { get; set; }
        public string target { get; set; }
        public string type { get; set; }
        public string url { get; set; }
    }

    public class Metadata140
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class DataitemJg4v6trp
    {
        public string id { get; set; }
        public bool isVisible { get; set; }
        public bool isVisibleMobile { get; set; }
        public object[] items { get; set; }
        public string label { get; set; }
        public string link { get; set; }
        public Metadata141 metaData { get; set; }
        public string type { get; set; }
    }

    public class Metadata141
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class DataitemJg4v6trp1
    {
        public string id { get; set; }
        public Metadata142 metaData { get; set; }
        public string pageId { get; set; }
        public string target { get; set; }
        public string type { get; set; }
    }

    public class Metadata142
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class DataitemJg5at6bm
    {
        public string id { get; set; }
        public bool isVisible { get; set; }
        public bool isVisibleMobile { get; set; }
        public object[] items { get; set; }
        public string label { get; set; }
        public string link { get; set; }
        public Metadata143 metaData { get; set; }
        public string type { get; set; }
    }

    public class Metadata143
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class DataitemJg5at6bn
    {
        public string id { get; set; }
        public Metadata144 metaData { get; set; }
        public string pageId { get; set; }
        public string target { get; set; }
        public string type { get; set; }
    }

    public class Metadata144
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class DataitemJg6c64kn
    {
        public string id { get; set; }
        public bool isVisible { get; set; }
        public bool isVisibleMobile { get; set; }
        public object[] items { get; set; }
        public string label { get; set; }
        public string link { get; set; }
        public Metadata145 metaData { get; set; }
        public string type { get; set; }
    }

    public class Metadata145
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class DataitemJg6c64kn1
    {
        public string id { get; set; }
        public Metadata146 metaData { get; set; }
        public string pageId { get; set; }
        public string target { get; set; }
        public string type { get; set; }
    }

    public class Metadata146
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class DataitemJgf6he4x
    {
        public string id { get; set; }
        public Metadata147 metaData { get; set; }
        public string pageId { get; set; }
        public string type { get; set; }
    }

    public class Metadata147
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class DataitemJggdt3nr
    {
        public string anchorDataId { get; set; }
        public string anchorName { get; set; }
        public string id { get; set; }
        public Metadata148 metaData { get; set; }
        public string pageId { get; set; }
        public string type { get; set; }
    }

    public class Metadata148
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class DataitemJhw1023c
    {
        public string alt { get; set; }
        public string description { get; set; }
        public int height { get; set; }
        public string id { get; set; }
        public string link { get; set; }
        public Metadata149 metaData { get; set; }
        public string title { get; set; }
        public string type { get; set; }
        public string uri { get; set; }
        public int width { get; set; }
    }

    public class Metadata149
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class DataitemJhw1fv5m
    {
        public string id { get; set; }
        public Metadata150 metaData { get; set; }
        public string target { get; set; }
        public string type { get; set; }
        public string url { get; set; }
    }

    public class Metadata150
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class DataitemJiq4ytt7
    {
        public string id { get; set; }
        public bool isVisible { get; set; }
        public bool isVisibleMobile { get; set; }
        public object[] items { get; set; }
        public string label { get; set; }
        public string link { get; set; }
        public Metadata151 metaData { get; set; }
        public string type { get; set; }
    }

    public class Metadata151
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class DataitemJiq4ytt71
    {
        public string id { get; set; }
        public Metadata152 metaData { get; set; }
        public string pageId { get; set; }
        public string target { get; set; }
        public string type { get; set; }
    }

    public class Metadata152
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class DataitemJj8keiw3
    {
        public string id { get; set; }
        public bool isVisible { get; set; }
        public bool isVisibleMobile { get; set; }
        public object[] items { get; set; }
        public string label { get; set; }
        public string link { get; set; }
        public Metadata153 metaData { get; set; }
        public string type { get; set; }
    }

    public class Metadata153
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class DataitemJj8keiw31
    {
        public string id { get; set; }
        public Metadata154 metaData { get; set; }
        public string pageId { get; set; }
        public string target { get; set; }
        public string type { get; set; }
    }

    public class Metadata154
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class DataitemJja16l3a
    {
        public string id { get; set; }
        public bool isVisible { get; set; }
        public bool isVisibleMobile { get; set; }
        public object[] items { get; set; }
        public string label { get; set; }
        public string link { get; set; }
        public Metadata155 metaData { get; set; }
        public string type { get; set; }
    }

    public class Metadata155
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class DataitemJja16l3a1
    {
        public string id { get; set; }
        public Metadata156 metaData { get; set; }
        public string pageId { get; set; }
        public string target { get; set; }
        public string type { get; set; }
    }

    public class Metadata156
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class DataitemJja171ea
    {
        public string id { get; set; }
        public bool isVisible { get; set; }
        public bool isVisibleMobile { get; set; }
        public object[] items { get; set; }
        public string label { get; set; }
        public string link { get; set; }
        public Metadata157 metaData { get; set; }
        public string type { get; set; }
    }

    public class Metadata157
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class DataitemJja171ea1
    {
        public string id { get; set; }
        public Metadata158 metaData { get; set; }
        public string pageId { get; set; }
        public string target { get; set; }
        public string type { get; set; }
    }

    public class Metadata158
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class DataitemJja177ho
    {
        public string id { get; set; }
        public bool isVisible { get; set; }
        public bool isVisibleMobile { get; set; }
        public object[] items { get; set; }
        public string label { get; set; }
        public string link { get; set; }
        public Metadata159 metaData { get; set; }
        public string type { get; set; }
    }

    public class Metadata159
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class DataitemJja177ho1
    {
        public string id { get; set; }
        public Metadata160 metaData { get; set; }
        public string pageId { get; set; }
        public string target { get; set; }
        public string type { get; set; }
    }

    public class Metadata160
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class DataitemJja17fqb
    {
        public string id { get; set; }
        public bool isVisible { get; set; }
        public bool isVisibleMobile { get; set; }
        public object[] items { get; set; }
        public string label { get; set; }
        public string link { get; set; }
        public Metadata161 metaData { get; set; }
        public string type { get; set; }
    }

    public class Metadata161
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class DataitemJja17fqb1
    {
        public string id { get; set; }
        public Metadata162 metaData { get; set; }
        public string pageId { get; set; }
        public string target { get; set; }
        public string type { get; set; }
    }

    public class Metadata162
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class DataitemJlzb8zcj
    {
        public string id { get; set; }
        public bool isVisible { get; set; }
        public bool isVisibleMobile { get; set; }
        public object[] items { get; set; }
        public string label { get; set; }
        public string link { get; set; }
        public Metadata163 metaData { get; set; }
        public string type { get; set; }
    }

    public class Metadata163
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class DataitemJlzb8zcj1
    {
        public string id { get; set; }
        public Metadata164 metaData { get; set; }
        public string pageId { get; set; }
        public string target { get; set; }
        public string type { get; set; }
    }

    public class Metadata164
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class DataitemJmhheynl
    {
        public string id { get; set; }
        public string[] linkList { get; set; }
        public Metadata165 metaData { get; set; }
        public string stylesMapId { get; set; }
        public string text { get; set; }
        public string type { get; set; }
    }

    public class Metadata165
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class E1ym1
    {
        public int appInnerID { get; set; }
        public string appPageId { get; set; }
        public string appPageType { get; set; }
        public string descriptionSEO { get; set; }
        public bool hidePage { get; set; }
        public bool hideTitle { get; set; }
        public string id { get; set; }
        public bool indexable { get; set; }
        public bool isLandingPage { get; set; }
        public bool isMobileLandingPage { get; set; }
        public bool isPopup { get; set; }
        public Metadata166 metaData { get; set; }
        public string metaKeywordsSEO { get; set; }
        public bool mobileHidePage { get; set; }
        public Pagebackgrounds3 pageBackgrounds { get; set; }
        public Pagesecurity3 pageSecurity { get; set; }
        public string pageTitleSEO { get; set; }
        public string pageUriSEO { get; set; }
        public bool repeaterPage { get; set; }
        public string title { get; set; }
        public int tpaApplicationId { get; set; }
        public Translationdata3 translationData { get; set; }
        public string type { get; set; }
        public bool underConstruction { get; set; }
    }

    public class Metadata166
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Pagebackgrounds3
    {
        public Desktop5 desktop { get; set; }
        public Mobile4 mobile { get; set; }
    }

    public class Desktop5
    {
        public bool custom { get; set; }
        public bool isPreset { get; set; }
        public string _ref { get; set; }
    }

    public class Mobile4
    {
        public bool custom { get; set; }
        public bool isPreset { get; set; }
        public string _ref { get; set; }
    }

    public class Pagesecurity3
    {
        public string passwordDigest { get; set; }
        public bool requireLogin { get; set; }
    }

    public class Translationdata3
    {
        public bool uriSEOTranslated { get; set; }
    }

    public class E4jlk
    {
        public string descriptionSEO { get; set; }
        public bool hidePage { get; set; }
        public bool hideTitle { get; set; }
        public string icon { get; set; }
        public string id { get; set; }
        public bool indexable { get; set; }
        public bool isLandingPage { get; set; }
        public bool isMobileLandingPage { get; set; }
        public bool isPopup { get; set; }
        public Metadata167 metaData { get; set; }
        public string metaKeywordsSEO { get; set; }
        public Pagebackgrounds4 pageBackgrounds { get; set; }
        public Pagesecurity4 pageSecurity { get; set; }
        public string pageTitleSEO { get; set; }
        public string pageUriSEO { get; set; }
        public string title { get; set; }
        public int tpaApplicationId { get; set; }
        public Translationdata4 translationData { get; set; }
        public string type { get; set; }
        public bool underConstruction { get; set; }
    }

    public class Metadata167
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Pagebackgrounds4
    {
        public Desktop6 desktop { get; set; }
        public Mobile5 mobile { get; set; }
    }

    public class Desktop6
    {
        public bool custom { get; set; }
        public bool isPreset { get; set; }
        public string _ref { get; set; }
    }

    public class Mobile5
    {
        public bool custom { get; set; }
        public bool isPreset { get; set; }
        public string mediaSizing { get; set; }
        public string _ref { get; set; }
    }

    public class Pagesecurity4
    {
        public string dialogLanguage { get; set; }
        public string passwordDigest { get; set; }
        public bool requireLogin { get; set; }
    }

    public class Translationdata4
    {
        public bool uriSEOTranslated { get; set; }
    }

    public class Eixbx
    {
        public string descriptionSEO { get; set; }
        public bool hidePage { get; set; }
        public bool hideTitle { get; set; }
        public string icon { get; set; }
        public string id { get; set; }
        public bool indexable { get; set; }
        public bool isLandingPage { get; set; }
        public bool isMobileLandingPage { get; set; }
        public bool isPopup { get; set; }
        public Metadata168 metaData { get; set; }
        public string metaKeywordsSEO { get; set; }
        public Pagebackgrounds5 pageBackgrounds { get; set; }
        public Pagesecurity5 pageSecurity { get; set; }
        public string pageTitleSEO { get; set; }
        public string pageUriSEO { get; set; }
        public string title { get; set; }
        public int tpaApplicationId { get; set; }
        public Translationdata5 translationData { get; set; }
        public string type { get; set; }
        public bool underConstruction { get; set; }
    }

    public class Metadata168
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Pagebackgrounds5
    {
        public Desktop7 desktop { get; set; }
        public Mobile6 mobile { get; set; }
    }

    public class Desktop7
    {
        public bool custom { get; set; }
        public bool isPreset { get; set; }
        public string _ref { get; set; }
    }

    public class Mobile6
    {
        public bool custom { get; set; }
        public bool isPreset { get; set; }
        public string mediaSizing { get; set; }
        public string _ref { get; set; }
    }

    public class Pagesecurity5
    {
        public string dialogLanguage { get; set; }
        public string passwordDigest { get; set; }
        public bool requireLogin { get; set; }
    }

    public class Translationdata5
    {
        public bool uriSEOTranslated { get; set; }
    }

    public class Fjayw
    {
        public string descriptionSEO { get; set; }
        public bool hidePage { get; set; }
        public bool hideTitle { get; set; }
        public string icon { get; set; }
        public string id { get; set; }
        public bool indexable { get; set; }
        public bool isLandingPage { get; set; }
        public bool isMobileLandingPage { get; set; }
        public bool isPopup { get; set; }
        public Metadata169 metaData { get; set; }
        public string metaKeywordsSEO { get; set; }
        public Pagebackgrounds6 pageBackgrounds { get; set; }
        public Pagesecurity6 pageSecurity { get; set; }
        public string pageTitleSEO { get; set; }
        public string pageUriSEO { get; set; }
        public string title { get; set; }
        public int tpaApplicationId { get; set; }
        public Translationdata6 translationData { get; set; }
        public string type { get; set; }
        public bool underConstruction { get; set; }
    }

    public class Metadata169
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Pagebackgrounds6
    {
        public Desktop8 desktop { get; set; }
        public Mobile7 mobile { get; set; }
    }

    public class Desktop8
    {
        public bool custom { get; set; }
        public bool isPreset { get; set; }
        public string _ref { get; set; }
    }

    public class Mobile7
    {
        public bool custom { get; set; }
        public bool isPreset { get; set; }
        public string mediaSizing { get; set; }
        public string _ref { get; set; }
    }

    public class Pagesecurity6
    {
        public string dialogLanguage { get; set; }
        public string passwordDigest { get; set; }
        public bool requireLogin { get; set; }
    }

    public class Translationdata6
    {
        public bool uriSEOTranslated { get; set; }
    }

    public class Gmmt9
    {
        public string descriptionSEO { get; set; }
        public bool hidePage { get; set; }
        public bool hideTitle { get; set; }
        public string icon { get; set; }
        public string id { get; set; }
        public bool indexable { get; set; }
        public bool isLandingPage { get; set; }
        public bool isMobileLandingPage { get; set; }
        public bool isPopup { get; set; }
        public Metadata170 metaData { get; set; }
        public string metaKeywordsSEO { get; set; }
        public Pagebackgrounds7 pageBackgrounds { get; set; }
        public Pagesecurity7 pageSecurity { get; set; }
        public string pageTitleSEO { get; set; }
        public string pageUriSEO { get; set; }
        public string title { get; set; }
        public int tpaApplicationId { get; set; }
        public Translationdata7 translationData { get; set; }
        public string type { get; set; }
        public bool underConstruction { get; set; }
    }

    public class Metadata170
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Pagebackgrounds7
    {
        public Desktop9 desktop { get; set; }
        public Mobile8 mobile { get; set; }
    }

    public class Desktop9
    {
        public bool custom { get; set; }
        public bool isPreset { get; set; }
        public string _ref { get; set; }
    }

    public class Mobile8
    {
        public bool custom { get; set; }
        public bool isPreset { get; set; }
        public string mediaSizing { get; set; }
        public string _ref { get; set; }
    }

    public class Pagesecurity7
    {
        public string dialogLanguage { get; set; }
        public string passwordDigest { get; set; }
        public bool requireLogin { get; set; }
    }

    public class Translationdata7
    {
        public bool uriSEOTranslated { get; set; }
    }

    public class H3lrw
    {
        public string descriptionSEO { get; set; }
        public bool hidePage { get; set; }
        public bool hideTitle { get; set; }
        public string icon { get; set; }
        public string id { get; set; }
        public bool indexable { get; set; }
        public bool isLandingPage { get; set; }
        public bool isMobileLandingPage { get; set; }
        public bool isPopup { get; set; }
        public Metadata171 metaData { get; set; }
        public string metaKeywordsSEO { get; set; }
        public Pagebackgrounds8 pageBackgrounds { get; set; }
        public Pagesecurity8 pageSecurity { get; set; }
        public string pageTitleSEO { get; set; }
        public string pageUriSEO { get; set; }
        public string title { get; set; }
        public int tpaApplicationId { get; set; }
        public Translationdata8 translationData { get; set; }
        public string type { get; set; }
        public bool underConstruction { get; set; }
    }

    public class Metadata171
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Pagebackgrounds8
    {
        public Desktop10 desktop { get; set; }
        public Mobile9 mobile { get; set; }
    }

    public class Desktop10
    {
        public bool custom { get; set; }
        public bool isPreset { get; set; }
        public string _ref { get; set; }
    }

    public class Mobile9
    {
        public bool custom { get; set; }
        public bool isPreset { get; set; }
        public string mediaSizing { get; set; }
        public string _ref { get; set; }
    }

    public class Pagesecurity8
    {
        public string dialogLanguage { get; set; }
        public string passwordDigest { get; set; }
        public bool requireLogin { get; set; }
    }

    public class Translationdata8
    {
        public bool uriSEOTranslated { get; set; }
    }

    public class I35k6
    {
        public string descriptionSEO { get; set; }
        public bool hidePage { get; set; }
        public bool hideTitle { get; set; }
        public string icon { get; set; }
        public string id { get; set; }
        public bool indexable { get; set; }
        public bool isLandingPage { get; set; }
        public bool isMobileLandingPage { get; set; }
        public bool isPopup { get; set; }
        public Metadata172 metaData { get; set; }
        public string metaKeywordsSEO { get; set; }
        public Pagebackgrounds9 pageBackgrounds { get; set; }
        public Pagesecurity9 pageSecurity { get; set; }
        public string pageTitleSEO { get; set; }
        public string pageUriSEO { get; set; }
        public string title { get; set; }
        public int tpaApplicationId { get; set; }
        public Translationdata9 translationData { get; set; }
        public string type { get; set; }
        public bool underConstruction { get; set; }
    }

    public class Metadata172
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Pagebackgrounds9
    {
        public Desktop11 desktop { get; set; }
        public Mobile10 mobile { get; set; }
    }

    public class Desktop11
    {
        public bool custom { get; set; }
        public bool isPreset { get; set; }
        public string _ref { get; set; }
    }

    public class Mobile10
    {
        public bool custom { get; set; }
        public bool isPreset { get; set; }
        public string mediaSizing { get; set; }
        public string _ref { get; set; }
    }

    public class Pagesecurity9
    {
        public string dialogLanguage { get; set; }
        public string passwordDigest { get; set; }
        public bool requireLogin { get; set; }
    }

    public class Translationdata9
    {
        public bool uriSEOTranslated { get; set; }
    }

    public class Iynz9
    {
        public string descriptionSEO { get; set; }
        public bool hidePage { get; set; }
        public bool hideTitle { get; set; }
        public string icon { get; set; }
        public string id { get; set; }
        public bool indexable { get; set; }
        public bool isLandingPage { get; set; }
        public bool isMobileLandingPage { get; set; }
        public bool isPopup { get; set; }
        public Metadata173 metaData { get; set; }
        public string metaKeywordsSEO { get; set; }
        public bool mobileHidePage { get; set; }
        public string ogImage { get; set; }
        public Pagebackgrounds10 pageBackgrounds { get; set; }
        public Pagesecurity10 pageSecurity { get; set; }
        public string pageTitleSEO { get; set; }
        public string pageUriSEO { get; set; }
        public string title { get; set; }
        public int tpaApplicationId { get; set; }
        public Translationdata10 translationData { get; set; }
        public string type { get; set; }
        public bool underConstruction { get; set; }
    }

    public class Metadata173
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Pagebackgrounds10
    {
        public Desktop12 desktop { get; set; }
        public Mobile11 mobile { get; set; }
    }

    public class Desktop12
    {
        public bool custom { get; set; }
        public bool isPreset { get; set; }
        public string _ref { get; set; }
    }

    public class Mobile11
    {
        public bool custom { get; set; }
        public bool isPreset { get; set; }
        public string mediaSizing { get; set; }
        public string _ref { get; set; }
    }

    public class Pagesecurity10
    {
        public string dialogLanguage { get; set; }
        public string passwordDigest { get; set; }
        public bool requireLogin { get; set; }
    }

    public class Translationdata10
    {
        public bool uriSEOTranslated { get; set; }
    }

    public class Ma897
    {
        public string descriptionSEO { get; set; }
        public bool hidePage { get; set; }
        public bool hideTitle { get; set; }
        public string icon { get; set; }
        public string id { get; set; }
        public bool indexable { get; set; }
        public bool isLandingPage { get; set; }
        public bool isMobileLandingPage { get; set; }
        public bool isPopup { get; set; }
        public Metadata174 metaData { get; set; }
        public string metaKeywordsSEO { get; set; }
        public Pagebackgrounds11 pageBackgrounds { get; set; }
        public Pagesecurity11 pageSecurity { get; set; }
        public string pageTitleSEO { get; set; }
        public string pageUriSEO { get; set; }
        public string title { get; set; }
        public int tpaApplicationId { get; set; }
        public Translationdata11 translationData { get; set; }
        public string type { get; set; }
        public bool underConstruction { get; set; }
    }

    public class Metadata174
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Pagebackgrounds11
    {
        public Desktop13 desktop { get; set; }
        public Mobile12 mobile { get; set; }
    }

    public class Desktop13
    {
        public bool custom { get; set; }
        public bool isPreset { get; set; }
        public string _ref { get; set; }
    }

    public class Mobile12
    {
        public bool custom { get; set; }
        public bool isPreset { get; set; }
        public string mediaSizing { get; set; }
        public string _ref { get; set; }
    }

    public class Pagesecurity11
    {
        public string dialogLanguage { get; set; }
        public string passwordDigest { get; set; }
        public bool requireLogin { get; set; }
    }

    public class Translationdata11
    {
        public bool uriSEOTranslated { get; set; }
    }

    public class Masterpage1
    {
        public string[] characterSets { get; set; }
        public string id { get; set; }
        public bool ignoreBottomBottomAnchors { get; set; }
        public Layoutsettings layoutSettings { get; set; }
        public string mainPage { get; set; }
        public string mainPageId { get; set; }
        public Metadata175 metaData { get; set; }
        public Mobilesettings mobileSettings { get; set; }
        public Rendermodifiers renderModifiers { get; set; }
        public string siteName { get; set; }
        public Smsettings smSettings { get; set; }
        public string type { get; set; }
        public object[] usedFonts { get; set; }
    }

    public class Layoutsettings
    {
        public string mechanism { get; set; }
        public bool soapCompsAroundPagesContainer { get; set; }
        public bool useDesktopSectionsLayout { get; set; }
    }

    public class Metadata175
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Mobilesettings
    {
        public bool animationsEnabled { get; set; }
    }

    public class Rendermodifiers
    {
        public bool pageAutoShrink { get; set; }
    }

    public class Smsettings
    {
        public bool socialLoginFacebookEnabled { get; set; }
        public bool socialLoginGoogleEnabled { get; set; }
    }

    public class P3eb1
    {
        public string descriptionSEO { get; set; }
        public bool hidePage { get; set; }
        public bool hideTitle { get; set; }
        public string icon { get; set; }
        public string id { get; set; }
        public bool indexable { get; set; }
        public bool isLandingPage { get; set; }
        public bool isMobileLandingPage { get; set; }
        public bool isPopup { get; set; }
        public Metadata176 metaData { get; set; }
        public string metaKeywordsSEO { get; set; }
        public Pagebackgrounds12 pageBackgrounds { get; set; }
        public Pagesecurity12 pageSecurity { get; set; }
        public string pageTitleSEO { get; set; }
        public string pageUriSEO { get; set; }
        public string title { get; set; }
        public int tpaApplicationId { get; set; }
        public Translationdata12 translationData { get; set; }
        public string type { get; set; }
        public bool underConstruction { get; set; }
    }

    public class Metadata176
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Pagebackgrounds12
    {
        public Desktop14 desktop { get; set; }
        public Mobile13 mobile { get; set; }
    }

    public class Desktop14
    {
        public bool custom { get; set; }
        public bool isPreset { get; set; }
        public string _ref { get; set; }
    }

    public class Mobile13
    {
        public bool custom { get; set; }
        public bool isPreset { get; set; }
        public string mediaSizing { get; set; }
        public string _ref { get; set; }
    }

    public class Pagesecurity12
    {
        public string dialogLanguage { get; set; }
        public string passwordDigest { get; set; }
        public bool requireLogin { get; set; }
    }

    public class Translationdata12
    {
        public bool uriSEOTranslated { get; set; }
    }

    public class Pst14
    {
        public string appType { get; set; }
        public string dataItemRef { get; set; }
        public string id { get; set; }
        public Metadata177 metaData { get; set; }
        public string mutableSeoTitle { get; set; }
        public string type { get; set; }
    }

    public class Metadata177
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class R6p4e
    {
        public string descriptionSEO { get; set; }
        public bool hidePage { get; set; }
        public bool hideTitle { get; set; }
        public string icon { get; set; }
        public string id { get; set; }
        public bool indexable { get; set; }
        public bool isLandingPage { get; set; }
        public bool isMobileLandingPage { get; set; }
        public bool isPopup { get; set; }
        public Metadata178 metaData { get; set; }
        public string metaKeywordsSEO { get; set; }
        public Pagebackgrounds13 pageBackgrounds { get; set; }
        public Pagesecurity13 pageSecurity { get; set; }
        public string pageTitleSEO { get; set; }
        public string pageUriSEO { get; set; }
        public string title { get; set; }
        public int tpaApplicationId { get; set; }
        public Translationdata13 translationData { get; set; }
        public string type { get; set; }
        public bool underConstruction { get; set; }
    }

    public class Metadata178
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Pagebackgrounds13
    {
        public Desktop15 desktop { get; set; }
        public Mobile14 mobile { get; set; }
    }

    public class Desktop15
    {
        public bool custom { get; set; }
        public bool isPreset { get; set; }
        public string _ref { get; set; }
    }

    public class Mobile14
    {
        public bool custom { get; set; }
        public bool isPreset { get; set; }
        public string mediaSizing { get; set; }
        public string _ref { get; set; }
    }

    public class Pagesecurity13
    {
        public string dialogLanguage { get; set; }
        public string passwordDigest { get; set; }
        public bool requireLogin { get; set; }
    }

    public class Translationdata13
    {
        public bool uriSEOTranslated { get; set; }
    }

    public class Sxcn6
    {
        public int appInnerID { get; set; }
        public string appPageId { get; set; }
        public string appPageType { get; set; }
        public string descriptionSEO { get; set; }
        public bool hidePage { get; set; }
        public bool hideTitle { get; set; }
        public string icon { get; set; }
        public string id { get; set; }
        public bool indexable { get; set; }
        public bool isLandingPage { get; set; }
        public bool isMobileLandingPage { get; set; }
        public bool isPopup { get; set; }
        public Metadata179 metaData { get; set; }
        public string metaKeywordsSEO { get; set; }
        public Pagebackgrounds14 pageBackgrounds { get; set; }
        public Pagesecurity14 pageSecurity { get; set; }
        public string pageTitleSEO { get; set; }
        public string pageUriSEO { get; set; }
        public bool repeaterPage { get; set; }
        public string title { get; set; }
        public int tpaApplicationId { get; set; }
        public Translationdata14 translationData { get; set; }
        public string type { get; set; }
        public bool underConstruction { get; set; }
    }

    public class Metadata179
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Pagebackgrounds14
    {
        public Desktop16 desktop { get; set; }
        public Mobile15 mobile { get; set; }
    }

    public class Desktop16
    {
        public bool custom { get; set; }
        public bool isPreset { get; set; }
        public string _ref { get; set; }
    }

    public class Mobile15
    {
        public bool custom { get; set; }
        public bool isPreset { get; set; }
        public string mediaSizing { get; set; }
        public string _ref { get; set; }
    }

    public class Pagesecurity14
    {
        public bool requireLogin { get; set; }
    }

    public class Translationdata14
    {
        public bool uriSEOTranslated { get; set; }
    }

    public class Textlink_Jmhhgsfe
    {
        public string id { get; set; }
        public Metadata180 metaData { get; set; }
        public string pageId { get; set; }
        public string target { get; set; }
        public string type { get; set; }
    }

    public class Metadata180
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Uca7v
    {
        public string descriptionSEO { get; set; }
        public bool hidePage { get; set; }
        public bool hideTitle { get; set; }
        public string icon { get; set; }
        public string id { get; set; }
        public bool indexable { get; set; }
        public bool isLandingPage { get; set; }
        public bool isMobileLandingPage { get; set; }
        public bool isPopup { get; set; }
        public Metadata181 metaData { get; set; }
        public string metaKeywordsSEO { get; set; }
        public Pagebackgrounds15 pageBackgrounds { get; set; }
        public Pagesecurity15 pageSecurity { get; set; }
        public string pageTitleSEO { get; set; }
        public string pageUriSEO { get; set; }
        public string title { get; set; }
        public int tpaApplicationId { get; set; }
        public Translationdata15 translationData { get; set; }
        public string type { get; set; }
        public bool underConstruction { get; set; }
    }

    public class Metadata181
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Pagebackgrounds15
    {
        public Desktop17 desktop { get; set; }
        public Mobile16 mobile { get; set; }
    }

    public class Desktop17
    {
        public bool custom { get; set; }
        public bool isPreset { get; set; }
        public string _ref { get; set; }
    }

    public class Mobile16
    {
        public bool custom { get; set; }
        public bool isPreset { get; set; }
        public string mediaSizing { get; set; }
        public string _ref { get; set; }
    }

    public class Pagesecurity15
    {
        public string dialogLanguage { get; set; }
        public string passwordDigest { get; set; }
        public bool requireLogin { get; set; }
    }

    public class Translationdata15
    {
        public bool uriSEOTranslated { get; set; }
    }

    public class Vn92i
    {
        public string descriptionSEO { get; set; }
        public bool hidePage { get; set; }
        public bool hideTitle { get; set; }
        public string icon { get; set; }
        public string id { get; set; }
        public bool indexable { get; set; }
        public bool isLandingPage { get; set; }
        public bool isMobileLandingPage { get; set; }
        public bool isPopup { get; set; }
        public Metadata182 metaData { get; set; }
        public string metaKeywordsSEO { get; set; }
        public Pagebackgrounds16 pageBackgrounds { get; set; }
        public Pagesecurity16 pageSecurity { get; set; }
        public string pageTitleSEO { get; set; }
        public string pageUriSEO { get; set; }
        public string title { get; set; }
        public int tpaApplicationId { get; set; }
        public Translationdata16 translationData { get; set; }
        public string type { get; set; }
        public bool underConstruction { get; set; }
    }

    public class Metadata182
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Pagebackgrounds16
    {
        public Desktop18 desktop { get; set; }
        public Mobile17 mobile { get; set; }
    }

    public class Desktop18
    {
        public bool custom { get; set; }
        public bool isPreset { get; set; }
        public string _ref { get; set; }
    }

    public class Mobile17
    {
        public bool custom { get; set; }
        public bool isPreset { get; set; }
        public string mediaSizing { get; set; }
        public string _ref { get; set; }
    }

    public class Pagesecurity16
    {
        public string dialogLanguage { get; set; }
        public string passwordDigest { get; set; }
        public bool requireLogin { get; set; }
    }

    public class Translationdata16
    {
        public bool uriSEOTranslated { get; set; }
    }

    public class Ygaqm
    {
        public string descriptionSEO { get; set; }
        public bool hidePage { get; set; }
        public bool hideTitle { get; set; }
        public string icon { get; set; }
        public string id { get; set; }
        public bool indexable { get; set; }
        public bool isLandingPage { get; set; }
        public bool isMobileLandingPage { get; set; }
        public bool isPopup { get; set; }
        public Metadata183 metaData { get; set; }
        public string metaKeywordsSEO { get; set; }
        public Pagebackgrounds17 pageBackgrounds { get; set; }
        public Pagesecurity17 pageSecurity { get; set; }
        public string pageTitleSEO { get; set; }
        public string pageUriSEO { get; set; }
        public string title { get; set; }
        public int tpaApplicationId { get; set; }
        public Translationdata17 translationData { get; set; }
        public string type { get; set; }
        public bool underConstruction { get; set; }
    }

    public class Metadata183
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Pagebackgrounds17
    {
        public Desktop19 desktop { get; set; }
        public Mobile18 mobile { get; set; }
    }

    public class Desktop19
    {
        public bool custom { get; set; }
        public bool isPreset { get; set; }
        public string _ref { get; set; }
    }

    public class Mobile18
    {
        public bool custom { get; set; }
        public bool isPreset { get; set; }
        public string mediaSizing { get; set; }
        public string _ref { get; set; }
    }

    public class Pagesecurity17
    {
        public string dialogLanguage { get; set; }
        public string passwordDigest { get; set; }
        public bool requireLogin { get; set; }
    }

    public class Translationdata17
    {
        public bool uriSEOTranslated { get; set; }
    }

    public class Mobile_Hints1
    {
        public MobilehintsJ9y1ofsf mobileHintsj9y1ofsf { get; set; }
        public MobilehintsJfw9bfc7 mobileHintsjfw9bfc7 { get; set; }
        public MobilehintsJgdpjtav mobileHintsjgdpjtav { get; set; }
        public MobilehintsJgdpjtaz mobileHintsjgdpjtaz { get; set; }
        public MobilehintsJgg7p3gj mobileHintsjgg7p3gj { get; set; }
        public MobilehintsJmhheys2 mobileHintsjmhheys2 { get; set; }
    }

    public class MobilehintsJ9y1ofsf
    {
        public bool hidden { get; set; }
        public string id { get; set; }
        public string type { get; set; }
    }

    public class MobilehintsJfw9bfc7
    {
        public bool hidden { get; set; }
        public string id { get; set; }
        public string type { get; set; }
    }

    public class MobilehintsJgdpjtav
    {
        public string author { get; set; }
        public bool hidden { get; set; }
        public string id { get; set; }
        public string offsetOrigin { get; set; }
        public int offsetX { get; set; }
        public int offsetY { get; set; }
        public int orderIndex { get; set; }
        public int recommendedHeight { get; set; }
        public int recommendedScale { get; set; }
        public int recommendedWidth { get; set; }
        public string type { get; set; }
    }

    public class MobilehintsJgdpjtaz
    {
        public string author { get; set; }
        public bool hidden { get; set; }
        public string id { get; set; }
        public int recommendedHeight { get; set; }
        public int recommendedScale { get; set; }
        public int recommendedWidth { get; set; }
        public string type { get; set; }
    }

    public class MobilehintsJgg7p3gj
    {
        public bool hidden { get; set; }
        public string id { get; set; }
        public string type { get; set; }
    }

    public class MobilehintsJmhheys2
    {
        public string author { get; set; }
        public string id { get; set; }
        public string originalCompId { get; set; }
        public int recommendedHeight { get; set; }
        public float recommendedScale { get; set; }
        public int recommendedWidth { get; set; }
        public string type { get; set; }
    }

    public class Theme_Data1
    {
        public Anchor_1 Anchor_1 { get; set; }
        public Imagebutton_1 ImageButton_1 { get; set; }
        public Singleaudioplayer_1 SingleAudioPlayer_1 { get; set; }
        public THEME_DATA2 THEME_DATA { get; set; }
        public Ap1 ap1 { get; set; }
        public Ap2 ap2 { get; set; }
        public B1 b1 { get; set; }
        public B2 b2 { get; set; }
        public B3 b3 { get; set; }
        public B4 b4 { get; set; }
        public Bgis1 bgis1 { get; set; }
        public Bgis2 bgis2 { get; set; }
        public Bgis3 bgis3 { get; set; }
        public Bgis4 bgis4 { get; set; }
        public Blog_33A9f5e0B0834CccB55d3Ca5d241a6eb_1 blog_33a9f5e0b0834cccb55d3ca5d241a6eb_1 { get; set; }
        public Blog_4656A63cB3164315Ab16E2003f5935ca_1 blog_4656a63cb3164315ab16e2003f5935ca_1 { get; set; }
        public Blog_4De5abc56Da24F97Acc394Bb74285072_1 blog_4de5abc56da24f97acc394bb74285072_1 { get; set; }
        public Blog_56Ab6fa495Ac439193376702B8a77011_1 blog_56ab6fa495ac439193376702b8a77011_1 { get; set; }
        public Blog_E000b4bf9Ff14E66A0d3D4b365ba3af5_1 blog_e000b4bf9ff14e66a0d3d4b365ba3af5_1 { get; set; }
        public Blog_F72fe3778Abc40F2865689Cfe00f3a22_1 blog_f72fe3778abc40f2865689cfe00f3a22_1 { get; set; }
        public C1 c1 { get; set; }
        public C2 c2 { get; set; }
        public C3 c3 { get; set; }
        public C4 c4 { get; set; }
        public Ca1 ca1 { get; set; }
        public Cf1 cf1 { get; set; }
        public Cf2 cf2 { get; set; }
        public Controller1 controller1 { get; set; }
        public Ddm1 ddm1 { get; set; }
        public Ddm2 ddm2 { get; set; }
        public Ddm3 ddm3 { get; set; }
        public Eib1 eib1 { get; set; }
        public Fbc1 fbc1 { get; set; }
        public Fbl1 fbl1 { get; set; }
        public Fc1 fc1 { get; set; }
        public Fc2 fc2 { get; set; }
        public Fc3 fc3 { get; set; }
        public Fk1 fk1 { get; set; }
        public Gm1 gm1 { get; set; }
        public Gp1 gp1 { get; set; }
        public Hc1 hc1 { get; set; }
        public Hc2 hc2 { get; set; }
        public Hc3 hc3 { get; set; }
        public Hl1 hl1 { get; set; }
        public Hl2 hl2 { get; set; }
        public Hl3 hl3 { get; set; }
        public Hl4 hl4 { get; set; }
        public Htco1 htco1 { get; set; }
        public Lb1 lb1 { get; set; }
        public Mc1 mc1 { get; set; }
        public Mg1 mg1 { get; set; }
        public Mg2 mg2 { get; set; }
        public Mg3 mg3 { get; set; }
        public Mp1 mp1 { get; set; }
        public P1 p1 { get; set; }
        public P2 p2 { get; set; }
        public P3 p3 { get; set; }
        public Pagg1 pagg1 { get; set; }
        public Pagg2 pagg2 { get; set; }
        public Pagg3 pagg3 { get; set; }
        public Pc1 pc1 { get; set; }
        public Pc2 pc2 { get; set; }
        public Sc1 sc1 { get; set; }
        public Sc2 sc2 { get; set; }
        public Sc3 sc3 { get; set; }
        public Sc4 sc4 { get; set; }
        public Scw1 scw1 { get; set; }
        public Sg1 sg1 { get; set; }
        public Sg2 sg2 { get; set; }
        public Sg3 sg3 { get; set; }
        public Ssg1 ssg1 { get; set; }
        public Ssg2 ssg2 { get; set; }
        public Ssg3 ssg3 { get; set; }
        public Strc1 strc1 { get; set; }
        public StyleJ13ihxnb stylej13ihxnb { get; set; }
        public StyleJ2hjhcq5 stylej2hjhcq5 { get; set; }
        public StyleJ2hjjx6q stylej2hjjx6q { get; set; }
        public StyleJ2hk2u4i stylej2hk2u4i { get; set; }
        public StyleJ2hk42d7 stylej2hk42d7 { get; set; }
        public StyleJ2hk5vl2 stylej2hk5vl2 { get; set; }
        public StyleJ2hk6z8j stylej2hk6z8j { get; set; }
        public StyleJ2hnpdu2 stylej2hnpdu2 { get; set; }
        public StyleJ3bhljbe stylej3bhljbe { get; set; }
        public StyleJ3blz3eo stylej3blz3eo { get; set; }
        public StyleJ4dz9as6 stylej4dz9as6 { get; set; }
        public StyleJ4dzdbaq stylej4dzdbaq { get; set; }
        public StyleJ4idd1um1 stylej4idd1um1 { get; set; }
        public StyleJ4nw2ymi stylej4nw2ymi { get; set; }
        public StyleJ4nw81di stylej4nw81di { get; set; }
        public StyleJ4nwd9dr stylej4nwd9dr { get; set; }
        public StyleJ4nwdxip stylej4nwdxip { get; set; }
        public StyleJ4nwerfg stylej4nwerfg { get; set; }
        public StyleJ4nwffwv stylej4nwffwv { get; set; }
        public StyleJ4nwihwq stylej4nwihwq { get; set; }
        public StyleJ4nwj2ri stylej4nwj2ri { get; set; }
        public StyleJ4nwju9u stylej4nwju9u { get; set; }
        public StyleJ4nwkja3 stylej4nwkja3 { get; set; }
        public StyleJ4nwl8wp stylej4nwl8wp { get; set; }
        public StyleJ4nwlxwh stylej4nwlxwh { get; set; }
        public StyleJ4nwmmkt stylej4nwmmkt { get; set; }
        public StyleJ4nwnkdb stylej4nwnkdb { get; set; }
        public StyleJ4nwoccm stylej4nwoccm { get; set; }
        public StyleJ4nwovp1 stylej4nwovp1 { get; set; }
        public StyleJ4nwqzkv stylej4nwqzkv { get; set; }
        public StyleJ4nwwq4v stylej4nwwq4v { get; set; }
        public StyleJ4nwxgqq stylej4nwxgqq { get; set; }
        public StyleJ4nwy5tl stylej4nwy5tl { get; set; }
        public StyleJ4nx0f5m stylej4nx0f5m { get; set; }
        public StyleJ4nx1fj9 stylej4nx1fj9 { get; set; }
        public StyleJ4nx21jo stylej4nx21jo { get; set; }
        public StyleJ4nx3lr5 stylej4nx3lr5 { get; set; }
        public StyleJ4nx8nhl stylej4nx8nhl { get; set; }
        public StyleJ4nx9dsw stylej4nx9dsw { get; set; }
        public StyleJ4nxabh0 stylej4nxabh0 { get; set; }
        public StyleJ4nxb41k stylej4nxb41k { get; set; }
        public StyleJ4nxcwew stylej4nxcwew { get; set; }
        public StyleJ4nxeqsv stylej4nxeqsv { get; set; }
        public StyleJ4nxfnb6 stylej4nxfnb6 { get; set; }
        public StyleJ4nxgbsl stylej4nxgbsl { get; set; }
        public StyleJ4pepbim stylej4pepbim { get; set; }
        public StyleJ4trapsg stylej4trapsg { get; set; }
        public StyleJ58c1was stylej58c1was { get; set; }
        public StyleJ7zzukiu stylej7zzukiu { get; set; }
        public StyleJ7zzukja stylej7zzukja { get; set; }
        public StyleJc6cw4sv stylejc6cw4sv { get; set; }
        public StyleJeio7caz stylejeio7caz { get; set; }
        public StyleJg4v6ttc stylejg4v6ttc { get; set; }
        public StyleJg4v6tu0 stylejg4v6tu0 { get; set; }
        public StyleJg4v6tut stylejg4v6tut { get; set; }
        public StyleJg5at6c6 stylejg5at6c6 { get; set; }
        public StyleJg5at6ch2 stylejg5at6ch2 { get; set; }
        public StyleJg5at6cy1 stylejg5at6cy1 { get; set; }
        public StyleJg5b58zb stylejg5b58zb { get; set; }
        public StyleJg6c64nn stylejg6c64nn { get; set; }
        public StyleJg6c64o41 stylejg6c64o41 { get; set; }
        public StyleJgc98b01 stylejgc98b01 { get; set; }
        public StyleJgdxpwm9 stylejgdxpwm9 { get; set; }
        public StyleJhw1scy2 stylejhw1scy2 { get; set; }
        public StyleJhw1sczs stylejhw1sczs { get; set; }
        public StyleJipr3rtq stylejipr3rtq { get; set; }
        public StyleJipr7q42 stylejipr7q42 { get; set; }
        public StyleJiprcuqa stylejiprcuqa { get; set; }
        public StyleJiprgwpy stylejiprgwpy { get; set; }
        public StyleJiprhozx stylejiprhozx { get; set; }
        public StyleJiprieh4 stylejiprieh4 { get; set; }
        public StyleJipyfhx4 stylejipyfhx4 { get; set; }
        public StyleJipykjdr stylejipykjdr { get; set; }
        public StyleJipyl2wh stylejipyl2wh { get; set; }
        public StyleJipym60f stylejipym60f { get; set; }
        public StyleJipymtgv stylejipymtgv { get; set; }
        public StyleJiq4yttd stylejiq4yttd { get; set; }
        public StyleJj73u5qa stylejj73u5qa { get; set; }
        public StyleJj73uz81 stylejj73uz81 { get; set; }
        public StyleJj8keiww1 stylejj8keiww1 { get; set; }
        public StyleJj8keixc stylejj8keixc { get; set; }
        public StyleJj8keixm stylejj8keixm { get; set; }
        public StyleJj8keiyq1 stylejj8keiyq1 { get; set; }
        public StyleJj8kej1q stylejj8kej1q { get; set; }
        public StyleJj8l62mh1 stylejj8l62mh1 { get; set; }
        public StyleJj8l62ng1 stylejj8l62ng1 { get; set; }
        public StyleJj8mg29s1 stylejj8mg29s1 { get; set; }
        public StyleJj8mhvlk1 stylejj8mhvlk1 { get; set; }
        public StyleJj8mhvmr2 stylejj8mhvmr2 { get; set; }
        public StyleJj8mhvpw stylejj8mhvpw { get; set; }
        public StyleJj8r27vw stylejj8r27vw { get; set; }
        public StyleJja16l4y1 stylejja16l4y1 { get; set; }
        public StyleJja16l5o1 stylejja16l5o1 { get; set; }
        public StyleJja16l5w1 stylejja16l5w1 { get; set; }
        public StyleJja16l6s1 stylejja16l6s1 { get; set; }
        public StyleJja16l8v stylejja16l8v { get; set; }
        public StyleJja171f4 stylejja171f4 { get; set; }
        public StyleJja171fo3 stylejja171fo3 { get; set; }
        public StyleJja171fy stylejja171fy { get; set; }
        public StyleJja171gn1 stylejja171gn1 { get; set; }
        public StyleJja171in stylejja171in { get; set; }
        public StyleJja177ih stylejja177ih { get; set; }
        public StyleJja177j0 stylejja177j0 { get; set; }
        public StyleJja177j82 stylejja177j82 { get; set; }
        public StyleJja177jw1 stylejja177jw1 { get; set; }
        public StyleJja177ls1 stylejja177ls1 { get; set; }
        public StyleJja17fr51 stylejja17fr51 { get; set; }
        public StyleJja17fro2 stylejja17fro2 { get; set; }
        public StyleJja17frw stylejja17frw { get; set; }
        public StyleJja17fsn1 stylejja17fsn1 { get; set; }
        public StyleJja17fuf3 stylejja17fuf3 { get; set; }
        public StyleJjpt7t9m stylejjpt7t9m { get; set; }
        public StyleJjpt95x3 stylejjpt95x3 { get; set; }
        public StyleJmhiarvm stylejmhiarvm { get; set; }
        public StyleJmhiblso stylejmhiblso { get; set; }
        public Tf1 tf1 { get; set; }
        public Tm1 tm1 { get; set; }
        public Tm2 tm2 { get; set; }
        public Tmfull1 tmFull1 { get; set; }
        public Tmfull2 tmFull2 { get; set; }
        public Tpas0 tpas0 { get; set; }
        public Tpaw0 tpaw0 { get; set; }
        public Twf1 twf1 { get; set; }
        public Twt1 twt1 { get; set; }
        public Txt1 txt1 { get; set; }
        public Txtnew txtNew { get; set; }
        public V1 v1 { get; set; }
        public V2 v2 { get; set; }
        public Vl1 vl1 { get; set; }
        public Vl2 vl2 { get; set; }
        public Vl3 vl3 { get; set; }
        public Vl4 vl4 { get; set; }
        public Wp1 wp1 { get; set; }
        public Wp2 wp2 { get; set; }
        public Wp3 wp3 { get; set; }
        public Wp4 wp4 { get; set; }
    }

    public class Anchor_1
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata184 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata184
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style
    {
        public Groups groups { get; set; }
        public Properties properties { get; set; }
        public Propertiessource propertiesSource { get; set; }
    }

    public class Groups
    {
    }

    public class Properties
    {
    }

    public class Propertiessource
    {
    }

    public class Imagebutton_1
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata185 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style1 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata185
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style1
    {
        public Groups1 groups { get; set; }
        public Properties1 properties { get; set; }
        public Propertiessource1 propertiesSource { get; set; }
    }

    public class Groups1
    {
    }

    public class Properties1
    {
    }

    public class Propertiessource1
    {
    }

    public class Singleaudioplayer_1
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata186 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style2 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata186
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style2
    {
        public Groups2 groups { get; set; }
        public Properties2 properties { get; set; }
        public Propertiessource2 propertiesSource { get; set; }
    }

    public class Groups2
    {
    }

    public class Properties2
    {
        public string alphabrd { get; set; }
        public string audioIcons { get; set; }
        public string audioText { get; set; }
        public string bg { get; set; }
        public string boxShadowToggleOnshd { get; set; }
        public string brd { get; set; }
        public string brw { get; set; }
        public string fnt { get; set; }
        public string fnts { get; set; }
        public string prog { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
        public string vol { get; set; }
    }

    public class Propertiessource2
    {
        public string alphabrd { get; set; }
        public string audioIcons { get; set; }
        public string bg { get; set; }
        public string prog { get; set; }
        public string vol { get; set; }
    }

    public class THEME_DATA2
    {
        public string BASE_THEME_DIRECTORY { get; set; }
        public string BG_DIRECTORY { get; set; }
        public string CONTACT_DIRECTORY { get; set; }
        public string EXTERNAL_LINKS_DIRECTORY { get; set; }
        public string NETWORKS_DIRECTORY { get; set; }
        public string PAGES_DIRECTORY { get; set; }
        public string THEME_DIRECTORY { get; set; }
        public string WEB_THEME_DIRECTORY { get; set; }
        public string[] border { get; set; }
        public string bulletSize { get; set; }
        public string[] color { get; set; }
        public string componentSpacing { get; set; }
        public string[] font { get; set; }
        public string headerSpacing { get; set; }
        public string iconSize { get; set; }
        public string iconSpacing { get; set; }
        public string id { get; set; }
        public string itemSpacing { get; set; }
        public Metadata187 metaData { get; set; }
        public string mobileBg { get; set; }
        public string padding1 { get; set; }
        public string padding2 { get; set; }
        public string padding3 { get; set; }
        public string siteBg { get; set; }
        public Themepresets themePresets { get; set; }
        public string thumbSpacing { get; set; }
        public string type { get; set; }
    }

    public class Metadata187
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Themepresets
    {
        public bool mobileBg { get; set; }
    }

    public class Ap1
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata188 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style3 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata188
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style3
    {
        public Groups3 groups { get; set; }
        public Properties3 properties { get; set; }
        public Propertiessource3 propertiesSource { get; set; }
    }

    public class Groups3
    {
    }

    public class Properties3
    {
        public string bg { get; set; }
        public string bgh { get; set; }
        public string boxShadowToggleOnshd { get; set; }
        public string brd { get; set; }
        public string brdh { get; set; }
        public string brw { get; set; }
        public string icon { get; set; }
        public string iconh { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
    }

    public class Propertiessource3
    {
        public string bg { get; set; }
        public string bgh { get; set; }
        public string icon { get; set; }
        public string iconh { get; set; }
    }

    public class Ap2
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata189 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style4 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata189
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style4
    {
        public Groups4 groups { get; set; }
        public Properties4 properties { get; set; }
        public Propertiessource4 propertiesSource { get; set; }
    }

    public class Groups4
    {
    }

    public class Properties4
    {
        public string bg { get; set; }
        public string bgh { get; set; }
        public string boxShadowToggleOnshd { get; set; }
        public string brd { get; set; }
        public string brdh { get; set; }
        public string brw { get; set; }
        public string icon { get; set; }
        public string iconh { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
        public string shd1 { get; set; }
    }

    public class Propertiessource4
    {
        public string bg { get; set; }
        public string bgh { get; set; }
        public string icon { get; set; }
        public string iconh { get; set; }
    }

    public class B1
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata190 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style5 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata190
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style5
    {
        public Groups5 groups { get; set; }
        public Properties5 properties { get; set; }
        public Propertiessource5 propertiesSource { get; set; }
    }

    public class Groups5
    {
    }

    public class Properties5
    {
        public string alphabg { get; set; }
        public string alphabgh { get; set; }
        public string alphabrd { get; set; }
        public string alphabrdh { get; set; }
        public string alphatxt { get; set; }
        public string alphatxth { get; set; }
        public string bg { get; set; }
        public string bgh { get; set; }
        public string boxShadowToggleOnshd { get; set; }
        public string brd { get; set; }
        public string brdh { get; set; }
        public string brw { get; set; }
        public string fnt { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
        public string txt { get; set; }
        public string txth { get; set; }
    }

    public class Propertiessource5
    {
        public string alphabrdh { get; set; }
        public string bg { get; set; }
        public string bgh { get; set; }
        public string brd { get; set; }
        public string brdh { get; set; }
        public string brw { get; set; }
        public string fnt { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
        public string txt { get; set; }
        public string txth { get; set; }
    }

    public class B2
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata191 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style6 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata191
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style6
    {
        public Groups6 groups { get; set; }
        public Properties6 properties { get; set; }
        public Propertiessource6 propertiesSource { get; set; }
    }

    public class Groups6
    {
    }

    public class Properties6
    {
        public string alphabg { get; set; }
        public string alphabgh { get; set; }
        public string alphabrd { get; set; }
        public string alphabrdh { get; set; }
        public string alphatxt { get; set; }
        public string alphatxth { get; set; }
        public string bg { get; set; }
        public string bgh { get; set; }
        public string boxShadowToggleOnshd { get; set; }
        public string brd { get; set; }
        public string brdh { get; set; }
        public string brw { get; set; }
        public string fnt { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
        public string txt { get; set; }
        public string txth { get; set; }
    }

    public class Propertiessource6
    {
        public string alphabrdh { get; set; }
        public string bg { get; set; }
        public string bgh { get; set; }
        public string brd { get; set; }
        public string brdh { get; set; }
        public string brw { get; set; }
        public string fnt { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
        public string txt { get; set; }
        public string txth { get; set; }
    }

    public class B3
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata192 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style7 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata192
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style7
    {
        public Groups7 groups { get; set; }
        public Properties7 properties { get; set; }
        public Propertiessource7 propertiesSource { get; set; }
    }

    public class Groups7
    {
    }

    public class Properties7
    {
        public string alphabg { get; set; }
        public string alphabgh { get; set; }
        public string alphabrd { get; set; }
        public string alphabrdh { get; set; }
        public string alphatxt { get; set; }
        public string alphatxth { get; set; }
        public string bg { get; set; }
        public string bgh { get; set; }
        public string boxShadowToggleOnshd { get; set; }
        public string brd { get; set; }
        public string brdh { get; set; }
        public string brw { get; set; }
        public string fnt { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
        public string txt { get; set; }
        public string txth { get; set; }
    }

    public class Propertiessource7
    {
        public string alphabrdh { get; set; }
        public string bg { get; set; }
        public string bgh { get; set; }
        public string brd { get; set; }
        public string brdh { get; set; }
        public string brw { get; set; }
        public string fnt { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
        public string txt { get; set; }
        public string txth { get; set; }
    }

    public class B4
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata193 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style8 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata193
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style8
    {
        public Groups8 groups { get; set; }
        public Properties8 properties { get; set; }
        public Propertiessource8 propertiesSource { get; set; }
    }

    public class Groups8
    {
    }

    public class Properties8
    {
        public string alphabg { get; set; }
        public string alphabgh { get; set; }
        public string alphabrd { get; set; }
        public string alphabrdh { get; set; }
        public string alphatxt { get; set; }
        public string alphatxth { get; set; }
        public string bg { get; set; }
        public string bgh { get; set; }
        public string boxShadowToggleOnshd { get; set; }
        public string brd { get; set; }
        public string brdh { get; set; }
        public string brw { get; set; }
        public string fnt { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
        public string txt { get; set; }
        public string txth { get; set; }
    }

    public class Propertiessource8
    {
        public string alphabrdh { get; set; }
        public string bg { get; set; }
        public string bgh { get; set; }
        public string brd { get; set; }
        public string brdh { get; set; }
        public string brw { get; set; }
        public string fnt { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
        public string txt { get; set; }
        public string txth { get; set; }
    }

    public class Bgis1
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata194 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style9 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata194
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style9
    {
        public Groups9 groups { get; set; }
        public Properties9 properties { get; set; }
        public Propertiessource9 propertiesSource { get; set; }
    }

    public class Groups9
    {
    }

    public class Properties9
    {
        public string alphabg { get; set; }
        public string alphabrd { get; set; }
        public string bg { get; set; }
        public string boxShadowToggleOnshd { get; set; }
        public string brd { get; set; }
        public string brwb { get; set; }
        public string brwt { get; set; }
        public string shd { get; set; }
    }

    public class Propertiessource9
    {
        public string bg { get; set; }
        public string brd { get; set; }
        public string brwb { get; set; }
        public string brwt { get; set; }
        public string shd { get; set; }
    }

    public class Bgis2
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata195 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style10 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata195
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style10
    {
        public Groups10 groups { get; set; }
        public Properties10 properties { get; set; }
        public Propertiessource10 propertiesSource { get; set; }
    }

    public class Groups10
    {
    }

    public class Properties10
    {
        public string alphabg { get; set; }
        public string alphabrd { get; set; }
        public string bg { get; set; }
        public string boxShadowToggleOnshd { get; set; }
        public string brd { get; set; }
        public string brwb { get; set; }
        public string brwt { get; set; }
        public string shd { get; set; }
    }

    public class Propertiessource10
    {
        public string bg { get; set; }
        public string brd { get; set; }
        public string brwb { get; set; }
        public string brwt { get; set; }
        public string shd { get; set; }
    }

    public class Bgis3
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata196 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style11 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata196
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style11
    {
        public Groups11 groups { get; set; }
        public Properties11 properties { get; set; }
        public Propertiessource11 propertiesSource { get; set; }
    }

    public class Groups11
    {
    }

    public class Properties11
    {
        public string alphabg { get; set; }
        public string alphabrd { get; set; }
        public string bg { get; set; }
        public string boxShadowToggleOnshd { get; set; }
        public string brd { get; set; }
        public string brwb { get; set; }
        public string brwt { get; set; }
        public string shd { get; set; }
    }

    public class Propertiessource11
    {
        public string bg { get; set; }
        public string brd { get; set; }
        public string brwb { get; set; }
        public string brwt { get; set; }
        public string shd { get; set; }
    }

    public class Bgis4
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata197 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style12 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata197
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style12
    {
        public Groups12 groups { get; set; }
        public Properties12 properties { get; set; }
        public Propertiessource12 propertiesSource { get; set; }
    }

    public class Groups12
    {
    }

    public class Properties12
    {
        public string alphabg { get; set; }
        public string alphabrd { get; set; }
        public string bg { get; set; }
        public string boxShadowToggleOnshd { get; set; }
        public string brd { get; set; }
        public string brwb { get; set; }
        public string brwt { get; set; }
        public string shd { get; set; }
    }

    public class Propertiessource12
    {
        public string bg { get; set; }
        public string brd { get; set; }
        public string brwb { get; set; }
        public string brwt { get; set; }
        public string shd { get; set; }
    }

    public class Blog_33A9f5e0B0834CccB55d3Ca5d241a6eb_1
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata198 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style13 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata198
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style13
    {
        public Groups13 groups { get; set; }
        public Properties13 properties { get; set; }
        public Propertiessource13 propertiesSource { get; set; }
    }

    public class Groups13
    {
    }

    public class Properties13
    {
        public string rd { get; set; }
    }

    public class Propertiessource13
    {
        public string rd { get; set; }
    }

    public class Blog_4656A63cB3164315Ab16E2003f5935ca_1
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata199 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style14 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata199
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style14
    {
        public Groups14 groups { get; set; }
        public Properties14 properties { get; set; }
        public Propertiessource14 propertiesSource { get; set; }
    }

    public class Groups14
    {
    }

    public class Properties14
    {
        public string rd { get; set; }
    }

    public class Propertiessource14
    {
        public string rd { get; set; }
    }

    public class Blog_4De5abc56Da24F97Acc394Bb74285072_1
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata200 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style15 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata200
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style15
    {
        public Groups15 groups { get; set; }
        public Properties15 properties { get; set; }
        public Propertiessource15 propertiesSource { get; set; }
    }

    public class Groups15
    {
    }

    public class Properties15
    {
        public string rd { get; set; }
    }

    public class Propertiessource15
    {
        public string rd { get; set; }
    }

    public class Blog_56Ab6fa495Ac439193376702B8a77011_1
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata201 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style16 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata201
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style16
    {
        public Groups16 groups { get; set; }
        public Properties16 properties { get; set; }
        public Propertiessource16 propertiesSource { get; set; }
    }

    public class Groups16
    {
    }

    public class Properties16
    {
        public string rd { get; set; }
    }

    public class Propertiessource16
    {
        public string rd { get; set; }
    }

    public class Blog_E000b4bf9Ff14E66A0d3D4b365ba3af5_1
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata202 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style17 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata202
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style17
    {
        public Groups17 groups { get; set; }
        public Properties17 properties { get; set; }
        public Propertiessource17 propertiesSource { get; set; }
    }

    public class Groups17
    {
    }

    public class Properties17
    {
        public string rd { get; set; }
    }

    public class Propertiessource17
    {
        public string rd { get; set; }
    }

    public class Blog_F72fe3778Abc40F2865689Cfe00f3a22_1
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata203 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style18 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata203
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style18
    {
        public Groups18 groups { get; set; }
        public Properties18 properties { get; set; }
        public Propertiessource18 propertiesSource { get; set; }
    }

    public class Groups18
    {
    }

    public class Properties18
    {
        public string rd { get; set; }
    }

    public class Propertiessource18
    {
        public string rd { get; set; }
    }

    public class C1
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata204 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style19 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata204
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style19
    {
        public Groups19 groups { get; set; }
        public Properties19 properties { get; set; }
        public Propertiessource19 propertiesSource { get; set; }
    }

    public class Groups19
    {
    }

    public class Properties19
    {
        public string alphabg { get; set; }
        public string alphabrd { get; set; }
        public string bg { get; set; }
        public string boxShadowToggleOnshd { get; set; }
        public string brd { get; set; }
        public string brw { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
    }

    public class Propertiessource19
    {
        public string bg { get; set; }
        public string brd { get; set; }
        public string brw { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
    }

    public class C2
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata205 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style20 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata205
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style20
    {
        public Groups20 groups { get; set; }
        public Properties20 properties { get; set; }
        public Propertiessource20 propertiesSource { get; set; }
    }

    public class Groups20
    {
    }

    public class Properties20
    {
        public string alphabg { get; set; }
        public string alphabrd { get; set; }
        public string bg { get; set; }
        public string boxShadowToggleOnshd { get; set; }
        public string brd { get; set; }
        public string brw { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
    }

    public class Propertiessource20
    {
        public string bg { get; set; }
        public string brd { get; set; }
        public string brw { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
    }

    public class C3
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata206 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style21 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata206
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style21
    {
        public Groups21 groups { get; set; }
        public Properties21 properties { get; set; }
        public Propertiessource21 propertiesSource { get; set; }
    }

    public class Groups21
    {
    }

    public class Properties21
    {
        public string alphabg { get; set; }
        public string bg { get; set; }
    }

    public class Propertiessource21
    {
        public string bg { get; set; }
    }

    public class C4
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata207 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style22 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata207
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style22
    {
        public Groups22 groups { get; set; }
        public Properties22 properties { get; set; }
        public Propertiessource22 propertiesSource { get; set; }
    }

    public class Groups22
    {
    }

    public class Properties22
    {
        public string alphabg { get; set; }
        public string bg { get; set; }
    }

    public class Propertiessource22
    {
        public string bg { get; set; }
    }

    public class Ca1
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata208 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style23 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata208
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style23
    {
        public Groups23 groups { get; set; }
        public Properties23 properties { get; set; }
        public Propertiessource23 propertiesSource { get; set; }
    }

    public class Groups23
    {
    }

    public class Properties23
    {
    }

    public class Propertiessource23
    {
    }

    public class Cf1
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata209 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style24 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata209
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style24
    {
        public Groups24 groups { get; set; }
        public Properties24 properties { get; set; }
        public Propertiessource24 propertiesSource { get; set; }
    }

    public class Groups24
    {
    }

    public class Properties24
    {
        public string alphabg1 { get; set; }
        public string alphabg2 { get; set; }
        public string alphabrd { get; set; }
        public string alphalabelTxt { get; set; }
        public string alphatxt1 { get; set; }
        public string alphatxt2 { get; set; }
        public string alphatxtError { get; set; }
        public string alphatxtSuccess { get; set; }
        public string bg1 { get; set; }
        public string bg2 { get; set; }
        public string boxShadowToggleOnshd { get; set; }
        public string brd { get; set; }
        public string brw { get; set; }
        public string fnt { get; set; }
        public string fnt2 { get; set; }
        public string labelTxt { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
        public string txt1 { get; set; }
        public string txt2 { get; set; }
        public string txtError { get; set; }
        public string txtSuccess { get; set; }
    }

    public class Propertiessource24
    {
        public string bg1 { get; set; }
        public string bg2 { get; set; }
        public string brd { get; set; }
        public string brw { get; set; }
        public string fnt { get; set; }
        public string fnt2 { get; set; }
        public string labelTxt { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
        public string txt1 { get; set; }
        public string txt2 { get; set; }
        public string txtError { get; set; }
        public string txtSuccess { get; set; }
    }

    public class Cf2
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata210 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style25 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata210
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style25
    {
        public Groups25 groups { get; set; }
        public Properties25 properties { get; set; }
        public Propertiessource25 propertiesSource { get; set; }
    }

    public class Groups25
    {
    }

    public class Properties25
    {
        public string alphabg1 { get; set; }
        public string alphabg2 { get; set; }
        public string alphabrd { get; set; }
        public string alphalabelTxt { get; set; }
        public string alphatxt1 { get; set; }
        public string alphatxt2 { get; set; }
        public string alphatxtError { get; set; }
        public string alphatxtSuccess { get; set; }
        public string bg1 { get; set; }
        public string bg2 { get; set; }
        public string boxShadowToggleOnshd { get; set; }
        public string brd { get; set; }
        public string brw { get; set; }
        public string fnt { get; set; }
        public string fnt2 { get; set; }
        public string labelTxt { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
        public string txt1 { get; set; }
        public string txt2 { get; set; }
        public string txtError { get; set; }
        public string txtSuccess { get; set; }
    }

    public class Propertiessource25
    {
        public string bg1 { get; set; }
        public string bg2 { get; set; }
        public string brd { get; set; }
        public string brw { get; set; }
        public string fnt { get; set; }
        public string fnt2 { get; set; }
        public string labelTxt { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
        public string txt1 { get; set; }
        public string txt2 { get; set; }
        public string txtError { get; set; }
        public string txtSuccess { get; set; }
    }

    public class Controller1
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata211 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style26 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata211
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style26
    {
        public Groups26 groups { get; set; }
        public Properties26 properties { get; set; }
        public Propertiessource26 propertiesSource { get; set; }
    }

    public class Groups26
    {
    }

    public class Properties26
    {
    }

    public class Propertiessource26
    {
    }

    public class Ddm1
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata212 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style27 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata212
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style27
    {
        public Groups27 groups { get; set; }
        public Properties27 properties { get; set; }
        public Propertiessource27 propertiesSource { get; set; }
    }

    public class Groups27
    {
    }

    public class Properties27
    {
        public string alphabgDrop { get; set; }
        public string alphatxt { get; set; }
        public string alphatxth { get; set; }
        public string alphatxts { get; set; }
        public string bgDrop { get; set; }
        public string boxShadowToggleOnshd { get; set; }
        public string fnt { get; set; }
        public string pad { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
        public string txt { get; set; }
        public string txth { get; set; }
        public string txts { get; set; }
    }

    public class Propertiessource27
    {
        public string bgDrop { get; set; }
        public string fnt { get; set; }
        public string pad { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
        public string txt { get; set; }
        public string txth { get; set; }
        public string txts { get; set; }
    }

    public class Ddm2
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata213 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style28 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata213
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style28
    {
        public Groups28 groups { get; set; }
        public Properties28 properties { get; set; }
        public Propertiessource28 propertiesSource { get; set; }
    }

    public class Groups28
    {
    }

    public class Properties28
    {
        public string alphabg { get; set; }
        public string alphabgDrop { get; set; }
        public string alphabgh { get; set; }
        public string alphabgs { get; set; }
        public string alphabrd { get; set; }
        public string alphasep { get; set; }
        public string alphatxt { get; set; }
        public string alphatxth { get; set; }
        public string alphatxts { get; set; }
        public string bg { get; set; }
        public string bgDrop { get; set; }
        public string bgh { get; set; }
        public string bgs { get; set; }
        public string boxShadowToggleOnshd { get; set; }
        public string brd { get; set; }
        public string brw { get; set; }
        public string fnt { get; set; }
        public string pad { get; set; }
        public string rd { get; set; }
        public string rdDrop { get; set; }
        public string sep { get; set; }
        public string shd { get; set; }
        public string txt { get; set; }
        public string txth { get; set; }
        public string txts { get; set; }
    }

    public class Propertiessource28
    {
        public string alphabg { get; set; }
        public string bg { get; set; }
        public string bgDrop { get; set; }
        public string bgh { get; set; }
        public string bgs { get; set; }
        public string brd { get; set; }
        public string brw { get; set; }
        public string fnt { get; set; }
        public string pad { get; set; }
        public string rd { get; set; }
        public string rdDrop { get; set; }
        public string sep { get; set; }
        public string shd { get; set; }
        public string txt { get; set; }
        public string txth { get; set; }
        public string txts { get; set; }
    }

    public class Ddm3
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata214 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style29 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata214
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style29
    {
        public Groups29 groups { get; set; }
        public Properties29 properties { get; set; }
        public Propertiessource29 propertiesSource { get; set; }
    }

    public class Groups29
    {
    }

    public class Properties29
    {
        public string alphabgDrop { get; set; }
        public string alphabrd { get; set; }
        public string alphabrdh { get; set; }
        public string alphabrds { get; set; }
        public string bgDrop { get; set; }
        public string boxShadowToggleOnshd { get; set; }
        public string brd { get; set; }
        public string brdh { get; set; }
        public string brds { get; set; }
        public string fnt { get; set; }
        public string menuTotalBordersX { get; set; }
        public string pad { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
        public string txt { get; set; }
        public string txth { get; set; }
        public string txts { get; set; }
    }

    public class Propertiessource29
    {
        public string alphabgDrop { get; set; }
        public string alphabrd { get; set; }
        public string alphabrdh { get; set; }
        public string alphabrds { get; set; }
        public string bgDrop { get; set; }
        public string boxShadowToggleOnshd { get; set; }
        public string brd { get; set; }
        public string brdh { get; set; }
        public string brds { get; set; }
        public string fnt { get; set; }
        public string menuTotalBordersX { get; set; }
        public string pad { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
        public string txt { get; set; }
        public string txth { get; set; }
        public string txts { get; set; }
    }

    public class Eib1
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata215 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style30 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata215
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style30
    {
        public Properties30 properties { get; set; }
    }

    public class Properties30
    {
        public string alphabackgroundColor { get; set; }
        public string alphaborderColor { get; set; }
        public string alphafontColor { get; set; }
        public string alphaheaderColor { get; set; }
        public string alphalinkColor { get; set; }
        public string backgroundColor { get; set; }
        public string borderColor { get; set; }
        public string brightnessbackgroundColor { get; set; }
        public string brightnessborderColor { get; set; }
        public string brightnessfontColor { get; set; }
        public string brightnessheaderColor { get; set; }
        public string brightnesslinkColor { get; set; }
        public string fontColor { get; set; }
        public string headerColor { get; set; }
        public string linkColor { get; set; }
        public string saturationbackgroundColor { get; set; }
        public string saturationborderColor { get; set; }
        public string saturationfontColor { get; set; }
        public string saturationheaderColor { get; set; }
        public string saturationlinkColor { get; set; }
    }

    public class Fbc1
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata216 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style31 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata216
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style31
    {
        public Groups30 groups { get; set; }
        public Properties31 properties { get; set; }
        public Propertiessource30 propertiesSource { get; set; }
    }

    public class Groups30
    {
    }

    public class Properties31
    {
    }

    public class Propertiessource30
    {
    }

    public class Fbl1
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata217 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style32 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata217
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style32
    {
        public Groups31 groups { get; set; }
        public Properties32 properties { get; set; }
        public Propertiessource31 propertiesSource { get; set; }
    }

    public class Groups31
    {
    }

    public class Properties32
    {
    }

    public class Propertiessource31
    {
    }

    public class Fc1
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata218 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style33 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata218
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style33
    {
        public Groups32 groups { get; set; }
        public Properties33 properties { get; set; }
        public Propertiessource32 propertiesSource { get; set; }
    }

    public class Groups32
    {
    }

    public class Properties33
    {
    }

    public class Propertiessource32
    {
    }

    public class Fc2
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata219 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style34 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata219
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style34
    {
        public Groups33 groups { get; set; }
        public Properties34 properties { get; set; }
        public Propertiessource33 propertiesSource { get; set; }
    }

    public class Groups33
    {
    }

    public class Properties34
    {
        public string alphabg { get; set; }
        public string alphabgctr { get; set; }
        public string alphabrd { get; set; }
        public string bg { get; set; }
        public string bgctr { get; set; }
        public string boxShadowToggleOnshd { get; set; }
        public string brd { get; set; }
        public string brwb { get; set; }
        public string brwt { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
    }

    public class Propertiessource33
    {
        public string bg { get; set; }
        public string bgctr { get; set; }
        public string brd { get; set; }
        public string brwb { get; set; }
        public string brwt { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
    }

    public class Fc3
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata220 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style35 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata220
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style35
    {
        public Groups34 groups { get; set; }
        public Properties35 properties { get; set; }
        public Propertiessource34 propertiesSource { get; set; }
    }

    public class Groups34
    {
    }

    public class Properties35
    {
        public string alphabg { get; set; }
        public string alphabgctr { get; set; }
        public string alphabrd { get; set; }
        public string bg { get; set; }
        public string bgctr { get; set; }
        public string boxShadowToggleOnshd { get; set; }
        public string brd { get; set; }
        public string brwb { get; set; }
        public string brwt { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
    }

    public class Propertiessource34
    {
        public string bg { get; set; }
        public string bgctr { get; set; }
        public string brd { get; set; }
        public string brwb { get; set; }
        public string brwt { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
    }

    public class Fk1
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata221 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style36 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata221
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style36
    {
        public Properties36 properties { get; set; }
    }

    public class Properties36
    {
        public string alphabackgroundColor { get; set; }
        public string alphaborderColor { get; set; }
        public string backgroundColor { get; set; }
        public string borderColor { get; set; }
        public string brightnessbackgroundColor { get; set; }
        public string brightnessborderColor { get; set; }
        public string saturationbackgroundColor { get; set; }
        public string saturationborderColor { get; set; }
    }

    public class Gm1
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata222 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style37 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata222
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style37
    {
        public Groups35 groups { get; set; }
        public Properties37 properties { get; set; }
        public Propertiessource35 propertiesSource { get; set; }
    }

    public class Groups35
    {
    }

    public class Properties37
    {
    }

    public class Propertiessource35
    {
    }

    public class Gp1
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata223 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style38 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata223
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style38
    {
        public Groups36 groups { get; set; }
        public Properties38 properties { get; set; }
        public Propertiessource36 propertiesSource { get; set; }
    }

    public class Groups36
    {
    }

    public class Properties38
    {
    }

    public class Propertiessource36
    {
    }

    public class Hc1
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata224 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style39 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata224
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style39
    {
        public Groups37 groups { get; set; }
        public Properties39 properties { get; set; }
        public Propertiessource37 propertiesSource { get; set; }
    }

    public class Groups37
    {
    }

    public class Properties39
    {
    }

    public class Propertiessource37
    {
    }

    public class Hc2
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata225 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style40 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata225
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style40
    {
        public Groups38 groups { get; set; }
        public Properties40 properties { get; set; }
        public Propertiessource38 propertiesSource { get; set; }
    }

    public class Groups38
    {
    }

    public class Properties40
    {
        public string alphabg { get; set; }
        public string alphabgctr { get; set; }
        public string alphabrd { get; set; }
        public string bg { get; set; }
        public string bgctr { get; set; }
        public string boxShadowToggleOnshd { get; set; }
        public string brd { get; set; }
        public string brwb { get; set; }
        public string brwt { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
    }

    public class Propertiessource38
    {
        public string bg { get; set; }
        public string bgctr { get; set; }
        public string brd { get; set; }
        public string brwb { get; set; }
        public string brwt { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
    }

    public class Hc3
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata226 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style41 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata226
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style41
    {
        public Groups39 groups { get; set; }
        public Properties41 properties { get; set; }
        public Propertiessource39 propertiesSource { get; set; }
    }

    public class Groups39
    {
    }

    public class Properties41
    {
        public string alphabg { get; set; }
        public string alphabgctr { get; set; }
        public string alphabrd { get; set; }
        public string bg { get; set; }
        public string bgctr { get; set; }
        public string boxShadowToggleOnshd { get; set; }
        public string brd { get; set; }
        public string brwb { get; set; }
        public string brwt { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
    }

    public class Propertiessource39
    {
        public string bg { get; set; }
        public string bgctr { get; set; }
        public string brd { get; set; }
        public string brwb { get; set; }
        public string brwt { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
    }

    public class Hl1
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata227 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style42 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata227
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style42
    {
        public Groups40 groups { get; set; }
        public Properties42 properties { get; set; }
        public Propertiessource40 propertiesSource { get; set; }
    }

    public class Groups40
    {
    }

    public class Properties42
    {
        public string alphabrd { get; set; }
        public string brd { get; set; }
        public string lnw { get; set; }
    }

    public class Propertiessource40
    {
        public string brd { get; set; }
        public string lnw { get; set; }
    }

    public class Hl2
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata228 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style43 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata228
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style43
    {
        public Groups41 groups { get; set; }
        public Properties43 properties { get; set; }
        public Propertiessource41 propertiesSource { get; set; }
    }

    public class Groups41
    {
    }

    public class Properties43
    {
        public string alphabrd { get; set; }
        public string brd { get; set; }
        public string lnw { get; set; }
    }

    public class Propertiessource41
    {
        public string brd { get; set; }
        public string lnw { get; set; }
    }

    public class Hl3
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata229 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style44 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata229
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style44
    {
        public Groups42 groups { get; set; }
        public Properties44 properties { get; set; }
        public Propertiessource42 propertiesSource { get; set; }
    }

    public class Groups42
    {
    }

    public class Properties44
    {
        public string alphabrd { get; set; }
        public string brd { get; set; }
        public string lnw { get; set; }
    }

    public class Propertiessource42
    {
        public string brd { get; set; }
        public string lnw { get; set; }
    }

    public class Hl4
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata230 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style45 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata230
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style45
    {
        public Groups43 groups { get; set; }
        public Properties45 properties { get; set; }
        public Propertiessource43 propertiesSource { get; set; }
    }

    public class Groups43
    {
    }

    public class Properties45
    {
    }

    public class Propertiessource43
    {
    }

    public class Htco1
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata231 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style46 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata231
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style46
    {
        public Groups44 groups { get; set; }
        public Properties46 properties { get; set; }
        public Propertiessource44 propertiesSource { get; set; }
    }

    public class Groups44
    {
    }

    public class Properties46
    {
    }

    public class Propertiessource44
    {
    }

    public class Lb1
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata232 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style47 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata232
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style47
    {
        public Groups45 groups { get; set; }
    }

    public class Groups45
    {
        public Displayer displayer { get; set; }
    }

    public class Displayer
    {
    }

    public class Mc1
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata233 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style48 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata233
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style48
    {
        public Groups46 groups { get; set; }
        public Properties47 properties { get; set; }
        public Propertiessource45 propertiesSource { get; set; }
    }

    public class Groups46
    {
    }

    public class Properties47
    {
    }

    public class Propertiessource45
    {
    }

    public class Mg1
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata234 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style49 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata234
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style49
    {
        public Groups47 groups { get; set; }
        public Properties48 properties { get; set; }
        public Propertiessource46 propertiesSource { get; set; }
    }

    public class Groups47
    {
    }

    public class Properties48
    {
        public string alphabgh { get; set; }
        public string alphabrd { get; set; }
        public string alphattl { get; set; }
        public string alphatxt { get; set; }
        public string bgh { get; set; }
        public string boxShadowToggleOnshd { get; set; }
        public string brd { get; set; }
        public string brw { get; set; }
        public string fntds { get; set; }
        public string fntt { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
        public string ttl { get; set; }
        public string txt { get; set; }
    }

    public class Propertiessource46
    {
        public string bgh { get; set; }
        public string brd { get; set; }
        public string brw { get; set; }
        public string fntds { get; set; }
        public string fntt { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
        public string ttl { get; set; }
        public string txt { get; set; }
    }

    public class Mg2
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata235 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style50 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata235
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style50
    {
        public Groups48 groups { get; set; }
        public Properties49 properties { get; set; }
        public Propertiessource47 propertiesSource { get; set; }
    }

    public class Groups48
    {
    }

    public class Properties49
    {
        public string alphabgh { get; set; }
        public string alphabrd { get; set; }
        public string alphattl { get; set; }
        public string alphatxt { get; set; }
        public string bgh { get; set; }
        public string boxShadowToggleOnshd { get; set; }
        public string brd { get; set; }
        public string brw { get; set; }
        public string fntds { get; set; }
        public string fntt { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
        public string ttl { get; set; }
        public string txt { get; set; }
    }

    public class Propertiessource47
    {
        public string bgh { get; set; }
        public string brd { get; set; }
        public string brw { get; set; }
        public string fntds { get; set; }
        public string fntt { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
        public string ttl { get; set; }
        public string txt { get; set; }
    }

    public class Mg3
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata236 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style51 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata236
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style51
    {
        public Groups49 groups { get; set; }
        public Properties50 properties { get; set; }
        public Propertiessource48 propertiesSource { get; set; }
    }

    public class Groups49
    {
    }

    public class Properties50
    {
        public string alphabg { get; set; }
        public string alphabgh { get; set; }
        public string alphattl { get; set; }
        public string alphatxt { get; set; }
        public string bg { get; set; }
        public string bgh { get; set; }
        public string boxShadowToggleOnshd { get; set; }
        public string brw { get; set; }
        public string fntds { get; set; }
        public string fntt { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
        public string ttl { get; set; }
        public string txt { get; set; }
    }

    public class Propertiessource48
    {
        public string bg { get; set; }
        public string bgh { get; set; }
        public string brw { get; set; }
        public string fntds { get; set; }
        public string fntt { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
        public string ttl { get; set; }
        public string txt { get; set; }
    }

    public class Mp1
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata237 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style52 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata237
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style52
    {
        public Groups50 groups { get; set; }
        public Properties51 properties { get; set; }
        public Propertiessource49 propertiesSource { get; set; }
    }

    public class Groups50
    {
    }

    public class Properties51
    {
    }

    public class Propertiessource49
    {
    }

    public class P1
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata238 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style53 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata238
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style53
    {
        public Groups51 groups { get; set; }
        public Properties52 properties { get; set; }
        public Propertiessource50 propertiesSource { get; set; }
    }

    public class Groups51
    {
    }

    public class Properties52
    {
    }

    public class Propertiessource50
    {
    }

    public class P2
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata239 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style54 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata239
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style54
    {
        public Groups52 groups { get; set; }
        public Properties53 properties { get; set; }
        public Propertiessource51 propertiesSource { get; set; }
    }

    public class Groups52
    {
    }

    public class Properties53
    {
        public string alphabg { get; set; }
        public string bg { get; set; }
    }

    public class Propertiessource51
    {
        public string bg { get; set; }
    }

    public class P3
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata240 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style55 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata240
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style55
    {
        public Groups53 groups { get; set; }
        public Properties54 properties { get; set; }
        public Propertiessource52 propertiesSource { get; set; }
    }

    public class Groups53
    {
    }

    public class Properties54
    {
        public string alphabg { get; set; }
        public string bg { get; set; }
    }

    public class Propertiessource52
    {
        public string bg { get; set; }
    }

    public class Pagg1
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata241 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style56 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata241
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style56
    {
        public Groups54 groups { get; set; }
        public Properties55 properties { get; set; }
        public Propertiessource53 propertiesSource { get; set; }
    }

    public class Groups54
    {
    }

    public class Properties55
    {
        public string alphabg { get; set; }
        public string alphabgh { get; set; }
        public string alphalinkColor { get; set; }
        public string alphatxt { get; set; }
        public string bg { get; set; }
        public string bgh { get; set; }
        public string fntds { get; set; }
        public string fntt { get; set; }
        public string linkColor { get; set; }
        public string txt { get; set; }
    }

    public class Propertiessource53
    {
        public string bg { get; set; }
        public string bgh { get; set; }
        public string fntds { get; set; }
        public string fntt { get; set; }
        public string linkColor { get; set; }
        public string txt { get; set; }
    }

    public class Pagg2
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata242 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style57 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata242
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style57
    {
        public Groups55 groups { get; set; }
        public Properties56 properties { get; set; }
        public Propertiessource54 propertiesSource { get; set; }
    }

    public class Groups55
    {
    }

    public class Properties56
    {
        public string alphabg { get; set; }
        public string alphalinkColor { get; set; }
        public string alphatxt { get; set; }
        public string bg { get; set; }
        public string fntds { get; set; }
        public string fntt { get; set; }
        public string linkColor { get; set; }
        public string txt { get; set; }
    }

    public class Propertiessource54
    {
        public string bg { get; set; }
        public string fntds { get; set; }
        public string fntt { get; set; }
        public string linkColor { get; set; }
        public string txt { get; set; }
    }

    public class Pagg3
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata243 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style58 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata243
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style58
    {
        public Groups56 groups { get; set; }
        public Properties57 properties { get; set; }
        public Propertiessource55 propertiesSource { get; set; }
    }

    public class Groups56
    {
    }

    public class Properties57
    {
        public string alphabg { get; set; }
        public string alphabg1 { get; set; }
        public string alphalinkColor { get; set; }
        public string alphatxt { get; set; }
        public string bg { get; set; }
        public string bg1 { get; set; }
        public string fntds { get; set; }
        public string fntt { get; set; }
        public string linkColor { get; set; }
        public string txt { get; set; }
    }

    public class Propertiessource55
    {
        public string bg { get; set; }
        public string bg1 { get; set; }
        public string fntds { get; set; }
        public string fntt { get; set; }
        public string linkColor { get; set; }
        public string txt { get; set; }
    }

    public class Pc1
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata244 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style59 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata244
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style59
    {
        public Groups57 groups { get; set; }
        public Properties58 properties { get; set; }
        public Propertiessource56 propertiesSource { get; set; }
    }

    public class Groups57
    {
    }

    public class Properties58
    {
    }

    public class Propertiessource56
    {
    }

    public class Pc2
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata245 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style60 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata245
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style60
    {
        public Properties59 properties { get; set; }
    }

    public class Properties59
    {
        public string alphabg { get; set; }
        public string alphabgctr { get; set; }
        public string alphabrd { get; set; }
        public string bg { get; set; }
        public string bgctr { get; set; }
        public string boxShadowToggleOnshd { get; set; }
        public string brd { get; set; }
        public string brwb { get; set; }
        public string brwt { get; set; }
        public string shd { get; set; }
    }

    public class Sc1
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata246 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style61 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata246
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style61
    {
        public Properties60 properties { get; set; }
    }

    public class Properties60
    {
        public string alphabg { get; set; }
        public string alphabgctr { get; set; }
        public string alphabrd { get; set; }
        public string bg { get; set; }
        public string bgctr { get; set; }
        public string boxShadowToggleOnshd { get; set; }
        public string brd { get; set; }
        public string brwb { get; set; }
        public string brwt { get; set; }
        public string shd { get; set; }
    }

    public class Sc2
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata247 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style62 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata247
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style62
    {
        public Properties61 properties { get; set; }
    }

    public class Properties61
    {
        public string alphabg { get; set; }
        public string alphabgctr { get; set; }
        public string alphabrd { get; set; }
        public string bg { get; set; }
        public string bgctr { get; set; }
        public string boxShadowToggleOnshd { get; set; }
        public string brd { get; set; }
        public string brwb { get; set; }
        public string brwt { get; set; }
        public string shd { get; set; }
    }

    public class Sc3
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata248 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style63 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata248
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style63
    {
        public Properties62 properties { get; set; }
    }

    public class Properties62
    {
        public string alphabg { get; set; }
        public string alphabrd { get; set; }
        public string bg { get; set; }
        public string brd { get; set; }
        public string brwb { get; set; }
        public string brwt { get; set; }
    }

    public class Sc4
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata249 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style64 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata249
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style64
    {
        public Properties63 properties { get; set; }
    }

    public class Properties63
    {
        public string alphabg { get; set; }
        public string alphabgctr { get; set; }
        public string alphabrd { get; set; }
        public string bg { get; set; }
        public string bgctr { get; set; }
        public string boxShadowToggleOnshd { get; set; }
        public string brd { get; set; }
        public string brwb { get; set; }
        public string brwt { get; set; }
        public string shd { get; set; }
    }

    public class Scw1
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata250 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style65 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata250
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style65
    {
        public Groups58 groups { get; set; }
        public Properties64 properties { get; set; }
        public Propertiessource57 propertiesSource { get; set; }
    }

    public class Groups58
    {
    }

    public class Properties64
    {
    }

    public class Propertiessource57
    {
    }

    public class Sg1
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata251 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style66 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata251
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style66
    {
        public Groups59 groups { get; set; }
        public Properties65 properties { get; set; }
        public Propertiessource58 propertiesSource { get; set; }
    }

    public class Groups59
    {
    }

    public class Properties65
    {
        public string alphabg { get; set; }
        public string alphabrd { get; set; }
        public string alphatxt { get; set; }
        public string bg { get; set; }
        public string brd { get; set; }
        public string brw { get; set; }
        public string fntds { get; set; }
        public string rd { get; set; }
        public string txt { get; set; }
    }

    public class Propertiessource58
    {
        public string bg { get; set; }
        public string brd { get; set; }
        public string brw { get; set; }
        public string fntds { get; set; }
        public string rd { get; set; }
        public string txt { get; set; }
    }

    public class Sg2
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata252 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style67 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata252
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style67
    {
        public Groups60 groups { get; set; }
        public Properties66 properties { get; set; }
        public Propertiessource59 propertiesSource { get; set; }
    }

    public class Groups60
    {
    }

    public class Properties66
    {
        public string alphabg { get; set; }
        public string alphabrd { get; set; }
        public string alphatxt { get; set; }
        public string bg { get; set; }
        public string brd { get; set; }
        public string brw { get; set; }
        public string fntds { get; set; }
        public string rd { get; set; }
        public string txt { get; set; }
    }

    public class Propertiessource59
    {
        public string bg { get; set; }
        public string brd { get; set; }
        public string brw { get; set; }
        public string fntds { get; set; }
        public string rd { get; set; }
        public string txt { get; set; }
    }

    public class Sg3
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata253 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style68 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata253
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style68
    {
        public Groups61 groups { get; set; }
        public Properties67 properties { get; set; }
        public Propertiessource60 propertiesSource { get; set; }
    }

    public class Groups61
    {
    }

    public class Properties67
    {
        public string alphabg { get; set; }
        public string alphabrd { get; set; }
        public string alphatxt { get; set; }
        public string bg { get; set; }
        public string brd { get; set; }
        public string brw { get; set; }
        public string fntds { get; set; }
        public string rd { get; set; }
        public string txt { get; set; }
    }

    public class Propertiessource60
    {
        public string bg { get; set; }
        public string brd { get; set; }
        public string brw { get; set; }
        public string fntds { get; set; }
        public string rd { get; set; }
        public string txt { get; set; }
    }

    public class Ssg1
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata254 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style69 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata254
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style69
    {
        public Groups62 groups { get; set; }
        public Properties68 properties { get; set; }
        public Propertiessource61 propertiesSource { get; set; }
    }

    public class Groups62
    {
    }

    public class Properties68
    {
        public string alphabg { get; set; }
        public string alphabrd { get; set; }
        public string alphatxt { get; set; }
        public string bg { get; set; }
        public string boxShadowToggleOnshd { get; set; }
        public string brd { get; set; }
        public string brw { get; set; }
        public string fntds { get; set; }
        public string fntt { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
        public string txt { get; set; }
    }

    public class Propertiessource61
    {
        public string bg { get; set; }
        public string brd { get; set; }
        public string brw { get; set; }
        public string fntds { get; set; }
        public string fntt { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
        public string txt { get; set; }
    }

    public class Ssg2
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata255 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style70 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata255
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style70
    {
        public Groups63 groups { get; set; }
        public Properties69 properties { get; set; }
        public Propertiessource62 propertiesSource { get; set; }
    }

    public class Groups63
    {
    }

    public class Properties69
    {
        public string alphabg { get; set; }
        public string alphabrd { get; set; }
        public string alphatxt { get; set; }
        public string bg { get; set; }
        public string boxShadowToggleOnshd { get; set; }
        public string brd { get; set; }
        public string brw { get; set; }
        public string fntds { get; set; }
        public string fntt { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
        public string txt { get; set; }
    }

    public class Propertiessource62
    {
        public string bg { get; set; }
        public string brd { get; set; }
        public string brw { get; set; }
        public string fntds { get; set; }
        public string fntt { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
        public string txt { get; set; }
    }

    public class Ssg3
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata256 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style71 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata256
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style71
    {
        public Groups64 groups { get; set; }
        public Properties70 properties { get; set; }
        public Propertiessource63 propertiesSource { get; set; }
    }

    public class Groups64
    {
    }

    public class Properties70
    {
        public string alphabg { get; set; }
        public string alphatxt { get; set; }
        public string bg { get; set; }
        public string boxShadowToggleOnshd { get; set; }
        public string brw { get; set; }
        public string fntds { get; set; }
        public string fntt { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
        public string txt { get; set; }
    }

    public class Propertiessource63
    {
        public string bg { get; set; }
        public string brw { get; set; }
        public string fntds { get; set; }
        public string fntt { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
        public string txt { get; set; }
    }

    public class Strc1
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata257 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style72 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata257
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style72
    {
        public Groups65 groups { get; set; }
        public Properties71 properties { get; set; }
        public Propertiessource64 propertiesSource { get; set; }
    }

    public class Groups65
    {
    }

    public class Properties71
    {
    }

    public class Propertiessource64
    {
    }

    public class StyleJ13ihxnb
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata258 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style73 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata258
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style73
    {
        public Groups66 groups { get; set; }
        public Properties72 properties { get; set; }
        public Propertiessource65 propertiesSource { get; set; }
    }

    public class Groups66
    {
    }

    public class Properties72
    {
        public string alphabg { get; set; }
        public string alphabgd { get; set; }
        public string alphabgh { get; set; }
        public string alphabrd { get; set; }
        public string alphabrdd { get; set; }
        public string alphabrdh { get; set; }
        public string bg { get; set; }
        public string bgd { get; set; }
        public string bgh { get; set; }
        public string boxShadowToggleOnshd { get; set; }
        public string brd { get; set; }
        public string brdd { get; set; }
        public string brdh { get; set; }
        public string brw { get; set; }
        public string fnt { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
        public string txt { get; set; }
        public string txtd { get; set; }
        public string txth { get; set; }
    }

    public class Propertiessource65
    {
        public string alphabg { get; set; }
        public string alphabgd { get; set; }
        public string alphabgh { get; set; }
        public string alphabrd { get; set; }
        public string alphabrdd { get; set; }
        public string alphabrdh { get; set; }
        public string bg { get; set; }
        public string bgd { get; set; }
        public string bgh { get; set; }
        public string boxShadowToggleOnshd { get; set; }
        public string brd { get; set; }
        public string brdd { get; set; }
        public string brdh { get; set; }
        public string brw { get; set; }
        public string fnt { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
        public string txt { get; set; }
        public string txtd { get; set; }
        public string txth { get; set; }
    }

    public class StyleJ2hjhcq5
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata259 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style74 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata259
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style74
    {
        public Groups67 groups { get; set; }
        public Properties73 properties { get; set; }
        public Propertiessource66 propertiesSource { get; set; }
    }

    public class Groups67
    {
    }

    public class Properties73
    {
        public string alphabg { get; set; }
        public string alphabgh { get; set; }
        public string alphabrd { get; set; }
        public string alphabrdh { get; set; }
        public string alphatxt { get; set; }
        public string alphatxth { get; set; }
        public string bg { get; set; }
        public string bgh { get; set; }
        public string boxShadowToggleOnshd { get; set; }
        public string brd { get; set; }
        public string brdh { get; set; }
        public string brw { get; set; }
        public string fnt { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
        public string txt { get; set; }
        public string txth { get; set; }
    }

    public class Propertiessource66
    {
        public string bg { get; set; }
        public string bgh { get; set; }
        public string brd { get; set; }
        public string brdh { get; set; }
        public string brw { get; set; }
        public string fnt { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
        public string txt { get; set; }
        public string txth { get; set; }
    }

    public class StyleJ2hjjx6q
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata260 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style75 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata260
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style75
    {
        public Groups68 groups { get; set; }
        public Properties74 properties { get; set; }
        public Propertiessource67 propertiesSource { get; set; }
    }

    public class Groups68
    {
    }

    public class Properties74
    {
        public string alphatxt { get; set; }
        public string alphatxth { get; set; }
        public string fnt { get; set; }
        public string txt { get; set; }
        public string txth { get; set; }
    }

    public class Propertiessource67
    {
        public string fnt { get; set; }
        public string txt { get; set; }
        public string txth { get; set; }
    }

    public class StyleJ2hk2u4i
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata261 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style76 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata261
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style76
    {
        public Groups69 groups { get; set; }
        public Properties75 properties { get; set; }
        public Propertiessource68 propertiesSource { get; set; }
    }

    public class Groups69
    {
    }

    public class Properties75
    {
        public string alphabg { get; set; }
        public string alphabgh { get; set; }
        public string alphabrd { get; set; }
        public string alphabrdh { get; set; }
        public string alphatxt { get; set; }
        public string alphatxth { get; set; }
        public string bg { get; set; }
        public string bgh { get; set; }
        public string boxShadowToggleOnshd { get; set; }
        public string brd { get; set; }
        public string brdh { get; set; }
        public string brw { get; set; }
        public string fnt { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
        public string txt { get; set; }
        public string txth { get; set; }
    }

    public class Propertiessource68
    {
        public string alphabrdh { get; set; }
        public string bg { get; set; }
        public string bgh { get; set; }
        public string brd { get; set; }
        public string brdh { get; set; }
        public string brw { get; set; }
        public string fnt { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
        public string txt { get; set; }
        public string txth { get; set; }
    }

    public class StyleJ2hk42d7
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata262 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style77 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata262
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style77
    {
        public Groups70 groups { get; set; }
        public Properties76 properties { get; set; }
        public Propertiessource69 propertiesSource { get; set; }
    }

    public class Groups70
    {
    }

    public class Properties76
    {
        public string alphabg { get; set; }
        public string alphabgh { get; set; }
        public string alphabrd { get; set; }
        public string alphabrdh { get; set; }
        public string alphatxt { get; set; }
        public string alphatxth { get; set; }
        public string bg { get; set; }
        public string bgh { get; set; }
        public string boxShadowToggleOnshd { get; set; }
        public string brd { get; set; }
        public string brdh { get; set; }
        public string brw { get; set; }
        public string fnt { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
        public string txt { get; set; }
        public string txth { get; set; }
    }

    public class Propertiessource69
    {
        public string alphabrdh { get; set; }
        public string bg { get; set; }
        public string bgh { get; set; }
        public string brd { get; set; }
        public string brdh { get; set; }
        public string brw { get; set; }
        public string fnt { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
        public string txt { get; set; }
        public string txth { get; set; }
    }

    public class StyleJ2hk5vl2
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata263 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style78 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata263
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style78
    {
        public Groups71 groups { get; set; }
        public Properties77 properties { get; set; }
        public Propertiessource70 propertiesSource { get; set; }
    }

    public class Groups71
    {
    }

    public class Properties77
    {
        public string alphabg { get; set; }
        public string alphabgh { get; set; }
        public string alphabrd { get; set; }
        public string alphabrdh { get; set; }
        public string alphatxt { get; set; }
        public string alphatxth { get; set; }
        public string bg { get; set; }
        public string bgh { get; set; }
        public string boxShadowToggleOnshd { get; set; }
        public string brd { get; set; }
        public string brdh { get; set; }
        public string brw { get; set; }
        public string fnt { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
        public string txt { get; set; }
        public string txth { get; set; }
    }

    public class Propertiessource70
    {
        public string alphabrdh { get; set; }
        public string bg { get; set; }
        public string bgh { get; set; }
        public string brd { get; set; }
        public string brdh { get; set; }
        public string brw { get; set; }
        public string fnt { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
        public string txt { get; set; }
        public string txth { get; set; }
    }

    public class StyleJ2hk6z8j
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata264 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style79 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata264
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style79
    {
        public Groups72 groups { get; set; }
        public Properties78 properties { get; set; }
        public Propertiessource71 propertiesSource { get; set; }
    }

    public class Groups72
    {
    }

    public class Properties78
    {
        public string alphabg { get; set; }
        public string alphabgctr { get; set; }
        public string alphabrd { get; set; }
        public string bg { get; set; }
        public string bgctr { get; set; }
        public string boxShadowToggleOnshd { get; set; }
        public string brd { get; set; }
        public string brwb { get; set; }
        public string brwt { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
    }

    public class Propertiessource71
    {
        public string bg { get; set; }
        public string bgctr { get; set; }
        public string brd { get; set; }
        public string brwb { get; set; }
        public string brwt { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
    }

    public class StyleJ2hnpdu2
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata265 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style80 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata265
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style80
    {
        public Groups73 groups { get; set; }
        public Properties79 properties { get; set; }
        public Propertiessource72 propertiesSource { get; set; }
    }

    public class Groups73
    {
    }

    public class Properties79
    {
        public string alphabg { get; set; }
        public string alphabgd { get; set; }
        public string alphabgh { get; set; }
        public string alphabrd { get; set; }
        public string alphabrdd { get; set; }
        public string alphabrdh { get; set; }
        public string bg { get; set; }
        public string bgd { get; set; }
        public string bgh { get; set; }
        public string boxShadowToggleOnshd { get; set; }
        public string brd { get; set; }
        public string brdd { get; set; }
        public string brdh { get; set; }
        public string brw { get; set; }
        public string fnt { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
        public string txt { get; set; }
        public string txtd { get; set; }
        public string txth { get; set; }
    }

    public class Propertiessource72
    {
        public string alphabg { get; set; }
        public string alphabgd { get; set; }
        public string alphabgh { get; set; }
        public string alphabrd { get; set; }
        public string alphabrdd { get; set; }
        public string alphabrdh { get; set; }
        public string bg { get; set; }
        public string bgd { get; set; }
        public string bgh { get; set; }
        public string boxShadowToggleOnshd { get; set; }
        public string brd { get; set; }
        public string brdd { get; set; }
        public string brdh { get; set; }
        public string brw { get; set; }
        public string fnt { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
        public string txt { get; set; }
        public string txtd { get; set; }
        public string txth { get; set; }
    }

    public class StyleJ3bhljbe
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata266 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style81 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata266
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style81
    {
        public Groups74 groups { get; set; }
        public Properties80 properties { get; set; }
        public Propertiessource73 propertiesSource { get; set; }
    }

    public class Groups74
    {
    }

    public class Properties80
    {
    }

    public class Propertiessource73
    {
    }

    public class StyleJ3blz3eo
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata267 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style82 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata267
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style82
    {
        public Groups75 groups { get; set; }
        public Properties81 properties { get; set; }
        public Propertiessource74 propertiesSource { get; set; }
    }

    public class Groups75
    {
    }

    public class Properties81
    {
        public string alphabg { get; set; }
        public string alphabgh { get; set; }
        public string alphabrd { get; set; }
        public string alphabrdh { get; set; }
        public string alphatxt { get; set; }
        public string alphatxth { get; set; }
        public string bg { get; set; }
        public string bgh { get; set; }
        public string boxShadowToggleOnshd { get; set; }
        public string brd { get; set; }
        public string brdh { get; set; }
        public string brw { get; set; }
        public string fnt { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
        public string txt { get; set; }
        public string txth { get; set; }
    }

    public class Propertiessource74
    {
        public string alphabrdh { get; set; }
        public string bg { get; set; }
        public string bgh { get; set; }
        public string brd { get; set; }
        public string brdh { get; set; }
        public string brw { get; set; }
        public string fnt { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
        public string txt { get; set; }
        public string txth { get; set; }
    }

    public class StyleJ4dz9as6
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata268 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style83 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata268
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style83
    {
        public Groups76 groups { get; set; }
        public Properties82 properties { get; set; }
        public Propertiessource75 propertiesSource { get; set; }
    }

    public class Groups76
    {
    }

    public class Properties82
    {
    }

    public class Propertiessource75
    {
    }

    public class StyleJ4dzdbaq
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata269 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style84 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata269
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style84
    {
        public Groups77 groups { get; set; }
        public Properties83 properties { get; set; }
        public Propertiessource76 propertiesSource { get; set; }
    }

    public class Groups77
    {
    }

    public class Properties83
    {
    }

    public class Propertiessource76
    {
    }

    public class StyleJ4idd1um1
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata270 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style85 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata270
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style85
    {
        public Groups78 groups { get; set; }
        public Properties84 properties { get; set; }
        public Propertiessource77 propertiesSource { get; set; }
    }

    public class Groups78
    {
    }

    public class Properties84
    {
        public string alphabg { get; set; }
        public string alphabgh { get; set; }
        public string alphabrd { get; set; }
        public string alphabrdh { get; set; }
        public string alphatxt { get; set; }
        public string alphatxth { get; set; }
        public string bg { get; set; }
        public string bgh { get; set; }
        public string boxShadowToggleOnshd { get; set; }
        public string brd { get; set; }
        public string brdh { get; set; }
        public string brw { get; set; }
        public string fnt { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
        public string txt { get; set; }
        public string txth { get; set; }
    }

    public class Propertiessource77
    {
        public string alphabrdh { get; set; }
        public string bg { get; set; }
        public string bgh { get; set; }
        public string brd { get; set; }
        public string brdh { get; set; }
        public string brw { get; set; }
        public string fnt { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
        public string txt { get; set; }
        public string txth { get; set; }
    }

    public class StyleJ4nw2ymi
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata271 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style86 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata271
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style86
    {
        public Groups79 groups { get; set; }
        public Properties85 properties { get; set; }
        public Propertiessource78 propertiesSource { get; set; }
    }

    public class Groups79
    {
    }

    public class Properties85
    {
        public string alphabg { get; set; }
        public string alphabgd { get; set; }
        public string alphabgh { get; set; }
        public string alphabrd { get; set; }
        public string alphabrdd { get; set; }
        public string alphabrdh { get; set; }
        public string bg { get; set; }
        public string bgd { get; set; }
        public string bgh { get; set; }
        public string boxShadowToggleOnshd { get; set; }
        public string brd { get; set; }
        public string brdd { get; set; }
        public string brdh { get; set; }
        public string brw { get; set; }
        public string fnt { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
        public string txt { get; set; }
        public string txtd { get; set; }
        public string txth { get; set; }
    }

    public class Propertiessource78
    {
        public string alphabg { get; set; }
        public string alphabgd { get; set; }
        public string alphabgh { get; set; }
        public string alphabrd { get; set; }
        public string alphabrdd { get; set; }
        public string alphabrdh { get; set; }
        public string bg { get; set; }
        public string bgd { get; set; }
        public string bgh { get; set; }
        public string boxShadowToggleOnshd { get; set; }
        public string brd { get; set; }
        public string brdd { get; set; }
        public string brdh { get; set; }
        public string brw { get; set; }
        public string fnt { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
        public string txt { get; set; }
        public string txtd { get; set; }
        public string txth { get; set; }
    }

    public class StyleJ4nw81di
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata272 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style87 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata272
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style87
    {
        public Groups80 groups { get; set; }
        public Properties86 properties { get; set; }
        public Propertiessource79 propertiesSource { get; set; }
    }

    public class Groups80
    {
    }

    public class Properties86
    {
        public string alphabg { get; set; }
        public string alphabgd { get; set; }
        public string alphabgh { get; set; }
        public string alphabrd { get; set; }
        public string alphabrdd { get; set; }
        public string alphabrdh { get; set; }
        public string bg { get; set; }
        public string bgd { get; set; }
        public string bgh { get; set; }
        public string boxShadowToggleOnshd { get; set; }
        public string brd { get; set; }
        public string brdd { get; set; }
        public string brdh { get; set; }
        public string brw { get; set; }
        public string fnt { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
        public string txt { get; set; }
        public string txtd { get; set; }
        public string txth { get; set; }
    }

    public class Propertiessource79
    {
        public string alphabg { get; set; }
        public string alphabgd { get; set; }
        public string alphabgh { get; set; }
        public string alphabrd { get; set; }
        public string alphabrdd { get; set; }
        public string alphabrdh { get; set; }
        public string bg { get; set; }
        public string bgd { get; set; }
        public string bgh { get; set; }
        public string boxShadowToggleOnshd { get; set; }
        public string brd { get; set; }
        public string brdd { get; set; }
        public string brdh { get; set; }
        public string brw { get; set; }
        public string fnt { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
        public string txt { get; set; }
        public string txtd { get; set; }
        public string txth { get; set; }
    }

    public class StyleJ4nwd9dr
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata273 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style88 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata273
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style88
    {
        public Groups81 groups { get; set; }
        public Properties87 properties { get; set; }
        public Propertiessource80 propertiesSource { get; set; }
    }

    public class Groups81
    {
    }

    public class Properties87
    {
        public string alphabg { get; set; }
        public string alphabgd { get; set; }
        public string alphabgh { get; set; }
        public string alphabrd { get; set; }
        public string alphabrdd { get; set; }
        public string alphabrdh { get; set; }
        public string bg { get; set; }
        public string bgd { get; set; }
        public string bgh { get; set; }
        public string boxShadowToggleOnshd { get; set; }
        public string brd { get; set; }
        public string brdd { get; set; }
        public string brdh { get; set; }
        public string brw { get; set; }
        public string fnt { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
        public string txt { get; set; }
        public string txtd { get; set; }
        public string txth { get; set; }
    }

    public class Propertiessource80
    {
        public string alphabg { get; set; }
        public string alphabgd { get; set; }
        public string alphabgh { get; set; }
        public string alphabrd { get; set; }
        public string alphabrdd { get; set; }
        public string alphabrdh { get; set; }
        public string bg { get; set; }
        public string bgd { get; set; }
        public string bgh { get; set; }
        public string boxShadowToggleOnshd { get; set; }
        public string brd { get; set; }
        public string brdd { get; set; }
        public string brdh { get; set; }
        public string brw { get; set; }
        public string fnt { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
        public string txt { get; set; }
        public string txtd { get; set; }
        public string txth { get; set; }
    }

    public class StyleJ4nwdxip
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata274 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style89 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata274
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style89
    {
        public Groups82 groups { get; set; }
        public Properties88 properties { get; set; }
        public Propertiessource81 propertiesSource { get; set; }
    }

    public class Groups82
    {
    }

    public class Properties88
    {
        public string alphabg { get; set; }
        public string alphabgd { get; set; }
        public string alphabgh { get; set; }
        public string alphabrd { get; set; }
        public string alphabrdd { get; set; }
        public string alphabrdh { get; set; }
        public string bg { get; set; }
        public string bgd { get; set; }
        public string bgh { get; set; }
        public string boxShadowToggleOnshd { get; set; }
        public string brd { get; set; }
        public string brdd { get; set; }
        public string brdh { get; set; }
        public string brw { get; set; }
        public string fnt { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
        public string txt { get; set; }
        public string txtd { get; set; }
        public string txth { get; set; }
    }

    public class Propertiessource81
    {
        public string alphabg { get; set; }
        public string alphabgd { get; set; }
        public string alphabgh { get; set; }
        public string alphabrd { get; set; }
        public string alphabrdd { get; set; }
        public string alphabrdh { get; set; }
        public string bg { get; set; }
        public string bgd { get; set; }
        public string bgh { get; set; }
        public string boxShadowToggleOnshd { get; set; }
        public string brd { get; set; }
        public string brdd { get; set; }
        public string brdh { get; set; }
        public string brw { get; set; }
        public string fnt { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
        public string txt { get; set; }
        public string txtd { get; set; }
        public string txth { get; set; }
    }

    public class StyleJ4nwerfg
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata275 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style90 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata275
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style90
    {
        public Groups83 groups { get; set; }
        public Properties89 properties { get; set; }
        public Propertiessource82 propertiesSource { get; set; }
    }

    public class Groups83
    {
    }

    public class Properties89
    {
        public string alphabg { get; set; }
        public string alphabgd { get; set; }
        public string alphabgh { get; set; }
        public string alphabrd { get; set; }
        public string alphabrdd { get; set; }
        public string alphabrdh { get; set; }
        public string bg { get; set; }
        public string bgd { get; set; }
        public string bgh { get; set; }
        public string boxShadowToggleOnshd { get; set; }
        public string brd { get; set; }
        public string brdd { get; set; }
        public string brdh { get; set; }
        public string brw { get; set; }
        public string fnt { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
        public string txt { get; set; }
        public string txtd { get; set; }
        public string txth { get; set; }
    }

    public class Propertiessource82
    {
        public string alphabg { get; set; }
        public string alphabgd { get; set; }
        public string alphabgh { get; set; }
        public string alphabrd { get; set; }
        public string alphabrdd { get; set; }
        public string alphabrdh { get; set; }
        public string bg { get; set; }
        public string bgd { get; set; }
        public string bgh { get; set; }
        public string boxShadowToggleOnshd { get; set; }
        public string brd { get; set; }
        public string brdd { get; set; }
        public string brdh { get; set; }
        public string brw { get; set; }
        public string fnt { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
        public string txt { get; set; }
        public string txtd { get; set; }
        public string txth { get; set; }
    }

    public class StyleJ4nwffwv
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata276 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style91 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata276
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style91
    {
        public Groups84 groups { get; set; }
        public Properties90 properties { get; set; }
        public Propertiessource83 propertiesSource { get; set; }
    }

    public class Groups84
    {
    }

    public class Properties90
    {
        public string alphabg { get; set; }
        public string alphabgd { get; set; }
        public string alphabgh { get; set; }
        public string alphabrd { get; set; }
        public string alphabrdd { get; set; }
        public string alphabrdh { get; set; }
        public string bg { get; set; }
        public string bgd { get; set; }
        public string bgh { get; set; }
        public string boxShadowToggleOnshd { get; set; }
        public string brd { get; set; }
        public string brdd { get; set; }
        public string brdh { get; set; }
        public string brw { get; set; }
        public string fnt { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
        public string txt { get; set; }
        public string txtd { get; set; }
        public string txth { get; set; }
    }

    public class Propertiessource83
    {
        public string alphabg { get; set; }
        public string alphabgd { get; set; }
        public string alphabgh { get; set; }
        public string alphabrd { get; set; }
        public string alphabrdd { get; set; }
        public string alphabrdh { get; set; }
        public string bg { get; set; }
        public string bgd { get; set; }
        public string bgh { get; set; }
        public string boxShadowToggleOnshd { get; set; }
        public string brd { get; set; }
        public string brdd { get; set; }
        public string brdh { get; set; }
        public string brw { get; set; }
        public string fnt { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
        public string txt { get; set; }
        public string txtd { get; set; }
        public string txth { get; set; }
    }

    public class StyleJ4nwihwq
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata277 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style92 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata277
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style92
    {
        public Groups85 groups { get; set; }
        public Properties91 properties { get; set; }
        public Propertiessource84 propertiesSource { get; set; }
    }

    public class Groups85
    {
    }

    public class Properties91
    {
        public string alphabg { get; set; }
        public string alphabgd { get; set; }
        public string alphabgh { get; set; }
        public string alphabrd { get; set; }
        public string alphabrdd { get; set; }
        public string alphabrdh { get; set; }
        public string bg { get; set; }
        public string bgd { get; set; }
        public string bgh { get; set; }
        public string boxShadowToggleOnshd { get; set; }
        public string brd { get; set; }
        public string brdd { get; set; }
        public string brdh { get; set; }
        public string brw { get; set; }
        public string fnt { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
        public string txt { get; set; }
        public string txtd { get; set; }
        public string txth { get; set; }
    }

    public class Propertiessource84
    {
        public string alphabg { get; set; }
        public string alphabgd { get; set; }
        public string alphabgh { get; set; }
        public string alphabrd { get; set; }
        public string alphabrdd { get; set; }
        public string alphabrdh { get; set; }
        public string bg { get; set; }
        public string bgd { get; set; }
        public string bgh { get; set; }
        public string boxShadowToggleOnshd { get; set; }
        public string brd { get; set; }
        public string brdd { get; set; }
        public string brdh { get; set; }
        public string brw { get; set; }
        public string fnt { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
        public string txt { get; set; }
        public string txtd { get; set; }
        public string txth { get; set; }
    }

    public class StyleJ4nwj2ri
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata278 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style93 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata278
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style93
    {
        public Groups86 groups { get; set; }
        public Properties92 properties { get; set; }
        public Propertiessource85 propertiesSource { get; set; }
    }

    public class Groups86
    {
    }

    public class Properties92
    {
        public string alphabg { get; set; }
        public string alphabgd { get; set; }
        public string alphabgh { get; set; }
        public string alphabrd { get; set; }
        public string alphabrdd { get; set; }
        public string alphabrdh { get; set; }
        public string bg { get; set; }
        public string bgd { get; set; }
        public string bgh { get; set; }
        public string boxShadowToggleOnshd { get; set; }
        public string brd { get; set; }
        public string brdd { get; set; }
        public string brdh { get; set; }
        public string brw { get; set; }
        public string fnt { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
        public string txt { get; set; }
        public string txtd { get; set; }
        public string txth { get; set; }
    }

    public class Propertiessource85
    {
        public string alphabg { get; set; }
        public string alphabgd { get; set; }
        public string alphabgh { get; set; }
        public string alphabrd { get; set; }
        public string alphabrdd { get; set; }
        public string alphabrdh { get; set; }
        public string bg { get; set; }
        public string bgd { get; set; }
        public string bgh { get; set; }
        public string boxShadowToggleOnshd { get; set; }
        public string brd { get; set; }
        public string brdd { get; set; }
        public string brdh { get; set; }
        public string brw { get; set; }
        public string fnt { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
        public string txt { get; set; }
        public string txtd { get; set; }
        public string txth { get; set; }
    }

    public class StyleJ4nwju9u
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata279 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style94 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata279
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style94
    {
        public Groups87 groups { get; set; }
        public Properties93 properties { get; set; }
        public Propertiessource86 propertiesSource { get; set; }
    }

    public class Groups87
    {
    }

    public class Properties93
    {
        public string alphabg { get; set; }
        public string alphabgd { get; set; }
        public string alphabgh { get; set; }
        public string alphabrd { get; set; }
        public string alphabrdd { get; set; }
        public string alphabrdh { get; set; }
        public string bg { get; set; }
        public string bgd { get; set; }
        public string bgh { get; set; }
        public string boxShadowToggleOnshd { get; set; }
        public string brd { get; set; }
        public string brdd { get; set; }
        public string brdh { get; set; }
        public string brw { get; set; }
        public string fnt { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
        public string txt { get; set; }
        public string txtd { get; set; }
        public string txth { get; set; }
    }

    public class Propertiessource86
    {
        public string alphabg { get; set; }
        public string alphabgd { get; set; }
        public string alphabgh { get; set; }
        public string alphabrd { get; set; }
        public string alphabrdd { get; set; }
        public string alphabrdh { get; set; }
        public string bg { get; set; }
        public string bgd { get; set; }
        public string bgh { get; set; }
        public string boxShadowToggleOnshd { get; set; }
        public string brd { get; set; }
        public string brdd { get; set; }
        public string brdh { get; set; }
        public string brw { get; set; }
        public string fnt { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
        public string txt { get; set; }
        public string txtd { get; set; }
        public string txth { get; set; }
    }

    public class StyleJ4nwkja3
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata280 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style95 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata280
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style95
    {
        public Groups88 groups { get; set; }
        public Properties94 properties { get; set; }
        public Propertiessource87 propertiesSource { get; set; }
    }

    public class Groups88
    {
    }

    public class Properties94
    {
        public string alphabg { get; set; }
        public string alphabgd { get; set; }
        public string alphabgh { get; set; }
        public string alphabrd { get; set; }
        public string alphabrdd { get; set; }
        public string alphabrdh { get; set; }
        public string bg { get; set; }
        public string bgd { get; set; }
        public string bgh { get; set; }
        public string boxShadowToggleOnshd { get; set; }
        public string brd { get; set; }
        public string brdd { get; set; }
        public string brdh { get; set; }
        public string brw { get; set; }
        public string fnt { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
        public string txt { get; set; }
        public string txtd { get; set; }
        public string txth { get; set; }
    }

    public class Propertiessource87
    {
        public string alphabg { get; set; }
        public string alphabgd { get; set; }
        public string alphabgh { get; set; }
        public string alphabrd { get; set; }
        public string alphabrdd { get; set; }
        public string alphabrdh { get; set; }
        public string bg { get; set; }
        public string bgd { get; set; }
        public string bgh { get; set; }
        public string boxShadowToggleOnshd { get; set; }
        public string brd { get; set; }
        public string brdd { get; set; }
        public string brdh { get; set; }
        public string brw { get; set; }
        public string fnt { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
        public string txt { get; set; }
        public string txtd { get; set; }
        public string txth { get; set; }
    }

    public class StyleJ4nwl8wp
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata281 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style96 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata281
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style96
    {
        public Groups89 groups { get; set; }
        public Properties95 properties { get; set; }
        public Propertiessource88 propertiesSource { get; set; }
    }

    public class Groups89
    {
    }

    public class Properties95
    {
        public string alphabg { get; set; }
        public string alphabgd { get; set; }
        public string alphabgh { get; set; }
        public string alphabrd { get; set; }
        public string alphabrdd { get; set; }
        public string alphabrdh { get; set; }
        public string bg { get; set; }
        public string bgd { get; set; }
        public string bgh { get; set; }
        public string boxShadowToggleOnshd { get; set; }
        public string brd { get; set; }
        public string brdd { get; set; }
        public string brdh { get; set; }
        public string brw { get; set; }
        public string fnt { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
        public string txt { get; set; }
        public string txtd { get; set; }
        public string txth { get; set; }
    }

    public class Propertiessource88
    {
        public string alphabg { get; set; }
        public string alphabgd { get; set; }
        public string alphabgh { get; set; }
        public string alphabrd { get; set; }
        public string alphabrdd { get; set; }
        public string alphabrdh { get; set; }
        public string bg { get; set; }
        public string bgd { get; set; }
        public string bgh { get; set; }
        public string boxShadowToggleOnshd { get; set; }
        public string brd { get; set; }
        public string brdd { get; set; }
        public string brdh { get; set; }
        public string brw { get; set; }
        public string fnt { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
        public string txt { get; set; }
        public string txtd { get; set; }
        public string txth { get; set; }
    }

    public class StyleJ4nwlxwh
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata282 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style97 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata282
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style97
    {
        public Groups90 groups { get; set; }
        public Properties96 properties { get; set; }
        public Propertiessource89 propertiesSource { get; set; }
    }

    public class Groups90
    {
    }

    public class Properties96
    {
        public string alphabg { get; set; }
        public string alphabgd { get; set; }
        public string alphabgh { get; set; }
        public string alphabrd { get; set; }
        public string alphabrdd { get; set; }
        public string alphabrdh { get; set; }
        public string bg { get; set; }
        public string bgd { get; set; }
        public string bgh { get; set; }
        public string boxShadowToggleOnshd { get; set; }
        public string brd { get; set; }
        public string brdd { get; set; }
        public string brdh { get; set; }
        public string brw { get; set; }
        public string fnt { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
        public string txt { get; set; }
        public string txtd { get; set; }
        public string txth { get; set; }
    }

    public class Propertiessource89
    {
        public string alphabg { get; set; }
        public string alphabgd { get; set; }
        public string alphabgh { get; set; }
        public string alphabrd { get; set; }
        public string alphabrdd { get; set; }
        public string alphabrdh { get; set; }
        public string bg { get; set; }
        public string bgd { get; set; }
        public string bgh { get; set; }
        public string boxShadowToggleOnshd { get; set; }
        public string brd { get; set; }
        public string brdd { get; set; }
        public string brdh { get; set; }
        public string brw { get; set; }
        public string fnt { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
        public string txt { get; set; }
        public string txtd { get; set; }
        public string txth { get; set; }
    }

    public class StyleJ4nwmmkt
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata283 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style98 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata283
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style98
    {
        public Groups91 groups { get; set; }
        public Properties97 properties { get; set; }
        public Propertiessource90 propertiesSource { get; set; }
    }

    public class Groups91
    {
    }

    public class Properties97
    {
        public string alphabg { get; set; }
        public string alphabgd { get; set; }
        public string alphabgh { get; set; }
        public string alphabrd { get; set; }
        public string alphabrdd { get; set; }
        public string alphabrdh { get; set; }
        public string bg { get; set; }
        public string bgd { get; set; }
        public string bgh { get; set; }
        public string boxShadowToggleOnshd { get; set; }
        public string brd { get; set; }
        public string brdd { get; set; }
        public string brdh { get; set; }
        public string brw { get; set; }
        public string fnt { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
        public string txt { get; set; }
        public string txtd { get; set; }
        public string txth { get; set; }
    }

    public class Propertiessource90
    {
        public string alphabg { get; set; }
        public string alphabgd { get; set; }
        public string alphabgh { get; set; }
        public string alphabrd { get; set; }
        public string alphabrdd { get; set; }
        public string alphabrdh { get; set; }
        public string bg { get; set; }
        public string bgd { get; set; }
        public string bgh { get; set; }
        public string boxShadowToggleOnshd { get; set; }
        public string brd { get; set; }
        public string brdd { get; set; }
        public string brdh { get; set; }
        public string brw { get; set; }
        public string fnt { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
        public string txt { get; set; }
        public string txtd { get; set; }
        public string txth { get; set; }
    }

    public class StyleJ4nwnkdb
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata284 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style99 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata284
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style99
    {
        public Groups92 groups { get; set; }
        public Properties98 properties { get; set; }
        public Propertiessource91 propertiesSource { get; set; }
    }

    public class Groups92
    {
    }

    public class Properties98
    {
        public string alphabg { get; set; }
        public string alphabgd { get; set; }
        public string alphabgh { get; set; }
        public string alphabrd { get; set; }
        public string alphabrdd { get; set; }
        public string alphabrdh { get; set; }
        public string bg { get; set; }
        public string bgd { get; set; }
        public string bgh { get; set; }
        public string boxShadowToggleOnshd { get; set; }
        public string brd { get; set; }
        public string brdd { get; set; }
        public string brdh { get; set; }
        public string brw { get; set; }
        public string fnt { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
        public string txt { get; set; }
        public string txtd { get; set; }
        public string txth { get; set; }
    }

    public class Propertiessource91
    {
        public string alphabg { get; set; }
        public string alphabgd { get; set; }
        public string alphabgh { get; set; }
        public string alphabrd { get; set; }
        public string alphabrdd { get; set; }
        public string alphabrdh { get; set; }
        public string bg { get; set; }
        public string bgd { get; set; }
        public string bgh { get; set; }
        public string boxShadowToggleOnshd { get; set; }
        public string brd { get; set; }
        public string brdd { get; set; }
        public string brdh { get; set; }
        public string brw { get; set; }
        public string fnt { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
        public string txt { get; set; }
        public string txtd { get; set; }
        public string txth { get; set; }
    }

    public class StyleJ4nwoccm
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata285 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style100 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata285
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style100
    {
        public Groups93 groups { get; set; }
        public Properties99 properties { get; set; }
        public Propertiessource92 propertiesSource { get; set; }
    }

    public class Groups93
    {
    }

    public class Properties99
    {
        public string alphabg { get; set; }
        public string alphabgd { get; set; }
        public string alphabgh { get; set; }
        public string alphabrd { get; set; }
        public string alphabrdd { get; set; }
        public string alphabrdh { get; set; }
        public string bg { get; set; }
        public string bgd { get; set; }
        public string bgh { get; set; }
        public string boxShadowToggleOnshd { get; set; }
        public string brd { get; set; }
        public string brdd { get; set; }
        public string brdh { get; set; }
        public string brw { get; set; }
        public string fnt { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
        public string txt { get; set; }
        public string txtd { get; set; }
        public string txth { get; set; }
    }

    public class Propertiessource92
    {
        public string alphabg { get; set; }
        public string alphabgd { get; set; }
        public string alphabgh { get; set; }
        public string alphabrd { get; set; }
        public string alphabrdd { get; set; }
        public string alphabrdh { get; set; }
        public string bg { get; set; }
        public string bgd { get; set; }
        public string bgh { get; set; }
        public string boxShadowToggleOnshd { get; set; }
        public string brd { get; set; }
        public string brdd { get; set; }
        public string brdh { get; set; }
        public string brw { get; set; }
        public string fnt { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
        public string txt { get; set; }
        public string txtd { get; set; }
        public string txth { get; set; }
    }

    public class StyleJ4nwovp1
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata286 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style101 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata286
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style101
    {
        public Groups94 groups { get; set; }
        public Properties100 properties { get; set; }
        public Propertiessource93 propertiesSource { get; set; }
    }

    public class Groups94
    {
    }

    public class Properties100
    {
        public string alphabg { get; set; }
        public string alphabgd { get; set; }
        public string alphabgh { get; set; }
        public string alphabrd { get; set; }
        public string alphabrdd { get; set; }
        public string alphabrdh { get; set; }
        public string bg { get; set; }
        public string bgd { get; set; }
        public string bgh { get; set; }
        public string boxShadowToggleOnshd { get; set; }
        public string brd { get; set; }
        public string brdd { get; set; }
        public string brdh { get; set; }
        public string brw { get; set; }
        public string fnt { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
        public string txt { get; set; }
        public string txtd { get; set; }
        public string txth { get; set; }
    }

    public class Propertiessource93
    {
        public string alphabg { get; set; }
        public string alphabgd { get; set; }
        public string alphabgh { get; set; }
        public string alphabrd { get; set; }
        public string alphabrdd { get; set; }
        public string alphabrdh { get; set; }
        public string bg { get; set; }
        public string bgd { get; set; }
        public string bgh { get; set; }
        public string boxShadowToggleOnshd { get; set; }
        public string brd { get; set; }
        public string brdd { get; set; }
        public string brdh { get; set; }
        public string brw { get; set; }
        public string fnt { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
        public string txt { get; set; }
        public string txtd { get; set; }
        public string txth { get; set; }
    }

    public class StyleJ4nwqzkv
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata287 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style102 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata287
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style102
    {
        public Groups95 groups { get; set; }
        public Properties101 properties { get; set; }
        public Propertiessource94 propertiesSource { get; set; }
    }

    public class Groups95
    {
    }

    public class Properties101
    {
        public string alphabg { get; set; }
        public string alphabgd { get; set; }
        public string alphabgh { get; set; }
        public string alphabrd { get; set; }
        public string alphabrdd { get; set; }
        public string alphabrdh { get; set; }
        public string bg { get; set; }
        public string bgd { get; set; }
        public string bgh { get; set; }
        public string boxShadowToggleOnshd { get; set; }
        public string brd { get; set; }
        public string brdd { get; set; }
        public string brdh { get; set; }
        public string brw { get; set; }
        public string fnt { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
        public string txt { get; set; }
        public string txtd { get; set; }
        public string txth { get; set; }
    }

    public class Propertiessource94
    {
        public string alphabg { get; set; }
        public string alphabgd { get; set; }
        public string alphabgh { get; set; }
        public string alphabrd { get; set; }
        public string alphabrdd { get; set; }
        public string alphabrdh { get; set; }
        public string bg { get; set; }
        public string bgd { get; set; }
        public string bgh { get; set; }
        public string boxShadowToggleOnshd { get; set; }
        public string brd { get; set; }
        public string brdd { get; set; }
        public string brdh { get; set; }
        public string brw { get; set; }
        public string fnt { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
        public string txt { get; set; }
        public string txtd { get; set; }
        public string txth { get; set; }
    }

    public class StyleJ4nwwq4v
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata288 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style103 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata288
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style103
    {
        public Groups96 groups { get; set; }
        public Properties102 properties { get; set; }
        public Propertiessource95 propertiesSource { get; set; }
    }

    public class Groups96
    {
    }

    public class Properties102
    {
        public string alphabg { get; set; }
        public string alphabgd { get; set; }
        public string alphabgh { get; set; }
        public string alphabrd { get; set; }
        public string alphabrdd { get; set; }
        public string alphabrdh { get; set; }
        public string bg { get; set; }
        public string bgd { get; set; }
        public string bgh { get; set; }
        public string boxShadowToggleOnshd { get; set; }
        public string brd { get; set; }
        public string brdd { get; set; }
        public string brdh { get; set; }
        public string brw { get; set; }
        public string fnt { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
        public string txt { get; set; }
        public string txtd { get; set; }
        public string txth { get; set; }
    }

    public class Propertiessource95
    {
        public string alphabg { get; set; }
        public string alphabgd { get; set; }
        public string alphabgh { get; set; }
        public string alphabrd { get; set; }
        public string alphabrdd { get; set; }
        public string alphabrdh { get; set; }
        public string bg { get; set; }
        public string bgd { get; set; }
        public string bgh { get; set; }
        public string boxShadowToggleOnshd { get; set; }
        public string brd { get; set; }
        public string brdd { get; set; }
        public string brdh { get; set; }
        public string brw { get; set; }
        public string fnt { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
        public string txt { get; set; }
        public string txtd { get; set; }
        public string txth { get; set; }
    }

    public class StyleJ4nwxgqq
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata289 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style104 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata289
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style104
    {
        public Groups97 groups { get; set; }
        public Properties103 properties { get; set; }
        public Propertiessource96 propertiesSource { get; set; }
    }

    public class Groups97
    {
    }

    public class Properties103
    {
        public string alphabg { get; set; }
        public string alphabgd { get; set; }
        public string alphabgh { get; set; }
        public string alphabrd { get; set; }
        public string alphabrdd { get; set; }
        public string alphabrdh { get; set; }
        public string bg { get; set; }
        public string bgd { get; set; }
        public string bgh { get; set; }
        public string boxShadowToggleOnshd { get; set; }
        public string brd { get; set; }
        public string brdd { get; set; }
        public string brdh { get; set; }
        public string brw { get; set; }
        public string fnt { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
        public string txt { get; set; }
        public string txtd { get; set; }
        public string txth { get; set; }
    }

    public class Propertiessource96
    {
        public string alphabg { get; set; }
        public string alphabgd { get; set; }
        public string alphabgh { get; set; }
        public string alphabrd { get; set; }
        public string alphabrdd { get; set; }
        public string alphabrdh { get; set; }
        public string bg { get; set; }
        public string bgd { get; set; }
        public string bgh { get; set; }
        public string boxShadowToggleOnshd { get; set; }
        public string brd { get; set; }
        public string brdd { get; set; }
        public string brdh { get; set; }
        public string brw { get; set; }
        public string fnt { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
        public string txt { get; set; }
        public string txtd { get; set; }
        public string txth { get; set; }
    }

    public class StyleJ4nwy5tl
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata290 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style105 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata290
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style105
    {
        public Groups98 groups { get; set; }
        public Properties104 properties { get; set; }
        public Propertiessource97 propertiesSource { get; set; }
    }

    public class Groups98
    {
    }

    public class Properties104
    {
        public string alphabg { get; set; }
        public string alphabgd { get; set; }
        public string alphabgh { get; set; }
        public string alphabrd { get; set; }
        public string alphabrdd { get; set; }
        public string alphabrdh { get; set; }
        public string bg { get; set; }
        public string bgd { get; set; }
        public string bgh { get; set; }
        public string boxShadowToggleOnshd { get; set; }
        public string brd { get; set; }
        public string brdd { get; set; }
        public string brdh { get; set; }
        public string brw { get; set; }
        public string fnt { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
        public string txt { get; set; }
        public string txtd { get; set; }
        public string txth { get; set; }
    }

    public class Propertiessource97
    {
        public string alphabg { get; set; }
        public string alphabgd { get; set; }
        public string alphabgh { get; set; }
        public string alphabrd { get; set; }
        public string alphabrdd { get; set; }
        public string alphabrdh { get; set; }
        public string bg { get; set; }
        public string bgd { get; set; }
        public string bgh { get; set; }
        public string boxShadowToggleOnshd { get; set; }
        public string brd { get; set; }
        public string brdd { get; set; }
        public string brdh { get; set; }
        public string brw { get; set; }
        public string fnt { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
        public string txt { get; set; }
        public string txtd { get; set; }
        public string txth { get; set; }
    }

    public class StyleJ4nx0f5m
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata291 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style106 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata291
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style106
    {
        public Groups99 groups { get; set; }
        public Properties105 properties { get; set; }
        public Propertiessource98 propertiesSource { get; set; }
    }

    public class Groups99
    {
    }

    public class Properties105
    {
        public string alphabg { get; set; }
        public string alphabgd { get; set; }
        public string alphabgh { get; set; }
        public string alphabrd { get; set; }
        public string alphabrdd { get; set; }
        public string alphabrdh { get; set; }
        public string bg { get; set; }
        public string bgd { get; set; }
        public string bgh { get; set; }
        public string boxShadowToggleOnshd { get; set; }
        public string brd { get; set; }
        public string brdd { get; set; }
        public string brdh { get; set; }
        public string brw { get; set; }
        public string fnt { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
        public string txt { get; set; }
        public string txtd { get; set; }
        public string txth { get; set; }
    }

    public class Propertiessource98
    {
        public string alphabg { get; set; }
        public string alphabgd { get; set; }
        public string alphabgh { get; set; }
        public string alphabrd { get; set; }
        public string alphabrdd { get; set; }
        public string alphabrdh { get; set; }
        public string bg { get; set; }
        public string bgd { get; set; }
        public string bgh { get; set; }
        public string boxShadowToggleOnshd { get; set; }
        public string brd { get; set; }
        public string brdd { get; set; }
        public string brdh { get; set; }
        public string brw { get; set; }
        public string fnt { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
        public string txt { get; set; }
        public string txtd { get; set; }
        public string txth { get; set; }
    }

    public class StyleJ4nx1fj9
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata292 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style107 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata292
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style107
    {
        public Groups100 groups { get; set; }
        public Properties106 properties { get; set; }
        public Propertiessource99 propertiesSource { get; set; }
    }

    public class Groups100
    {
    }

    public class Properties106
    {
        public string alphabg { get; set; }
        public string alphabgd { get; set; }
        public string alphabgh { get; set; }
        public string alphabrd { get; set; }
        public string alphabrdd { get; set; }
        public string alphabrdh { get; set; }
        public string bg { get; set; }
        public string bgd { get; set; }
        public string bgh { get; set; }
        public string boxShadowToggleOnshd { get; set; }
        public string brd { get; set; }
        public string brdd { get; set; }
        public string brdh { get; set; }
        public string brw { get; set; }
        public string fnt { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
        public string txt { get; set; }
        public string txtd { get; set; }
        public string txth { get; set; }
    }

    public class Propertiessource99
    {
        public string alphabg { get; set; }
        public string alphabgd { get; set; }
        public string alphabgh { get; set; }
        public string alphabrd { get; set; }
        public string alphabrdd { get; set; }
        public string alphabrdh { get; set; }
        public string bg { get; set; }
        public string bgd { get; set; }
        public string bgh { get; set; }
        public string boxShadowToggleOnshd { get; set; }
        public string brd { get; set; }
        public string brdd { get; set; }
        public string brdh { get; set; }
        public string brw { get; set; }
        public string fnt { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
        public string txt { get; set; }
        public string txtd { get; set; }
        public string txth { get; set; }
    }

    public class StyleJ4nx21jo
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata293 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style108 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata293
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style108
    {
        public Groups101 groups { get; set; }
        public Properties107 properties { get; set; }
        public Propertiessource100 propertiesSource { get; set; }
    }

    public class Groups101
    {
    }

    public class Properties107
    {
        public string alphabg { get; set; }
        public string alphabgd { get; set; }
        public string alphabgh { get; set; }
        public string alphabrd { get; set; }
        public string alphabrdd { get; set; }
        public string alphabrdh { get; set; }
        public string bg { get; set; }
        public string bgd { get; set; }
        public string bgh { get; set; }
        public string boxShadowToggleOnshd { get; set; }
        public string brd { get; set; }
        public string brdd { get; set; }
        public string brdh { get; set; }
        public string brw { get; set; }
        public string fnt { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
        public string txt { get; set; }
        public string txtd { get; set; }
        public string txth { get; set; }
    }

    public class Propertiessource100
    {
        public string alphabg { get; set; }
        public string alphabgd { get; set; }
        public string alphabgh { get; set; }
        public string alphabrd { get; set; }
        public string alphabrdd { get; set; }
        public string alphabrdh { get; set; }
        public string bg { get; set; }
        public string bgd { get; set; }
        public string bgh { get; set; }
        public string boxShadowToggleOnshd { get; set; }
        public string brd { get; set; }
        public string brdd { get; set; }
        public string brdh { get; set; }
        public string brw { get; set; }
        public string fnt { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
        public string txt { get; set; }
        public string txtd { get; set; }
        public string txth { get; set; }
    }

    public class StyleJ4nx3lr5
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata294 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style109 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata294
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style109
    {
        public Groups102 groups { get; set; }
        public Properties108 properties { get; set; }
        public Propertiessource101 propertiesSource { get; set; }
    }

    public class Groups102
    {
    }

    public class Properties108
    {
        public string alphabg { get; set; }
        public string alphabgd { get; set; }
        public string alphabgh { get; set; }
        public string alphabrd { get; set; }
        public string alphabrdd { get; set; }
        public string alphabrdh { get; set; }
        public string bg { get; set; }
        public string bgd { get; set; }
        public string bgh { get; set; }
        public string boxShadowToggleOnshd { get; set; }
        public string brd { get; set; }
        public string brdd { get; set; }
        public string brdh { get; set; }
        public string brw { get; set; }
        public string fnt { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
        public string txt { get; set; }
        public string txtd { get; set; }
        public string txth { get; set; }
    }

    public class Propertiessource101
    {
        public string alphabg { get; set; }
        public string alphabgd { get; set; }
        public string alphabgh { get; set; }
        public string alphabrd { get; set; }
        public string alphabrdd { get; set; }
        public string alphabrdh { get; set; }
        public string bg { get; set; }
        public string bgd { get; set; }
        public string bgh { get; set; }
        public string boxShadowToggleOnshd { get; set; }
        public string brd { get; set; }
        public string brdd { get; set; }
        public string brdh { get; set; }
        public string brw { get; set; }
        public string fnt { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
        public string txt { get; set; }
        public string txtd { get; set; }
        public string txth { get; set; }
    }

    public class StyleJ4nx8nhl
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata295 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style110 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata295
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style110
    {
        public Groups103 groups { get; set; }
        public Properties109 properties { get; set; }
        public Propertiessource102 propertiesSource { get; set; }
    }

    public class Groups103
    {
    }

    public class Properties109
    {
        public string alphabg { get; set; }
        public string alphabgd { get; set; }
        public string alphabgh { get; set; }
        public string alphabrd { get; set; }
        public string alphabrdd { get; set; }
        public string alphabrdh { get; set; }
        public string bg { get; set; }
        public string bgd { get; set; }
        public string bgh { get; set; }
        public string boxShadowToggleOnshd { get; set; }
        public string brd { get; set; }
        public string brdd { get; set; }
        public string brdh { get; set; }
        public string brw { get; set; }
        public string fnt { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
        public string txt { get; set; }
        public string txtd { get; set; }
        public string txth { get; set; }
    }

    public class Propertiessource102
    {
        public string alphabg { get; set; }
        public string alphabgd { get; set; }
        public string alphabgh { get; set; }
        public string alphabrd { get; set; }
        public string alphabrdd { get; set; }
        public string alphabrdh { get; set; }
        public string bg { get; set; }
        public string bgd { get; set; }
        public string bgh { get; set; }
        public string boxShadowToggleOnshd { get; set; }
        public string brd { get; set; }
        public string brdd { get; set; }
        public string brdh { get; set; }
        public string brw { get; set; }
        public string fnt { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
        public string txt { get; set; }
        public string txtd { get; set; }
        public string txth { get; set; }
    }

    public class StyleJ4nx9dsw
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata296 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style111 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata296
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style111
    {
        public Groups104 groups { get; set; }
        public Properties110 properties { get; set; }
        public Propertiessource103 propertiesSource { get; set; }
    }

    public class Groups104
    {
    }

    public class Properties110
    {
        public string alphabg { get; set; }
        public string alphabgd { get; set; }
        public string alphabgh { get; set; }
        public string alphabrd { get; set; }
        public string alphabrdd { get; set; }
        public string alphabrdh { get; set; }
        public string bg { get; set; }
        public string bgd { get; set; }
        public string bgh { get; set; }
        public string boxShadowToggleOnshd { get; set; }
        public string brd { get; set; }
        public string brdd { get; set; }
        public string brdh { get; set; }
        public string brw { get; set; }
        public string fnt { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
        public string txt { get; set; }
        public string txtd { get; set; }
        public string txth { get; set; }
    }

    public class Propertiessource103
    {
        public string alphabg { get; set; }
        public string alphabgd { get; set; }
        public string alphabgh { get; set; }
        public string alphabrd { get; set; }
        public string alphabrdd { get; set; }
        public string alphabrdh { get; set; }
        public string bg { get; set; }
        public string bgd { get; set; }
        public string bgh { get; set; }
        public string boxShadowToggleOnshd { get; set; }
        public string brd { get; set; }
        public string brdd { get; set; }
        public string brdh { get; set; }
        public string brw { get; set; }
        public string fnt { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
        public string txt { get; set; }
        public string txtd { get; set; }
        public string txth { get; set; }
    }

    public class StyleJ4nxabh0
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata297 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style112 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata297
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style112
    {
        public Groups105 groups { get; set; }
        public Properties111 properties { get; set; }
        public Propertiessource104 propertiesSource { get; set; }
    }

    public class Groups105
    {
    }

    public class Properties111
    {
        public string alphabg { get; set; }
        public string alphabgd { get; set; }
        public string alphabgh { get; set; }
        public string alphabrd { get; set; }
        public string alphabrdd { get; set; }
        public string alphabrdh { get; set; }
        public string bg { get; set; }
        public string bgd { get; set; }
        public string bgh { get; set; }
        public string boxShadowToggleOnshd { get; set; }
        public string brd { get; set; }
        public string brdd { get; set; }
        public string brdh { get; set; }
        public string brw { get; set; }
        public string fnt { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
        public string txt { get; set; }
        public string txtd { get; set; }
        public string txth { get; set; }
    }

    public class Propertiessource104
    {
        public string alphabg { get; set; }
        public string alphabgd { get; set; }
        public string alphabgh { get; set; }
        public string alphabrd { get; set; }
        public string alphabrdd { get; set; }
        public string alphabrdh { get; set; }
        public string bg { get; set; }
        public string bgd { get; set; }
        public string bgh { get; set; }
        public string boxShadowToggleOnshd { get; set; }
        public string brd { get; set; }
        public string brdd { get; set; }
        public string brdh { get; set; }
        public string brw { get; set; }
        public string fnt { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
        public string txt { get; set; }
        public string txtd { get; set; }
        public string txth { get; set; }
    }

    public class StyleJ4nxb41k
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata298 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style113 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata298
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style113
    {
        public Groups106 groups { get; set; }
        public Properties112 properties { get; set; }
        public Propertiessource105 propertiesSource { get; set; }
    }

    public class Groups106
    {
    }

    public class Properties112
    {
        public string alphabg { get; set; }
        public string alphabgd { get; set; }
        public string alphabgh { get; set; }
        public string alphabrd { get; set; }
        public string alphabrdd { get; set; }
        public string alphabrdh { get; set; }
        public string bg { get; set; }
        public string bgd { get; set; }
        public string bgh { get; set; }
        public string boxShadowToggleOnshd { get; set; }
        public string brd { get; set; }
        public string brdd { get; set; }
        public string brdh { get; set; }
        public string brw { get; set; }
        public string fnt { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
        public string txt { get; set; }
        public string txtd { get; set; }
        public string txth { get; set; }
    }

    public class Propertiessource105
    {
        public string alphabg { get; set; }
        public string alphabgd { get; set; }
        public string alphabgh { get; set; }
        public string alphabrd { get; set; }
        public string alphabrdd { get; set; }
        public string alphabrdh { get; set; }
        public string bg { get; set; }
        public string bgd { get; set; }
        public string bgh { get; set; }
        public string boxShadowToggleOnshd { get; set; }
        public string brd { get; set; }
        public string brdd { get; set; }
        public string brdh { get; set; }
        public string brw { get; set; }
        public string fnt { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
        public string txt { get; set; }
        public string txtd { get; set; }
        public string txth { get; set; }
    }

    public class StyleJ4nxcwew
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata299 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style114 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata299
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style114
    {
        public Groups107 groups { get; set; }
        public Properties113 properties { get; set; }
        public Propertiessource106 propertiesSource { get; set; }
    }

    public class Groups107
    {
    }

    public class Properties113
    {
        public string alphabg { get; set; }
        public string alphabgd { get; set; }
        public string alphabgh { get; set; }
        public string alphabrd { get; set; }
        public string alphabrdd { get; set; }
        public string alphabrdh { get; set; }
        public string bg { get; set; }
        public string bgd { get; set; }
        public string bgh { get; set; }
        public string boxShadowToggleOnshd { get; set; }
        public string brd { get; set; }
        public string brdd { get; set; }
        public string brdh { get; set; }
        public string brw { get; set; }
        public string fnt { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
        public string txt { get; set; }
        public string txtd { get; set; }
        public string txth { get; set; }
    }

    public class Propertiessource106
    {
        public string alphabg { get; set; }
        public string alphabgd { get; set; }
        public string alphabgh { get; set; }
        public string alphabrd { get; set; }
        public string alphabrdd { get; set; }
        public string alphabrdh { get; set; }
        public string bg { get; set; }
        public string bgd { get; set; }
        public string bgh { get; set; }
        public string boxShadowToggleOnshd { get; set; }
        public string brd { get; set; }
        public string brdd { get; set; }
        public string brdh { get; set; }
        public string brw { get; set; }
        public string fnt { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
        public string txt { get; set; }
        public string txtd { get; set; }
        public string txth { get; set; }
    }

    public class StyleJ4nxeqsv
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata300 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style115 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata300
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style115
    {
        public Groups108 groups { get; set; }
        public Properties114 properties { get; set; }
        public Propertiessource107 propertiesSource { get; set; }
    }

    public class Groups108
    {
    }

    public class Properties114
    {
        public string alphabg { get; set; }
        public string alphabgd { get; set; }
        public string alphabgh { get; set; }
        public string alphabrd { get; set; }
        public string alphabrdd { get; set; }
        public string alphabrdh { get; set; }
        public string bg { get; set; }
        public string bgd { get; set; }
        public string bgh { get; set; }
        public string boxShadowToggleOnshd { get; set; }
        public string brd { get; set; }
        public string brdd { get; set; }
        public string brdh { get; set; }
        public string brw { get; set; }
        public string fnt { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
        public string txt { get; set; }
        public string txtd { get; set; }
        public string txth { get; set; }
    }

    public class Propertiessource107
    {
        public string alphabg { get; set; }
        public string alphabgd { get; set; }
        public string alphabgh { get; set; }
        public string alphabrd { get; set; }
        public string alphabrdd { get; set; }
        public string alphabrdh { get; set; }
        public string bg { get; set; }
        public string bgd { get; set; }
        public string bgh { get; set; }
        public string boxShadowToggleOnshd { get; set; }
        public string brd { get; set; }
        public string brdd { get; set; }
        public string brdh { get; set; }
        public string brw { get; set; }
        public string fnt { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
        public string txt { get; set; }
        public string txtd { get; set; }
        public string txth { get; set; }
    }

    public class StyleJ4nxfnb6
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata301 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style116 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata301
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style116
    {
        public Groups109 groups { get; set; }
        public Properties115 properties { get; set; }
        public Propertiessource108 propertiesSource { get; set; }
    }

    public class Groups109
    {
    }

    public class Properties115
    {
        public string alphabg { get; set; }
        public string alphabgd { get; set; }
        public string alphabgh { get; set; }
        public string alphabrd { get; set; }
        public string alphabrdd { get; set; }
        public string alphabrdh { get; set; }
        public string bg { get; set; }
        public string bgd { get; set; }
        public string bgh { get; set; }
        public string boxShadowToggleOnshd { get; set; }
        public string brd { get; set; }
        public string brdd { get; set; }
        public string brdh { get; set; }
        public string brw { get; set; }
        public string fnt { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
        public string txt { get; set; }
        public string txtd { get; set; }
        public string txth { get; set; }
    }

    public class Propertiessource108
    {
        public string alphabg { get; set; }
        public string alphabgd { get; set; }
        public string alphabgh { get; set; }
        public string alphabrd { get; set; }
        public string alphabrdd { get; set; }
        public string alphabrdh { get; set; }
        public string bg { get; set; }
        public string bgd { get; set; }
        public string bgh { get; set; }
        public string boxShadowToggleOnshd { get; set; }
        public string brd { get; set; }
        public string brdd { get; set; }
        public string brdh { get; set; }
        public string brw { get; set; }
        public string fnt { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
        public string txt { get; set; }
        public string txtd { get; set; }
        public string txth { get; set; }
    }

    public class StyleJ4nxgbsl
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata302 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style117 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata302
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style117
    {
        public Groups110 groups { get; set; }
        public Properties116 properties { get; set; }
        public Propertiessource109 propertiesSource { get; set; }
    }

    public class Groups110
    {
    }

    public class Properties116
    {
        public string alphabg { get; set; }
        public string alphabgd { get; set; }
        public string alphabgh { get; set; }
        public string alphabrd { get; set; }
        public string alphabrdd { get; set; }
        public string alphabrdh { get; set; }
        public string bg { get; set; }
        public string bgd { get; set; }
        public string bgh { get; set; }
        public string boxShadowToggleOnshd { get; set; }
        public string brd { get; set; }
        public string brdd { get; set; }
        public string brdh { get; set; }
        public string brw { get; set; }
        public string fnt { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
        public string txt { get; set; }
        public string txtd { get; set; }
        public string txth { get; set; }
    }

    public class Propertiessource109
    {
        public string alphabg { get; set; }
        public string alphabgd { get; set; }
        public string alphabgh { get; set; }
        public string alphabrd { get; set; }
        public string alphabrdd { get; set; }
        public string alphabrdh { get; set; }
        public string bg { get; set; }
        public string bgd { get; set; }
        public string bgh { get; set; }
        public string boxShadowToggleOnshd { get; set; }
        public string brd { get; set; }
        public string brdd { get; set; }
        public string brdh { get; set; }
        public string brw { get; set; }
        public string fnt { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
        public string txt { get; set; }
        public string txtd { get; set; }
        public string txth { get; set; }
    }

    public class StyleJ4pepbim
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata303 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style118 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata303
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style118
    {
        public Groups111 groups { get; set; }
        public Properties117 properties { get; set; }
        public Propertiessource110 propertiesSource { get; set; }
    }

    public class Groups111
    {
    }

    public class Properties117
    {
    }

    public class Propertiessource110
    {
    }

    public class StyleJ4trapsg
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata304 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style119 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata304
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style119
    {
        public Groups112 groups { get; set; }
        public Properties118 properties { get; set; }
        public Propertiessource111 propertiesSource { get; set; }
    }

    public class Groups112
    {
    }

    public class Properties118
    {
        public string alphabg { get; set; }
        public string alphabgDrop { get; set; }
        public string alphabgOpen { get; set; }
        public string alphaborderColorSelected { get; set; }
        public string alphabordercolor { get; set; }
        public string alphaiconcolor { get; set; }
        public string alphaiconcolorSelected { get; set; }
        public string alphaseparatorColor { get; set; }
        public string bg { get; set; }
        public string bgDrop { get; set; }
        public string bgOpen { get; set; }
        public string borderColorSelected { get; set; }
        public string borderWidthSelected { get; set; }
        public string bordercolor { get; set; }
        public string borderwidth { get; set; }
        public string fnt { get; set; }
        public string iconcolor { get; set; }
        public string iconcolorSelected { get; set; }
        public string linewidth { get; set; }
        public string rd { get; set; }
        public string separatorColor { get; set; }
        public string separatorHeight { get; set; }
        public string separatorWidthFull { get; set; }
        public string strokewidth { get; set; }
        public string textAlignment { get; set; }
        public string txt { get; set; }
        public string txts { get; set; }
    }

    public class Propertiessource111
    {
        public string alphabg { get; set; }
        public string alphabgDrop { get; set; }
        public string alphabgOpen { get; set; }
        public string alphaborderColorSelected { get; set; }
        public string alphabordercolor { get; set; }
        public string alphaiconcolor { get; set; }
        public string alphaiconcolorSelected { get; set; }
        public string alphaseparatorColor { get; set; }
        public string bg { get; set; }
        public string bgDrop { get; set; }
        public string bgOpen { get; set; }
        public string borderColorSelected { get; set; }
        public string borderWidthSelected { get; set; }
        public string bordercolor { get; set; }
        public string borderwidth { get; set; }
        public string fnt { get; set; }
        public string iconcolor { get; set; }
        public string iconcolorSelected { get; set; }
        public string linewidth { get; set; }
        public string rd { get; set; }
        public string separatorColor { get; set; }
        public string separatorHeight { get; set; }
        public string separatorWidthFull { get; set; }
        public string strokewidth { get; set; }
        public string textAlignment { get; set; }
        public string txt { get; set; }
        public string txts { get; set; }
    }

    public class StyleJ58c1was
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata305 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style120 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata305
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style120
    {
        public Groups113 groups { get; set; }
        public Properties119 properties { get; set; }
        public Propertiessource112 propertiesSource { get; set; }
    }

    public class Groups113
    {
    }

    public class Properties119
    {
        public string alphatxt { get; set; }
        public string alphatxth { get; set; }
        public string fnt { get; set; }
        public string txt { get; set; }
        public string txth { get; set; }
    }

    public class Propertiessource112
    {
        public string fnt { get; set; }
        public string txt { get; set; }
        public string txth { get; set; }
    }

    public class StyleJ7zzukiu
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata306 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style121 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata306
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style121
    {
        public Groups114 groups { get; set; }
        public Properties120 properties { get; set; }
        public Propertiessource113 propertiesSource { get; set; }
    }

    public class Groups114
    {
    }

    public class Properties120
    {
    }

    public class Propertiessource113
    {
    }

    public class StyleJ7zzukja
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata307 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style122 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata307
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style122
    {
        public Groups115 groups { get; set; }
        public Properties121 properties { get; set; }
        public Propertiessource114 propertiesSource { get; set; }
    }

    public class Groups115
    {
    }

    public class Properties121
    {
    }

    public class Propertiessource114
    {
    }

    public class StyleJc6cw4sv
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata308 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style123 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata308
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style123
    {
        public Groups116 groups { get; set; }
        public Properties122 properties { get; set; }
        public Propertiessource115 propertiesSource { get; set; }
    }

    public class Groups116
    {
    }

    public class Properties122
    {
        public string alphaparam_color_plusColorOpacity { get; set; }
        public string alphaparam_color_showMoreBackgroundCollage { get; set; }
        public string alphaparam_color_showMoreBackgroundGrid { get; set; }
        public string alphaparam_color_showMoreColorCollage { get; set; }
        public string alphaparam_color_showMoreColorGrid { get; set; }
        public string param_boolean_showMoreCollage { get; set; }
        public string param_boolean_showMoreGrid { get; set; }
        public string param_color_plusColorOpacity { get; set; }
        public string param_color_showMoreBackgroundCollage { get; set; }
        public string param_color_showMoreBackgroundGrid { get; set; }
        public string param_color_showMoreColorCollage { get; set; }
        public string param_color_showMoreColorGrid { get; set; }
        public string param_font_instaExpandFont { get; set; }
        public string param_font_showMoreFontCollage { get; set; }
        public string param_font_showMoreFontGrid { get; set; }
        public string param_number_mobileLayoutType { get; set; }
        public string param_number_showMoreBorderGrid { get; set; }
    }

    public class Propertiessource115
    {
        public string param_boolean_showMoreCollage { get; set; }
        public string param_boolean_showMoreGrid { get; set; }
        public string param_color_plusColorOpacity { get; set; }
        public string param_color_showMoreBackgroundCollage { get; set; }
        public string param_color_showMoreBackgroundGrid { get; set; }
        public string param_color_showMoreColorCollage { get; set; }
        public string param_color_showMoreColorGrid { get; set; }
        public string param_font_instaExpandFont { get; set; }
        public string param_font_showMoreFontCollage { get; set; }
        public string param_font_showMoreFontGrid { get; set; }
        public string param_number_mobileLayoutType { get; set; }
        public string param_number_showMoreBorderGrid { get; set; }
    }

    public class StyleJeio7caz
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata309 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style124 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata309
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style124
    {
        public Groups117 groups { get; set; }
        public Properties123 properties { get; set; }
        public Propertiessource116 propertiesSource { get; set; }
    }

    public class Groups117
    {
    }

    public class Properties123
    {
        public string alphabgDrop { get; set; }
        public string alphatxt { get; set; }
        public string alphatxth { get; set; }
        public string alphatxts { get; set; }
        public string bgDrop { get; set; }
        public string boxShadowToggleOnshd { get; set; }
        public string fnt { get; set; }
        public string pad { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
        public string txt { get; set; }
        public string txth { get; set; }
        public string txts { get; set; }
    }

    public class Propertiessource116
    {
        public string bgDrop { get; set; }
        public string fnt { get; set; }
        public string pad { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
        public string txt { get; set; }
        public string txth { get; set; }
        public string txts { get; set; }
    }

    public class StyleJg4v6ttc
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata310 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style125 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata310
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style125
    {
        public Groups118 groups { get; set; }
        public Properties124 properties { get; set; }
        public Propertiessource117 propertiesSource { get; set; }
    }

    public class Groups118
    {
    }

    public class Properties124
    {
    }

    public class Propertiessource117
    {
    }

    public class StyleJg4v6tu0
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata311 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style126 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata311
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style126
    {
        public Groups119 groups { get; set; }
        public Properties125 properties { get; set; }
        public Propertiessource118 propertiesSource { get; set; }
    }

    public class Groups119
    {
    }

    public class Properties125
    {
    }

    public class Propertiessource118
    {
    }

    public class StyleJg4v6tut
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata312 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style127 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata312
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style127
    {
        public Groups120 groups { get; set; }
        public Properties126 properties { get; set; }
        public Propertiessource119 propertiesSource { get; set; }
    }

    public class Groups120
    {
    }

    public class Properties126
    {
    }

    public class Propertiessource119
    {
    }

    public class StyleJg5at6c6
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata313 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style128 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata313
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style128
    {
        public Groups121 groups { get; set; }
        public Properties127 properties { get; set; }
        public Propertiessource120 propertiesSource { get; set; }
    }

    public class Groups121
    {
    }

    public class Properties127
    {
    }

    public class Propertiessource120
    {
    }

    public class StyleJg5at6ch2
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata314 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style129 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata314
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style129
    {
        public Groups122 groups { get; set; }
        public Properties128 properties { get; set; }
        public Propertiessource121 propertiesSource { get; set; }
    }

    public class Groups122
    {
    }

    public class Properties128
    {
    }

    public class Propertiessource121
    {
    }

    public class StyleJg5at6cy1
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata315 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style130 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata315
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style130
    {
        public Groups123 groups { get; set; }
        public Properties129 properties { get; set; }
        public Propertiessource122 propertiesSource { get; set; }
    }

    public class Groups123
    {
    }

    public class Properties129
    {
    }

    public class Propertiessource122
    {
    }

    public class StyleJg5b58zb
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata316 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style131 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata316
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style131
    {
        public Groups124 groups { get; set; }
        public Properties130 properties { get; set; }
        public Propertiessource123 propertiesSource { get; set; }
    }

    public class Groups124
    {
    }

    public class Properties130
    {
        public string alphabg { get; set; }
        public string alphabrd { get; set; }
        public string bg { get; set; }
        public string boxShadowToggleOnshd { get; set; }
        public string brd { get; set; }
        public string brw { get; set; }
        public string fntds { get; set; }
        public string fntt { get; set; }
        public string rd { get; set; }
        public string s { get; set; }
        public string s2 { get; set; }
        public string shd { get; set; }
        public string txt { get; set; }
    }

    public class Propertiessource123
    {
        public string alphabg { get; set; }
        public string alphabrd { get; set; }
        public string bg { get; set; }
        public string boxShadowToggleOnshd { get; set; }
        public string brd { get; set; }
        public string brw { get; set; }
        public string fntds { get; set; }
        public string fntt { get; set; }
        public string rd { get; set; }
        public string s { get; set; }
        public string s2 { get; set; }
        public string shd { get; set; }
        public string txt { get; set; }
    }

    public class StyleJg6c64nn
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata317 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style132 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata317
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style132
    {
        public Groups125 groups { get; set; }
        public Properties131 properties { get; set; }
        public Propertiessource124 propertiesSource { get; set; }
    }

    public class Groups125
    {
    }

    public class Properties131
    {
        public string alphabg { get; set; }
        public string alphabgh { get; set; }
        public string alphabrd { get; set; }
        public string alphabrdh { get; set; }
        public string alphatxt { get; set; }
        public string alphatxth { get; set; }
        public string bg { get; set; }
        public string bgh { get; set; }
        public string boxShadowToggleOnshd { get; set; }
        public string brd { get; set; }
        public string brdh { get; set; }
        public string brw { get; set; }
        public string fnt { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
        public string txt { get; set; }
        public string txth { get; set; }
    }

    public class Propertiessource124
    {
        public string alphabrdh { get; set; }
        public string bg { get; set; }
        public string bgh { get; set; }
        public string brd { get; set; }
        public string brdh { get; set; }
        public string brw { get; set; }
        public string fnt { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
        public string txt { get; set; }
        public string txth { get; set; }
    }

    public class StyleJg6c64o41
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata318 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style133 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata318
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style133
    {
        public Groups126 groups { get; set; }
        public Properties132 properties { get; set; }
        public Propertiessource125 propertiesSource { get; set; }
    }

    public class Groups126
    {
    }

    public class Properties132
    {
        public string alphabg { get; set; }
        public string alphabgh { get; set; }
        public string alphabrd { get; set; }
        public string alphabrdh { get; set; }
        public string alphatxt { get; set; }
        public string alphatxth { get; set; }
        public string bg { get; set; }
        public string bgh { get; set; }
        public string boxShadowToggleOnshd { get; set; }
        public string brd { get; set; }
        public string brdh { get; set; }
        public string brw { get; set; }
        public string fnt { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
        public string txt { get; set; }
        public string txth { get; set; }
    }

    public class Propertiessource125
    {
        public string alphabrdh { get; set; }
        public string bg { get; set; }
        public string bgh { get; set; }
        public string brd { get; set; }
        public string brdh { get; set; }
        public string brw { get; set; }
        public string fnt { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
        public string txt { get; set; }
        public string txth { get; set; }
    }

    public class StyleJgc98b01
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata319 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style134 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata319
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style134
    {
        public Groups127 groups { get; set; }
        public Properties133 properties { get; set; }
        public Propertiessource126 propertiesSource { get; set; }
    }

    public class Groups127
    {
    }

    public class Properties133
    {
        public string alphabg { get; set; }
        public string bg { get; set; }
    }

    public class Propertiessource126
    {
        public string alphabg { get; set; }
        public string bg { get; set; }
    }

    public class StyleJgdxpwm9
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata320 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style135 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata320
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style135
    {
        public Groups128 groups { get; set; }
        public Properties134 properties { get; set; }
        public Propertiessource127 propertiesSource { get; set; }
    }

    public class Groups128
    {
    }

    public class Properties134
    {
    }

    public class Propertiessource127
    {
    }

    public class StyleJhw1scy2
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata321 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style136 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata321
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style136
    {
        public Groups129 groups { get; set; }
        public Properties135 properties { get; set; }
        public Propertiessource128 propertiesSource { get; set; }
    }

    public class Groups129
    {
    }

    public class Properties135
    {
    }

    public class Propertiessource128
    {
    }

    public class StyleJhw1sczs
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata322 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style137 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata322
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style137
    {
        public Groups130 groups { get; set; }
        public Properties136 properties { get; set; }
        public Propertiessource129 propertiesSource { get; set; }
    }

    public class Groups130
    {
    }

    public class Properties136
    {
        public string disabledcolor { get; set; }
        public string maincolor { get; set; }
        public string textcolor { get; set; }
    }

    public class Propertiessource129
    {
    }

    public class StyleJipr3rtq
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata323 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style138 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata323
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style138
    {
        public Groups131 groups { get; set; }
        public Properties137 properties { get; set; }
        public Propertiessource130 propertiesSource { get; set; }
    }

    public class Groups131
    {
    }

    public class Properties137
    {
        public string alphabg { get; set; }
        public string alphabgh { get; set; }
        public string alphabrd { get; set; }
        public string alphabrdh { get; set; }
        public string alphatxt { get; set; }
        public string alphatxth { get; set; }
        public string bg { get; set; }
        public string bgh { get; set; }
        public string boxShadowToggleOnshd { get; set; }
        public string brd { get; set; }
        public string brdh { get; set; }
        public string brw { get; set; }
        public string fnt { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
        public string txt { get; set; }
        public string txth { get; set; }
    }

    public class Propertiessource130
    {
        public string alphabrdh { get; set; }
        public string bg { get; set; }
        public string bgh { get; set; }
        public string brd { get; set; }
        public string brdh { get; set; }
        public string brw { get; set; }
        public string fnt { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
        public string txt { get; set; }
        public string txth { get; set; }
    }

    public class StyleJipr7q42
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata324 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style139 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata324
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style139
    {
        public Groups132 groups { get; set; }
        public Properties138 properties { get; set; }
        public Propertiessource131 propertiesSource { get; set; }
    }

    public class Groups132
    {
    }

    public class Properties138
    {
        public string alphabg { get; set; }
        public string alphabgh { get; set; }
        public string alphabrd { get; set; }
        public string alphabrdh { get; set; }
        public string alphatxt { get; set; }
        public string alphatxth { get; set; }
        public string bg { get; set; }
        public string bgh { get; set; }
        public string boxShadowToggleOnshd { get; set; }
        public string brd { get; set; }
        public string brdh { get; set; }
        public string brw { get; set; }
        public string fnt { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
        public string txt { get; set; }
        public string txth { get; set; }
    }

    public class Propertiessource131
    {
        public string alphabrdh { get; set; }
        public string bg { get; set; }
        public string bgh { get; set; }
        public string brd { get; set; }
        public string brdh { get; set; }
        public string brw { get; set; }
        public string fnt { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
        public string txt { get; set; }
        public string txth { get; set; }
    }

    public class StyleJiprcuqa
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata325 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style140 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata325
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style140
    {
        public Groups133 groups { get; set; }
        public Properties139 properties { get; set; }
        public Propertiessource132 propertiesSource { get; set; }
    }

    public class Groups133
    {
    }

    public class Properties139
    {
        public string alphabg { get; set; }
        public string alphabgd { get; set; }
        public string alphabgh { get; set; }
        public string alphabrd { get; set; }
        public string alphabrdd { get; set; }
        public string alphabrdh { get; set; }
        public string bg { get; set; }
        public string bgd { get; set; }
        public string bgh { get; set; }
        public string boxShadowToggleOnshd { get; set; }
        public string brd { get; set; }
        public string brdd { get; set; }
        public string brdh { get; set; }
        public string brw { get; set; }
        public string fnt { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
        public string txt { get; set; }
        public string txtd { get; set; }
        public string txth { get; set; }
    }

    public class Propertiessource132
    {
        public string alphabg { get; set; }
        public string alphabgd { get; set; }
        public string alphabgh { get; set; }
        public string alphabrd { get; set; }
        public string alphabrdd { get; set; }
        public string alphabrdh { get; set; }
        public string bg { get; set; }
        public string bgd { get; set; }
        public string bgh { get; set; }
        public string boxShadowToggleOnshd { get; set; }
        public string brd { get; set; }
        public string brdd { get; set; }
        public string brdh { get; set; }
        public string brw { get; set; }
        public string fnt { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
        public string txt { get; set; }
        public string txtd { get; set; }
        public string txth { get; set; }
    }

    public class StyleJiprgwpy
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata326 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style141 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata326
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style141
    {
        public Groups134 groups { get; set; }
        public Properties140 properties { get; set; }
        public Propertiessource133 propertiesSource { get; set; }
    }

    public class Groups134
    {
    }

    public class Properties140
    {
        public string alphatxt { get; set; }
        public string alphatxth { get; set; }
        public string fnt { get; set; }
        public string txt { get; set; }
        public string txth { get; set; }
    }

    public class Propertiessource133
    {
        public string fnt { get; set; }
        public string txt { get; set; }
        public string txth { get; set; }
    }

    public class StyleJiprhozx
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata327 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style142 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata327
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style142
    {
        public Groups135 groups { get; set; }
        public Properties141 properties { get; set; }
        public Propertiessource134 propertiesSource { get; set; }
    }

    public class Groups135
    {
    }

    public class Properties141
    {
        public string alphabg { get; set; }
        public string alphabgd { get; set; }
        public string alphabgh { get; set; }
        public string alphabrd { get; set; }
        public string alphabrdd { get; set; }
        public string alphabrdh { get; set; }
        public string bg { get; set; }
        public string bgd { get; set; }
        public string bgh { get; set; }
        public string boxShadowToggleOnshd { get; set; }
        public string brd { get; set; }
        public string brdd { get; set; }
        public string brdh { get; set; }
        public string brw { get; set; }
        public string fnt { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
        public string txt { get; set; }
        public string txtd { get; set; }
        public string txth { get; set; }
    }

    public class Propertiessource134
    {
        public string alphabg { get; set; }
        public string alphabgd { get; set; }
        public string alphabgh { get; set; }
        public string alphabrd { get; set; }
        public string alphabrdd { get; set; }
        public string alphabrdh { get; set; }
        public string bg { get; set; }
        public string bgd { get; set; }
        public string bgh { get; set; }
        public string boxShadowToggleOnshd { get; set; }
        public string brd { get; set; }
        public string brdd { get; set; }
        public string brdh { get; set; }
        public string brw { get; set; }
        public string fnt { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
        public string txt { get; set; }
        public string txtd { get; set; }
        public string txth { get; set; }
    }

    public class StyleJiprieh4
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata328 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style143 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata328
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style143
    {
        public Groups136 groups { get; set; }
        public Properties142 properties { get; set; }
        public Propertiessource135 propertiesSource { get; set; }
    }

    public class Groups136
    {
    }

    public class Properties142
    {
        public string alphabg { get; set; }
        public string alphabgd { get; set; }
        public string alphabgh { get; set; }
        public string alphabrd { get; set; }
        public string alphabrdd { get; set; }
        public string alphabrdh { get; set; }
        public string bg { get; set; }
        public string bgd { get; set; }
        public string bgh { get; set; }
        public string boxShadowToggleOnshd { get; set; }
        public string brd { get; set; }
        public string brdd { get; set; }
        public string brdh { get; set; }
        public string brw { get; set; }
        public string fnt { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
        public string txt { get; set; }
        public string txtd { get; set; }
        public string txth { get; set; }
    }

    public class Propertiessource135
    {
        public string alphabg { get; set; }
        public string alphabgd { get; set; }
        public string alphabgh { get; set; }
        public string alphabrd { get; set; }
        public string alphabrdd { get; set; }
        public string alphabrdh { get; set; }
        public string bg { get; set; }
        public string bgd { get; set; }
        public string bgh { get; set; }
        public string boxShadowToggleOnshd { get; set; }
        public string brd { get; set; }
        public string brdd { get; set; }
        public string brdh { get; set; }
        public string brw { get; set; }
        public string fnt { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
        public string txt { get; set; }
        public string txtd { get; set; }
        public string txth { get; set; }
    }

    public class StyleJipyfhx4
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata329 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style144 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata329
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style144
    {
        public Groups137 groups { get; set; }
        public Properties143 properties { get; set; }
        public Propertiessource136 propertiesSource { get; set; }
    }

    public class Groups137
    {
    }

    public class Properties143
    {
        public string alphabg { get; set; }
        public string alphabrd { get; set; }
        public string bg { get; set; }
        public string boxShadowToggleOnshd { get; set; }
        public string brd { get; set; }
        public string brw { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
    }

    public class Propertiessource136
    {
        public string alphabg { get; set; }
        public string bg { get; set; }
        public string brd { get; set; }
        public string brw { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
    }

    public class StyleJipykjdr
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata330 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style145 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata330
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style145
    {
        public Groups138 groups { get; set; }
        public Properties144 properties { get; set; }
        public Propertiessource137 propertiesSource { get; set; }
    }

    public class Groups138
    {
    }

    public class Properties144
    {
        public string alphabg { get; set; }
        public string alphabrd { get; set; }
        public string bg { get; set; }
        public string boxShadowToggleOnshd { get; set; }
        public string brd { get; set; }
        public string brw { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
    }

    public class Propertiessource137
    {
        public string alphabg { get; set; }
        public string bg { get; set; }
        public string brd { get; set; }
        public string brw { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
    }

    public class StyleJipyl2wh
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata331 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style146 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata331
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style146
    {
        public Groups139 groups { get; set; }
        public Properties145 properties { get; set; }
        public Propertiessource138 propertiesSource { get; set; }
    }

    public class Groups139
    {
    }

    public class Properties145
    {
        public string alphabg { get; set; }
        public string alphabrd { get; set; }
        public string bg { get; set; }
        public string boxShadowToggleOnshd { get; set; }
        public string brd { get; set; }
        public string brw { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
    }

    public class Propertiessource138
    {
        public string alphabg { get; set; }
        public string bg { get; set; }
        public string brd { get; set; }
        public string brw { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
    }

    public class StyleJipym60f
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata332 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style147 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata332
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style147
    {
        public Groups140 groups { get; set; }
        public Properties146 properties { get; set; }
        public Propertiessource139 propertiesSource { get; set; }
    }

    public class Groups140
    {
    }

    public class Properties146
    {
        public string alphabg { get; set; }
        public string alphabrd { get; set; }
        public string bg { get; set; }
        public string boxShadowToggleOnshd { get; set; }
        public string brd { get; set; }
        public string brw { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
    }

    public class Propertiessource139
    {
        public string alphabg { get; set; }
        public string bg { get; set; }
        public string brd { get; set; }
        public string brw { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
    }

    public class StyleJipymtgv
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata333 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style148 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata333
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style148
    {
        public Groups141 groups { get; set; }
        public Properties147 properties { get; set; }
        public Propertiessource140 propertiesSource { get; set; }
    }

    public class Groups141
    {
    }

    public class Properties147
    {
        public string alphabg { get; set; }
        public string alphabrd { get; set; }
        public string bg { get; set; }
        public string boxShadowToggleOnshd { get; set; }
        public string brd { get; set; }
        public string brw { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
    }

    public class Propertiessource140
    {
        public string alphabg { get; set; }
        public string bg { get; set; }
        public string brd { get; set; }
        public string brw { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
    }

    public class StyleJiq4yttd
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata334 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style149 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata334
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style149
    {
        public Groups142 groups { get; set; }
        public Properties148 properties { get; set; }
        public Propertiessource141 propertiesSource { get; set; }
    }

    public class Groups142
    {
    }

    public class Properties148
    {
    }

    public class Propertiessource141
    {
    }

    public class StyleJj73u5qa
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata335 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style150 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata335
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style150
    {
        public Groups143 groups { get; set; }
        public Properties149 properties { get; set; }
        public Propertiessource142 propertiesSource { get; set; }
    }

    public class Groups143
    {
    }

    public class Properties149
    {
        public string alphatxt { get; set; }
        public string alphatxth { get; set; }
        public string fnt { get; set; }
        public string txt { get; set; }
        public string txth { get; set; }
    }

    public class Propertiessource142
    {
        public string fnt { get; set; }
        public string txt { get; set; }
        public string txth { get; set; }
    }

    public class StyleJj73uz81
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata336 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style151 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata336
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style151
    {
        public Groups144 groups { get; set; }
        public Properties150 properties { get; set; }
        public Propertiessource143 propertiesSource { get; set; }
    }

    public class Groups144
    {
    }

    public class Properties150
    {
        public string alphabg { get; set; }
        public string alphabgh { get; set; }
        public string alphabrd { get; set; }
        public string alphabrdh { get; set; }
        public string alphatxt { get; set; }
        public string alphatxth { get; set; }
        public string bg { get; set; }
        public string bgh { get; set; }
        public string boxShadowToggleOnshd { get; set; }
        public string brd { get; set; }
        public string brdh { get; set; }
        public string brw { get; set; }
        public string fnt { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
        public string txt { get; set; }
        public string txth { get; set; }
    }

    public class Propertiessource143
    {
        public string alphabrdh { get; set; }
        public string bg { get; set; }
        public string bgh { get; set; }
        public string brd { get; set; }
        public string brdh { get; set; }
        public string brw { get; set; }
        public string fnt { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
        public string txt { get; set; }
        public string txth { get; set; }
    }

    public class StyleJj8keiww1
    {
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata337 metaData { get; set; }
        public string skin { get; set; }
        public Style152 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata337
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style152
    {
        public Groups145 groups { get; set; }
        public Properties151 properties { get; set; }
        public Propertiessource144 propertiesSource { get; set; }
    }

    public class Groups145
    {
    }

    public class Properties151
    {
        public string alphabg { get; set; }
        public string alphabgh { get; set; }
        public string alphabrd { get; set; }
        public string alphabrdh { get; set; }
        public string alphatxt { get; set; }
        public string alphatxth { get; set; }
        public string bg { get; set; }
        public string bgh { get; set; }
        public string boxShadowToggleOnshd { get; set; }
        public string brd { get; set; }
        public string brdh { get; set; }
        public string brw { get; set; }
        public string fnt { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
        public string txt { get; set; }
        public string txth { get; set; }
    }

    public class Propertiessource144
    {
        public string bg { get; set; }
        public string bgh { get; set; }
        public string brd { get; set; }
        public string brdh { get; set; }
        public string brw { get; set; }
        public string fnt { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
        public string txt { get; set; }
        public string txth { get; set; }
    }

    public class StyleJj8keixc
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata338 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style153 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata338
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style153
    {
        public Groups146 groups { get; set; }
        public Properties152 properties { get; set; }
        public Propertiessource145 propertiesSource { get; set; }
    }

    public class Groups146
    {
    }

    public class Properties152
    {
        public string alphabg { get; set; }
        public string alphabrd { get; set; }
        public string bg { get; set; }
        public string boxShadowToggleOnshd { get; set; }
        public string brd { get; set; }
        public string brw { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
    }

    public class Propertiessource145
    {
        public string alphabg { get; set; }
        public string alphabrd { get; set; }
        public string bg { get; set; }
        public string brd { get; set; }
        public string brw { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
    }

    public class StyleJj8keixm
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata339 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style154 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata339
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style154
    {
        public Groups147 groups { get; set; }
        public Properties153 properties { get; set; }
        public Propertiessource146 propertiesSource { get; set; }
    }

    public class Groups147
    {
    }

    public class Properties153
    {
    }

    public class Propertiessource146
    {
    }

    public class StyleJj8keiyq1
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata340 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style155 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata340
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style155
    {
        public Groups148 groups { get; set; }
        public Properties154 properties { get; set; }
        public Propertiessource147 propertiesSource { get; set; }
    }

    public class Groups148
    {
    }

    public class Properties154
    {
        public string alphabg { get; set; }
        public string alphabgh { get; set; }
        public string alphabrd { get; set; }
        public string alphabrdh { get; set; }
        public string alphatxt { get; set; }
        public string alphatxth { get; set; }
        public string bg { get; set; }
        public string bgh { get; set; }
        public string boxShadowToggleOnshd { get; set; }
        public string brd { get; set; }
        public string brdh { get; set; }
        public string brw { get; set; }
        public string fnt { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
        public string txt { get; set; }
        public string txth { get; set; }
    }

    public class Propertiessource147
    {
        public string alphabrdh { get; set; }
        public string bg { get; set; }
        public string bgh { get; set; }
        public string brd { get; set; }
        public string brdh { get; set; }
        public string brw { get; set; }
        public string fnt { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
        public string txt { get; set; }
        public string txth { get; set; }
    }

    public class StyleJj8kej1q
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata341 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style156 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata341
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style156
    {
        public Groups149 groups { get; set; }
        public Properties155 properties { get; set; }
        public Propertiessource148 propertiesSource { get; set; }
    }

    public class Groups149
    {
    }

    public class Properties155
    {
        public string alphabg { get; set; }
        public string alphabgh { get; set; }
        public string alphabrd { get; set; }
        public string alphabrdh { get; set; }
        public string alphatxt { get; set; }
        public string alphatxth { get; set; }
        public string bg { get; set; }
        public string bgh { get; set; }
        public string boxShadowToggleOnshd { get; set; }
        public string brd { get; set; }
        public string brdh { get; set; }
        public string brw { get; set; }
        public string fnt { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
        public string txt { get; set; }
        public string txth { get; set; }
    }

    public class Propertiessource148
    {
        public string alphabrdh { get; set; }
        public string bg { get; set; }
        public string bgh { get; set; }
        public string brd { get; set; }
        public string brdh { get; set; }
        public string brw { get; set; }
        public string fnt { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
        public string txt { get; set; }
        public string txth { get; set; }
    }

    public class StyleJj8l62mh1
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata342 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style157 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata342
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style157
    {
        public Groups150 groups { get; set; }
        public Properties156 properties { get; set; }
        public Propertiessource149 propertiesSource { get; set; }
    }

    public class Groups150
    {
    }

    public class Properties156
    {
        public string alphabg { get; set; }
        public string alphabrd { get; set; }
        public string bg { get; set; }
        public string boxShadowToggleOnshd { get; set; }
        public string brd { get; set; }
        public string brw { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
    }

    public class Propertiessource149
    {
        public string alphabg { get; set; }
        public string alphabrd { get; set; }
        public string bg { get; set; }
        public string brd { get; set; }
        public string brw { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
    }

    public class StyleJj8l62ng1
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata343 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style158 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata343
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style158
    {
        public Groups151 groups { get; set; }
        public Properties157 properties { get; set; }
        public Propertiessource150 propertiesSource { get; set; }
    }

    public class Groups151
    {
    }

    public class Properties157
    {
    }

    public class Propertiessource150
    {
    }

    public class StyleJj8mg29s1
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata344 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style159 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata344
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style159
    {
        public Groups152 groups { get; set; }
        public Properties158 properties { get; set; }
        public Propertiessource151 propertiesSource { get; set; }
    }

    public class Groups152
    {
    }

    public class Properties158
    {
        public string alphabg { get; set; }
        public string alphabgh { get; set; }
        public string alphabrd { get; set; }
        public string alphabrdh { get; set; }
        public string alphatxt { get; set; }
        public string alphatxth { get; set; }
        public string bg { get; set; }
        public string bgh { get; set; }
        public string boxShadowToggleOnshd { get; set; }
        public string brd { get; set; }
        public string brdh { get; set; }
        public string brw { get; set; }
        public string fnt { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
        public string txt { get; set; }
        public string txth { get; set; }
    }

    public class Propertiessource151
    {
        public string alphabrdh { get; set; }
        public string bg { get; set; }
        public string bgh { get; set; }
        public string brd { get; set; }
        public string brdh { get; set; }
        public string brw { get; set; }
        public string fnt { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
        public string txt { get; set; }
        public string txth { get; set; }
    }

    public class StyleJj8mhvlk1
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata345 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style160 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata345
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style160
    {
        public Groups153 groups { get; set; }
        public Properties159 properties { get; set; }
        public Propertiessource152 propertiesSource { get; set; }
    }

    public class Groups153
    {
    }

    public class Properties159
    {
        public string alphabg { get; set; }
        public string alphabrd { get; set; }
        public string bg { get; set; }
        public string boxShadowToggleOnshd { get; set; }
        public string brd { get; set; }
        public string brw { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
    }

    public class Propertiessource152
    {
        public string alphabg { get; set; }
        public string alphabrd { get; set; }
        public string bg { get; set; }
        public string brd { get; set; }
        public string brw { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
    }

    public class StyleJj8mhvmr2
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata346 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style161 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata346
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style161
    {
        public Groups154 groups { get; set; }
        public Properties160 properties { get; set; }
        public Propertiessource153 propertiesSource { get; set; }
    }

    public class Groups154
    {
    }

    public class Properties160
    {
    }

    public class Propertiessource153
    {
    }

    public class StyleJj8mhvpw
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata347 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style162 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata347
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style162
    {
        public Groups155 groups { get; set; }
        public Properties161 properties { get; set; }
        public Propertiessource154 propertiesSource { get; set; }
    }

    public class Groups155
    {
    }

    public class Properties161
    {
        public string alphabg { get; set; }
        public string alphabgh { get; set; }
        public string alphabrd { get; set; }
        public string alphabrdh { get; set; }
        public string alphatxt { get; set; }
        public string alphatxth { get; set; }
        public string bg { get; set; }
        public string bgh { get; set; }
        public string boxShadowToggleOnshd { get; set; }
        public string brd { get; set; }
        public string brdh { get; set; }
        public string brw { get; set; }
        public string fnt { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
        public string txt { get; set; }
        public string txth { get; set; }
    }

    public class Propertiessource154
    {
        public string alphabrdh { get; set; }
        public string bg { get; set; }
        public string bgh { get; set; }
        public string brd { get; set; }
        public string brdh { get; set; }
        public string brw { get; set; }
        public string fnt { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
        public string txt { get; set; }
        public string txth { get; set; }
    }

    public class StyleJj8r27vw
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata348 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style163 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata348
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style163
    {
        public Groups156 groups { get; set; }
        public Properties162 properties { get; set; }
        public Propertiessource155 propertiesSource { get; set; }
    }

    public class Groups156
    {
    }

    public class Properties162
    {
    }

    public class Propertiessource155
    {
    }

    public class StyleJja16l4y1
    {
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata349 metaData { get; set; }
        public string skin { get; set; }
        public Style164 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata349
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style164
    {
        public Groups157 groups { get; set; }
        public Properties163 properties { get; set; }
        public Propertiessource156 propertiesSource { get; set; }
    }

    public class Groups157
    {
    }

    public class Properties163
    {
        public string alphabg { get; set; }
        public string alphabgh { get; set; }
        public string alphabrd { get; set; }
        public string alphabrdh { get; set; }
        public string alphatxt { get; set; }
        public string alphatxth { get; set; }
        public string bg { get; set; }
        public string bgh { get; set; }
        public string boxShadowToggleOnshd { get; set; }
        public string brd { get; set; }
        public string brdh { get; set; }
        public string brw { get; set; }
        public string fnt { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
        public string txt { get; set; }
        public string txth { get; set; }
    }

    public class Propertiessource156
    {
        public string bg { get; set; }
        public string bgh { get; set; }
        public string brd { get; set; }
        public string brdh { get; set; }
        public string brw { get; set; }
        public string fnt { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
        public string txt { get; set; }
        public string txth { get; set; }
    }

    public class StyleJja16l5o1
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata350 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style165 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata350
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style165
    {
        public Groups158 groups { get; set; }
        public Properties164 properties { get; set; }
        public Propertiessource157 propertiesSource { get; set; }
    }

    public class Groups158
    {
    }

    public class Properties164
    {
        public string alphabg { get; set; }
        public string alphabrd { get; set; }
        public string bg { get; set; }
        public string boxShadowToggleOnshd { get; set; }
        public string brd { get; set; }
        public string brw { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
    }

    public class Propertiessource157
    {
        public string alphabg { get; set; }
        public string alphabrd { get; set; }
        public string bg { get; set; }
        public string brd { get; set; }
        public string brw { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
    }

    public class StyleJja16l5w1
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata351 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style166 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata351
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style166
    {
        public Groups159 groups { get; set; }
        public Properties165 properties { get; set; }
        public Propertiessource158 propertiesSource { get; set; }
    }

    public class Groups159
    {
    }

    public class Properties165
    {
    }

    public class Propertiessource158
    {
    }

    public class StyleJja16l6s1
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata352 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style167 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata352
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style167
    {
        public Groups160 groups { get; set; }
        public Properties166 properties { get; set; }
        public Propertiessource159 propertiesSource { get; set; }
    }

    public class Groups160
    {
    }

    public class Properties166
    {
        public string alphabg { get; set; }
        public string alphabgh { get; set; }
        public string alphabrd { get; set; }
        public string alphabrdh { get; set; }
        public string alphatxt { get; set; }
        public string alphatxth { get; set; }
        public string bg { get; set; }
        public string bgh { get; set; }
        public string boxShadowToggleOnshd { get; set; }
        public string brd { get; set; }
        public string brdh { get; set; }
        public string brw { get; set; }
        public string fnt { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
        public string txt { get; set; }
        public string txth { get; set; }
    }

    public class Propertiessource159
    {
        public string alphabrdh { get; set; }
        public string bg { get; set; }
        public string bgh { get; set; }
        public string brd { get; set; }
        public string brdh { get; set; }
        public string brw { get; set; }
        public string fnt { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
        public string txt { get; set; }
        public string txth { get; set; }
    }

    public class StyleJja16l8v
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata353 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style168 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata353
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style168
    {
        public Groups161 groups { get; set; }
        public Properties167 properties { get; set; }
        public Propertiessource160 propertiesSource { get; set; }
    }

    public class Groups161
    {
    }

    public class Properties167
    {
        public string alphabg { get; set; }
        public string alphabgh { get; set; }
        public string alphabrd { get; set; }
        public string alphabrdh { get; set; }
        public string alphatxt { get; set; }
        public string alphatxth { get; set; }
        public string bg { get; set; }
        public string bgh { get; set; }
        public string boxShadowToggleOnshd { get; set; }
        public string brd { get; set; }
        public string brdh { get; set; }
        public string brw { get; set; }
        public string fnt { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
        public string txt { get; set; }
        public string txth { get; set; }
    }

    public class Propertiessource160
    {
        public string alphabrdh { get; set; }
        public string bg { get; set; }
        public string bgh { get; set; }
        public string brd { get; set; }
        public string brdh { get; set; }
        public string brw { get; set; }
        public string fnt { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
        public string txt { get; set; }
        public string txth { get; set; }
    }

    public class StyleJja171f4
    {
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata354 metaData { get; set; }
        public string skin { get; set; }
        public Style169 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata354
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style169
    {
        public Groups162 groups { get; set; }
        public Properties168 properties { get; set; }
        public Propertiessource161 propertiesSource { get; set; }
    }

    public class Groups162
    {
    }

    public class Properties168
    {
        public string alphabg { get; set; }
        public string alphabgh { get; set; }
        public string alphabrd { get; set; }
        public string alphabrdh { get; set; }
        public string alphatxt { get; set; }
        public string alphatxth { get; set; }
        public string bg { get; set; }
        public string bgh { get; set; }
        public string boxShadowToggleOnshd { get; set; }
        public string brd { get; set; }
        public string brdh { get; set; }
        public string brw { get; set; }
        public string fnt { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
        public string txt { get; set; }
        public string txth { get; set; }
    }

    public class Propertiessource161
    {
        public string bg { get; set; }
        public string bgh { get; set; }
        public string brd { get; set; }
        public string brdh { get; set; }
        public string brw { get; set; }
        public string fnt { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
        public string txt { get; set; }
        public string txth { get; set; }
    }

    public class StyleJja171fo3
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata355 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style170 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata355
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style170
    {
        public Groups163 groups { get; set; }
        public Properties169 properties { get; set; }
        public Propertiessource162 propertiesSource { get; set; }
    }

    public class Groups163
    {
    }

    public class Properties169
    {
        public string alphabg { get; set; }
        public string alphabrd { get; set; }
        public string bg { get; set; }
        public string boxShadowToggleOnshd { get; set; }
        public string brd { get; set; }
        public string brw { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
    }

    public class Propertiessource162
    {
        public string alphabg { get; set; }
        public string alphabrd { get; set; }
        public string bg { get; set; }
        public string brd { get; set; }
        public string brw { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
    }

    public class StyleJja171fy
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata356 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style171 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata356
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style171
    {
        public Groups164 groups { get; set; }
        public Properties170 properties { get; set; }
        public Propertiessource163 propertiesSource { get; set; }
    }

    public class Groups164
    {
    }

    public class Properties170
    {
    }

    public class Propertiessource163
    {
    }

    public class StyleJja171gn1
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata357 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style172 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata357
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style172
    {
        public Groups165 groups { get; set; }
        public Properties171 properties { get; set; }
        public Propertiessource164 propertiesSource { get; set; }
    }

    public class Groups165
    {
    }

    public class Properties171
    {
        public string alphabg { get; set; }
        public string alphabgh { get; set; }
        public string alphabrd { get; set; }
        public string alphabrdh { get; set; }
        public string alphatxt { get; set; }
        public string alphatxth { get; set; }
        public string bg { get; set; }
        public string bgh { get; set; }
        public string boxShadowToggleOnshd { get; set; }
        public string brd { get; set; }
        public string brdh { get; set; }
        public string brw { get; set; }
        public string fnt { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
        public string txt { get; set; }
        public string txth { get; set; }
    }

    public class Propertiessource164
    {
        public string alphabrdh { get; set; }
        public string bg { get; set; }
        public string bgh { get; set; }
        public string brd { get; set; }
        public string brdh { get; set; }
        public string brw { get; set; }
        public string fnt { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
        public string txt { get; set; }
        public string txth { get; set; }
    }

    public class StyleJja171in
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata358 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style173 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata358
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style173
    {
        public Groups166 groups { get; set; }
        public Properties172 properties { get; set; }
        public Propertiessource165 propertiesSource { get; set; }
    }

    public class Groups166
    {
    }

    public class Properties172
    {
        public string alphabg { get; set; }
        public string alphabgh { get; set; }
        public string alphabrd { get; set; }
        public string alphabrdh { get; set; }
        public string alphatxt { get; set; }
        public string alphatxth { get; set; }
        public string bg { get; set; }
        public string bgh { get; set; }
        public string boxShadowToggleOnshd { get; set; }
        public string brd { get; set; }
        public string brdh { get; set; }
        public string brw { get; set; }
        public string fnt { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
        public string txt { get; set; }
        public string txth { get; set; }
    }

    public class Propertiessource165
    {
        public string alphabrdh { get; set; }
        public string bg { get; set; }
        public string bgh { get; set; }
        public string brd { get; set; }
        public string brdh { get; set; }
        public string brw { get; set; }
        public string fnt { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
        public string txt { get; set; }
        public string txth { get; set; }
    }

    public class StyleJja177ih
    {
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata359 metaData { get; set; }
        public string skin { get; set; }
        public Style174 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata359
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style174
    {
        public Groups167 groups { get; set; }
        public Properties173 properties { get; set; }
        public Propertiessource166 propertiesSource { get; set; }
    }

    public class Groups167
    {
    }

    public class Properties173
    {
        public string alphabg { get; set; }
        public string alphabgh { get; set; }
        public string alphabrd { get; set; }
        public string alphabrdh { get; set; }
        public string alphatxt { get; set; }
        public string alphatxth { get; set; }
        public string bg { get; set; }
        public string bgh { get; set; }
        public string boxShadowToggleOnshd { get; set; }
        public string brd { get; set; }
        public string brdh { get; set; }
        public string brw { get; set; }
        public string fnt { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
        public string txt { get; set; }
        public string txth { get; set; }
    }

    public class Propertiessource166
    {
        public string bg { get; set; }
        public string bgh { get; set; }
        public string brd { get; set; }
        public string brdh { get; set; }
        public string brw { get; set; }
        public string fnt { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
        public string txt { get; set; }
        public string txth { get; set; }
    }

    public class StyleJja177j0
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata360 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style175 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata360
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style175
    {
        public Groups168 groups { get; set; }
        public Properties174 properties { get; set; }
        public Propertiessource167 propertiesSource { get; set; }
    }

    public class Groups168
    {
    }

    public class Properties174
    {
        public string alphabg { get; set; }
        public string alphabrd { get; set; }
        public string bg { get; set; }
        public string boxShadowToggleOnshd { get; set; }
        public string brd { get; set; }
        public string brw { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
    }

    public class Propertiessource167
    {
        public string alphabg { get; set; }
        public string alphabrd { get; set; }
        public string bg { get; set; }
        public string brd { get; set; }
        public string brw { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
    }

    public class StyleJja177j82
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata361 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style176 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata361
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style176
    {
        public Groups169 groups { get; set; }
        public Properties175 properties { get; set; }
        public Propertiessource168 propertiesSource { get; set; }
    }

    public class Groups169
    {
    }

    public class Properties175
    {
    }

    public class Propertiessource168
    {
    }

    public class StyleJja177jw1
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata362 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style177 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata362
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style177
    {
        public Groups170 groups { get; set; }
        public Properties176 properties { get; set; }
        public Propertiessource169 propertiesSource { get; set; }
    }

    public class Groups170
    {
    }

    public class Properties176
    {
        public string alphabg { get; set; }
        public string alphabgh { get; set; }
        public string alphabrd { get; set; }
        public string alphabrdh { get; set; }
        public string alphatxt { get; set; }
        public string alphatxth { get; set; }
        public string bg { get; set; }
        public string bgh { get; set; }
        public string boxShadowToggleOnshd { get; set; }
        public string brd { get; set; }
        public string brdh { get; set; }
        public string brw { get; set; }
        public string fnt { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
        public string txt { get; set; }
        public string txth { get; set; }
    }

    public class Propertiessource169
    {
        public string alphabrdh { get; set; }
        public string bg { get; set; }
        public string bgh { get; set; }
        public string brd { get; set; }
        public string brdh { get; set; }
        public string brw { get; set; }
        public string fnt { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
        public string txt { get; set; }
        public string txth { get; set; }
    }

    public class StyleJja177ls1
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata363 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style178 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata363
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style178
    {
        public Groups171 groups { get; set; }
        public Properties177 properties { get; set; }
        public Propertiessource170 propertiesSource { get; set; }
    }

    public class Groups171
    {
    }

    public class Properties177
    {
        public string alphabg { get; set; }
        public string alphabgh { get; set; }
        public string alphabrd { get; set; }
        public string alphabrdh { get; set; }
        public string alphatxt { get; set; }
        public string alphatxth { get; set; }
        public string bg { get; set; }
        public string bgh { get; set; }
        public string boxShadowToggleOnshd { get; set; }
        public string brd { get; set; }
        public string brdh { get; set; }
        public string brw { get; set; }
        public string fnt { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
        public string txt { get; set; }
        public string txth { get; set; }
    }

    public class Propertiessource170
    {
        public string alphabrdh { get; set; }
        public string bg { get; set; }
        public string bgh { get; set; }
        public string brd { get; set; }
        public string brdh { get; set; }
        public string brw { get; set; }
        public string fnt { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
        public string txt { get; set; }
        public string txth { get; set; }
    }

    public class StyleJja17fr51
    {
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata364 metaData { get; set; }
        public string skin { get; set; }
        public Style179 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata364
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style179
    {
        public Groups172 groups { get; set; }
        public Properties178 properties { get; set; }
        public Propertiessource171 propertiesSource { get; set; }
    }

    public class Groups172
    {
    }

    public class Properties178
    {
        public string alphabg { get; set; }
        public string alphabgh { get; set; }
        public string alphabrd { get; set; }
        public string alphabrdh { get; set; }
        public string alphatxt { get; set; }
        public string alphatxth { get; set; }
        public string bg { get; set; }
        public string bgh { get; set; }
        public string boxShadowToggleOnshd { get; set; }
        public string brd { get; set; }
        public string brdh { get; set; }
        public string brw { get; set; }
        public string fnt { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
        public string txt { get; set; }
        public string txth { get; set; }
    }

    public class Propertiessource171
    {
        public string bg { get; set; }
        public string bgh { get; set; }
        public string brd { get; set; }
        public string brdh { get; set; }
        public string brw { get; set; }
        public string fnt { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
        public string txt { get; set; }
        public string txth { get; set; }
    }

    public class StyleJja17fro2
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata365 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style180 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata365
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style180
    {
        public Groups173 groups { get; set; }
        public Properties179 properties { get; set; }
        public Propertiessource172 propertiesSource { get; set; }
    }

    public class Groups173
    {
    }

    public class Properties179
    {
        public string alphabg { get; set; }
        public string alphabrd { get; set; }
        public string bg { get; set; }
        public string boxShadowToggleOnshd { get; set; }
        public string brd { get; set; }
        public string brw { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
    }

    public class Propertiessource172
    {
        public string alphabg { get; set; }
        public string alphabrd { get; set; }
        public string bg { get; set; }
        public string brd { get; set; }
        public string brw { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
    }

    public class StyleJja17frw
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata366 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style181 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata366
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style181
    {
        public Groups174 groups { get; set; }
        public Properties180 properties { get; set; }
        public Propertiessource173 propertiesSource { get; set; }
    }

    public class Groups174
    {
    }

    public class Properties180
    {
    }

    public class Propertiessource173
    {
    }

    public class StyleJja17fsn1
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata367 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style182 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata367
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style182
    {
        public Groups175 groups { get; set; }
        public Properties181 properties { get; set; }
        public Propertiessource174 propertiesSource { get; set; }
    }

    public class Groups175
    {
    }

    public class Properties181
    {
        public string alphabg { get; set; }
        public string alphabgh { get; set; }
        public string alphabrd { get; set; }
        public string alphabrdh { get; set; }
        public string alphatxt { get; set; }
        public string alphatxth { get; set; }
        public string bg { get; set; }
        public string bgh { get; set; }
        public string boxShadowToggleOnshd { get; set; }
        public string brd { get; set; }
        public string brdh { get; set; }
        public string brw { get; set; }
        public string fnt { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
        public string txt { get; set; }
        public string txth { get; set; }
    }

    public class Propertiessource174
    {
        public string alphabrdh { get; set; }
        public string bg { get; set; }
        public string bgh { get; set; }
        public string brd { get; set; }
        public string brdh { get; set; }
        public string brw { get; set; }
        public string fnt { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
        public string txt { get; set; }
        public string txth { get; set; }
    }

    public class StyleJja17fuf3
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata368 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style183 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata368
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style183
    {
        public Groups176 groups { get; set; }
        public Properties182 properties { get; set; }
        public Propertiessource175 propertiesSource { get; set; }
    }

    public class Groups176
    {
    }

    public class Properties182
    {
        public string alphabg { get; set; }
        public string alphabgh { get; set; }
        public string alphabrd { get; set; }
        public string alphabrdh { get; set; }
        public string alphatxt { get; set; }
        public string alphatxth { get; set; }
        public string bg { get; set; }
        public string bgh { get; set; }
        public string boxShadowToggleOnshd { get; set; }
        public string brd { get; set; }
        public string brdh { get; set; }
        public string brw { get; set; }
        public string fnt { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
        public string txt { get; set; }
        public string txth { get; set; }
    }

    public class Propertiessource175
    {
        public string alphabrdh { get; set; }
        public string bg { get; set; }
        public string bgh { get; set; }
        public string brd { get; set; }
        public string brdh { get; set; }
        public string brw { get; set; }
        public string fnt { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
        public string txt { get; set; }
        public string txth { get; set; }
    }

    public class StyleJjpt7t9m
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata369 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style184 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata369
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style184
    {
        public Groups177 groups { get; set; }
        public Properties183 properties { get; set; }
        public Propertiessource176 propertiesSource { get; set; }
    }

    public class Groups177
    {
    }

    public class Properties183
    {
        public string alphabg1 { get; set; }
        public string alphabg2 { get; set; }
        public string alphabrd { get; set; }
        public string alphalabelTxt { get; set; }
        public string alphatxt1 { get; set; }
        public string alphatxt2 { get; set; }
        public string alphatxtError { get; set; }
        public string alphatxtSuccess { get; set; }
        public string bg1 { get; set; }
        public string bg2 { get; set; }
        public string boxShadowToggleOnshd { get; set; }
        public string brd { get; set; }
        public string brw { get; set; }
        public string fnt { get; set; }
        public string fnt2 { get; set; }
        public string labelTxt { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
        public string txt1 { get; set; }
        public string txt2 { get; set; }
        public string txtError { get; set; }
        public string txtSuccess { get; set; }
    }

    public class Propertiessource176
    {
        public string alphabg1 { get; set; }
        public string alphabrd { get; set; }
        public string bg1 { get; set; }
        public string bg2 { get; set; }
        public string brd { get; set; }
        public string brw { get; set; }
        public string fnt { get; set; }
        public string fnt2 { get; set; }
        public string labelTxt { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
        public string txt1 { get; set; }
        public string txt2 { get; set; }
        public string txtError { get; set; }
        public string txtSuccess { get; set; }
    }

    public class StyleJjpt95x3
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata370 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style185 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata370
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style185
    {
        public Groups178 groups { get; set; }
        public Properties184 properties { get; set; }
        public Propertiessource177 propertiesSource { get; set; }
    }

    public class Groups178
    {
    }

    public class Properties184
    {
        public string alphabgDrop { get; set; }
        public string bgDrop { get; set; }
        public string boxShadowToggleOnshd { get; set; }
        public string fnt { get; set; }
        public string menuTotalBordersX { get; set; }
        public string menuTotalBordersY { get; set; }
        public string pad { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
        public string txt { get; set; }
        public string txth { get; set; }
        public string txts { get; set; }
    }

    public class Propertiessource177
    {
        public string alphabgDrop { get; set; }
        public string bgDrop { get; set; }
        public string boxShadowToggleOnshd { get; set; }
        public string fnt { get; set; }
        public string menuTotalBordersX { get; set; }
        public string menuTotalBordersY { get; set; }
        public string pad { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
        public string txt { get; set; }
        public string txth { get; set; }
        public string txts { get; set; }
    }

    public class StyleJmhiarvm
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata371 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style186 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata371
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style186
    {
        public Groups179 groups { get; set; }
        public Properties185 properties { get; set; }
        public Propertiessource178 propertiesSource { get; set; }
    }

    public class Groups179
    {
    }

    public class Properties185
    {
        public string alphabg { get; set; }
        public string alphabrd { get; set; }
        public string bg { get; set; }
        public string boxShadowToggleOnshd { get; set; }
        public string brd { get; set; }
        public string brw { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
    }

    public class Propertiessource178
    {
        public string alphabg { get; set; }
        public string bg { get; set; }
        public string brd { get; set; }
        public string brw { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
    }

    public class StyleJmhiblso
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata372 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style187 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata372
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style187
    {
        public Groups180 groups { get; set; }
        public Properties186 properties { get; set; }
        public Propertiessource179 propertiesSource { get; set; }
    }

    public class Groups180
    {
    }

    public class Properties186
    {
    }

    public class Propertiessource179
    {
    }

    public class Tf1
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata373 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style188 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata373
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style188
    {
        public Groups181 groups { get; set; }
        public Properties187 properties { get; set; }
        public Propertiessource180 propertiesSource { get; set; }
    }

    public class Groups181
    {
    }

    public class Properties187
    {
    }

    public class Propertiessource180
    {
    }

    public class Tm1
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata374 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style189 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata374
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style189
    {
        public Groups182 groups { get; set; }
        public Properties188 properties { get; set; }
        public Propertiessource181 propertiesSource { get; set; }
    }

    public class Groups182
    {
    }

    public class Properties188
    {
        public string alphabg { get; set; }
        public string alphabgDrop { get; set; }
        public string alphabgOpen { get; set; }
        public string alphaborderColorSelected { get; set; }
        public string alphabordercolor { get; set; }
        public string alphaiconcolor { get; set; }
        public string alphaiconcolorSelected { get; set; }
        public string alphaseparatorColor { get; set; }
        public string bg { get; set; }
        public string bgDrop { get; set; }
        public string bgOpen { get; set; }
        public string borderColorSelected { get; set; }
        public string borderWidthSelected { get; set; }
        public string bordercolor { get; set; }
        public string borderwidth { get; set; }
        public string fnt { get; set; }
        public string iconcolor { get; set; }
        public string iconcolorSelected { get; set; }
        public string linewidth { get; set; }
        public string rd { get; set; }
        public string separatorColor { get; set; }
        public string separatorHeight { get; set; }
        public string separatorWidthFull { get; set; }
        public string strokewidth { get; set; }
        public string textAlignment { get; set; }
        public string txt { get; set; }
        public string txts { get; set; }
    }

    public class Propertiessource181
    {
        public string alphabg { get; set; }
        public string alphabgDrop { get; set; }
        public string alphabgOpen { get; set; }
        public string alphaborderColorSelected { get; set; }
        public string alphabordercolor { get; set; }
        public string alphaiconcolor { get; set; }
        public string alphaiconcolorSelected { get; set; }
        public string alphaseparatorColor { get; set; }
        public string bg { get; set; }
        public string bgDrop { get; set; }
        public string bgOpen { get; set; }
        public string borderColorSelected { get; set; }
        public string borderWidthSelected { get; set; }
        public string bordercolor { get; set; }
        public string borderwidth { get; set; }
        public string fnt { get; set; }
        public string iconcolor { get; set; }
        public string iconcolorSelected { get; set; }
        public string linewidth { get; set; }
        public string rd { get; set; }
        public string separatorColor { get; set; }
        public string separatorHeight { get; set; }
        public string separatorWidthFull { get; set; }
        public string strokewidth { get; set; }
        public string textAlignment { get; set; }
        public string txt { get; set; }
        public string txts { get; set; }
    }

    public class Tm2
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata375 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style190 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata375
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style190
    {
        public Groups183 groups { get; set; }
        public Properties189 properties { get; set; }
        public Propertiessource182 propertiesSource { get; set; }
    }

    public class Groups183
    {
    }

    public class Properties189
    {
        public string alphabg { get; set; }
        public string alphabgDrop { get; set; }
        public string alphabgOpen { get; set; }
        public string alphaborderColorSelected { get; set; }
        public string alphabordercolor { get; set; }
        public string alphaiconcolor { get; set; }
        public string alphaiconcolorSelected { get; set; }
        public string alphaseparatorColor { get; set; }
        public string bg { get; set; }
        public string bgDrop { get; set; }
        public string bgOpen { get; set; }
        public string borderColorSelected { get; set; }
        public string borderWidthSelected { get; set; }
        public string bordercolor { get; set; }
        public string borderwidth { get; set; }
        public string fnt { get; set; }
        public string iconcolor { get; set; }
        public string iconcolorSelected { get; set; }
        public string linewidth { get; set; }
        public string rd { get; set; }
        public string separatorColor { get; set; }
        public string separatorHeight { get; set; }
        public string separatorWidth { get; set; }
        public string strokewidth { get; set; }
        public string textAlignment { get; set; }
        public string txt { get; set; }
        public string txts { get; set; }
    }

    public class Propertiessource182
    {
        public string alphabg { get; set; }
        public string alphabgDrop { get; set; }
        public string alphabgOpen { get; set; }
        public string alphaborderColorSelected { get; set; }
        public string alphabordercolor { get; set; }
        public string alphaiconcolor { get; set; }
        public string alphaiconcolorSelected { get; set; }
        public string alphaseparatorColor { get; set; }
        public string bg { get; set; }
        public string bgDrop { get; set; }
        public string bgOpen { get; set; }
        public string borderColorSelected { get; set; }
        public string borderWidthSelected { get; set; }
        public string bordercolor { get; set; }
        public string borderwidth { get; set; }
        public string fnt { get; set; }
        public string iconcolor { get; set; }
        public string iconcolorSelected { get; set; }
        public string linewidth { get; set; }
        public string rd { get; set; }
        public string separatorColor { get; set; }
        public string separatorHeight { get; set; }
        public string separatorWidth { get; set; }
        public string strokewidth { get; set; }
        public string textAlignment { get; set; }
        public string txt { get; set; }
        public string txts { get; set; }
    }

    public class Tmfull1
    {
        public string compId { get; set; }
        public string id { get; set; }
        public Metadata376 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style191 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata376
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style191
    {
        public Groups184 groups { get; set; }
        public Properties190 properties { get; set; }
        public Propertiessource183 propertiesSource { get; set; }
    }

    public class Groups184
    {
    }

    public class Properties190
    {
        public string alphabg { get; set; }
        public string alphabgDrop { get; set; }
        public string alphabgOpen { get; set; }
        public string alphaborderColorSelected { get; set; }
        public string alphabordercolor { get; set; }
        public string alphaiconcolor { get; set; }
        public string alphaiconcolorSelected { get; set; }
        public string alphaseparatorColor { get; set; }
        public string bg { get; set; }
        public string bgDrop { get; set; }
        public string bgOpen { get; set; }
        public string borderColorSelected { get; set; }
        public string borderWidthSelected { get; set; }
        public string bordercolor { get; set; }
        public string borderwidth { get; set; }
        public string fnt { get; set; }
        public string iconcolor { get; set; }
        public string iconcolorSelected { get; set; }
        public string linewidth { get; set; }
        public string rd { get; set; }
        public string separatorColor { get; set; }
        public string separatorHeight { get; set; }
        public string separatorWidthFull { get; set; }
        public string strokewidth { get; set; }
        public string textAlignment { get; set; }
        public string txt { get; set; }
        public string txts { get; set; }
    }

    public class Propertiessource183
    {
        public string alphabg { get; set; }
        public string alphabgDrop { get; set; }
        public string alphabgOpen { get; set; }
        public string alphaborderColorSelected { get; set; }
        public string alphabordercolor { get; set; }
        public string alphaiconcolor { get; set; }
        public string alphaiconcolorSelected { get; set; }
        public string alphaseparatorColor { get; set; }
        public string bg { get; set; }
        public string bgDrop { get; set; }
        public string bgOpen { get; set; }
        public string borderColorSelected { get; set; }
        public string borderWidthSelected { get; set; }
        public string bordercolor { get; set; }
        public string borderwidth { get; set; }
        public string fnt { get; set; }
        public string iconcolor { get; set; }
        public string iconcolorSelected { get; set; }
        public string linewidth { get; set; }
        public string rd { get; set; }
        public string separatorColor { get; set; }
        public string separatorHeight { get; set; }
        public string separatorWidthFull { get; set; }
        public string strokewidth { get; set; }
        public string textAlignment { get; set; }
        public string txt { get; set; }
        public string txts { get; set; }
    }

    public class Tmfull2
    {
        public string compId { get; set; }
        public string id { get; set; }
        public Metadata377 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style192 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata377
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style192
    {
        public Groups185 groups { get; set; }
        public Properties191 properties { get; set; }
        public Propertiessource184 propertiesSource { get; set; }
    }

    public class Groups185
    {
    }

    public class Properties191
    {
        public string alphabg { get; set; }
        public string alphabgDrop { get; set; }
        public string alphabgOpen { get; set; }
        public string alphaborderColorSelected { get; set; }
        public string alphabordercolor { get; set; }
        public string alphaiconcolor { get; set; }
        public string alphaiconcolorSelected { get; set; }
        public string alphaseparatorColor { get; set; }
        public string bg { get; set; }
        public string bgDrop { get; set; }
        public string bgOpen { get; set; }
        public string borderColorSelected { get; set; }
        public string borderWidthSelected { get; set; }
        public string bordercolor { get; set; }
        public string borderwidth { get; set; }
        public string fnt { get; set; }
        public string iconcolor { get; set; }
        public string iconcolorSelected { get; set; }
        public string linewidth { get; set; }
        public string rd { get; set; }
        public string separatorColor { get; set; }
        public string separatorHeight { get; set; }
        public string separatorWidthFull { get; set; }
        public string strokewidth { get; set; }
        public string textAlignment { get; set; }
        public string txt { get; set; }
        public string txts { get; set; }
    }

    public class Propertiessource184
    {
        public string alphabg { get; set; }
        public string alphabgDrop { get; set; }
        public string alphabgOpen { get; set; }
        public string alphaborderColorSelected { get; set; }
        public string alphabordercolor { get; set; }
        public string alphaiconcolor { get; set; }
        public string alphaiconcolorSelected { get; set; }
        public string alphaseparatorColor { get; set; }
        public string bg { get; set; }
        public string bgDrop { get; set; }
        public string bgOpen { get; set; }
        public string borderColorSelected { get; set; }
        public string borderWidthSelected { get; set; }
        public string bordercolor { get; set; }
        public string borderwidth { get; set; }
        public string fnt { get; set; }
        public string iconcolor { get; set; }
        public string iconcolorSelected { get; set; }
        public string linewidth { get; set; }
        public string rd { get; set; }
        public string separatorColor { get; set; }
        public string separatorHeight { get; set; }
        public string separatorWidthFull { get; set; }
        public string strokewidth { get; set; }
        public string textAlignment { get; set; }
        public string txt { get; set; }
        public string txts { get; set; }
    }

    public class Tpas0
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata378 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style193 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata378
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style193
    {
        public Groups186 groups { get; set; }
        public Properties192 properties { get; set; }
        public Propertiessource185 propertiesSource { get; set; }
    }

    public class Groups186
    {
    }

    public class Properties192
    {
    }

    public class Propertiessource185
    {
    }

    public class Tpaw0
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata379 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style194 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata379
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style194
    {
        public Groups187 groups { get; set; }
        public Properties193 properties { get; set; }
        public Propertiessource186 propertiesSource { get; set; }
    }

    public class Groups187
    {
    }

    public class Properties193
    {
    }

    public class Propertiessource186
    {
    }

    public class Twf1
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata380 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style195 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata380
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style195
    {
        public Properties194 properties { get; set; }
    }

    public class Properties194
    {
        public string alphabg { get; set; }
        public string alphabg2 { get; set; }
        public string alphalinkColor { get; set; }
        public string alphatxt1 { get; set; }
        public string alphatxt2 { get; set; }
        public string bg { get; set; }
        public string bg2 { get; set; }
        public string brightnessbg { get; set; }
        public string brightnessbg2 { get; set; }
        public string brightnesslinkColor { get; set; }
        public string brightnesstxt1 { get; set; }
        public string brightnesstxt2 { get; set; }
        public string linkColor { get; set; }
        public string saturationbg { get; set; }
        public string saturationbg2 { get; set; }
        public string saturationlinkColor { get; set; }
        public string saturationtxt1 { get; set; }
        public string saturationtxt2 { get; set; }
        public string txt1 { get; set; }
        public string txt2 { get; set; }
    }

    public class Twt1
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata381 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style196 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata381
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style196
    {
        public Groups188 groups { get; set; }
        public Properties195 properties { get; set; }
        public Propertiessource187 propertiesSource { get; set; }
    }

    public class Groups188
    {
    }

    public class Properties195
    {
    }

    public class Propertiessource187
    {
    }

    public class Txt1
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata382 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style197 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata382
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style197
    {
        public Properties196 properties { get; set; }
        public Propertiessource188 propertiesSource { get; set; }
    }

    public class Properties196
    {
        public string f0 { get; set; }
        public string f1 { get; set; }
        public string f10 { get; set; }
        public string f2 { get; set; }
        public string f3 { get; set; }
        public string f4 { get; set; }
        public string f5 { get; set; }
        public string f6 { get; set; }
        public string f7 { get; set; }
        public string f8 { get; set; }
        public string f9 { get; set; }
    }

    public class Propertiessource188
    {
        public string f0 { get; set; }
        public string f1 { get; set; }
        public string f10 { get; set; }
        public string f2 { get; set; }
        public string f3 { get; set; }
        public string f4 { get; set; }
        public string f5 { get; set; }
        public string f6 { get; set; }
        public string f7 { get; set; }
        public string f8 { get; set; }
        public string f9 { get; set; }
    }

    public class Txtnew
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata383 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style198 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata383
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style198
    {
        public Groups189 groups { get; set; }
        public Properties197 properties { get; set; }
        public Propertiessource189 propertiesSource { get; set; }
    }

    public class Groups189
    {
    }

    public class Properties197
    {
        public string f0 { get; set; }
        public string f1 { get; set; }
        public string f10 { get; set; }
        public string f2 { get; set; }
        public string f3 { get; set; }
        public string f4 { get; set; }
        public string f5 { get; set; }
        public string f6 { get; set; }
        public string f7 { get; set; }
        public string f8 { get; set; }
        public string f9 { get; set; }
    }

    public class Propertiessource189
    {
        public string f0 { get; set; }
        public string f1 { get; set; }
        public string f10 { get; set; }
        public string f2 { get; set; }
        public string f3 { get; set; }
        public string f4 { get; set; }
        public string f5 { get; set; }
        public string f6 { get; set; }
        public string f7 { get; set; }
        public string f8 { get; set; }
        public string f9 { get; set; }
    }

    public class V1
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata384 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style199 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata384
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style199
    {
        public Groups190 groups { get; set; }
        public Properties198 properties { get; set; }
        public Propertiessource190 propertiesSource { get; set; }
    }

    public class Groups190
    {
    }

    public class Properties198
    {
    }

    public class Propertiessource190
    {
    }

    public class V2
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata385 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style200 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata385
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style200
    {
        public Groups191 groups { get; set; }
        public Properties199 properties { get; set; }
        public Propertiessource191 propertiesSource { get; set; }
    }

    public class Groups191
    {
    }

    public class Properties199
    {
        public string brd { get; set; }
        public string brw { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
    }

    public class Propertiessource191
    {
        public string brd { get; set; }
        public string brw { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
    }

    public class Vl1
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata386 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style201 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata386
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style201
    {
        public Groups192 groups { get; set; }
        public Properties200 properties { get; set; }
        public Propertiessource192 propertiesSource { get; set; }
    }

    public class Groups192
    {
    }

    public class Properties200
    {
        public string alphabrd { get; set; }
        public string brd { get; set; }
        public string lnw { get; set; }
    }

    public class Propertiessource192
    {
        public string brd { get; set; }
        public string lnw { get; set; }
    }

    public class Vl2
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata387 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style202 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata387
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style202
    {
        public Properties201 properties { get; set; }
    }

    public class Properties201
    {
        public string alphabrd { get; set; }
        public string brd { get; set; }
        public string lnw1 { get; set; }
        public string lnw2 { get; set; }
    }

    public class Vl3
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata388 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style203 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata388
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style203
    {
        public Groups193 groups { get; set; }
        public Properties202 properties { get; set; }
        public Propertiessource193 propertiesSource { get; set; }
    }

    public class Groups193
    {
    }

    public class Properties202
    {
        public string alphabrd { get; set; }
        public string brd { get; set; }
        public string lnw { get; set; }
    }

    public class Propertiessource193
    {
        public string brd { get; set; }
        public string lnw { get; set; }
    }

    public class Vl4
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata389 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style204 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata389
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style204
    {
        public Groups194 groups { get; set; }
        public Properties203 properties { get; set; }
        public Propertiessource194 propertiesSource { get; set; }
    }

    public class Groups194
    {
    }

    public class Properties203
    {
    }

    public class Propertiessource194
    {
    }

    public class Wp1
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata390 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style205 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata390
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style205
    {
        public Groups195 groups { get; set; }
        public Properties204 properties { get; set; }
        public Propertiessource195 propertiesSource { get; set; }
    }

    public class Groups195
    {
    }

    public class Properties204
    {
        public string alphabrd { get; set; }
        public string boxShadowToggleOnshd { get; set; }
        public string brd { get; set; }
        public string brw { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
    }

    public class Propertiessource195
    {
        public string brd { get; set; }
        public string brw { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
    }

    public class Wp2
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata391 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style206 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata391
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style206
    {
        public Groups196 groups { get; set; }
        public Properties205 properties { get; set; }
        public Propertiessource196 propertiesSource { get; set; }
    }

    public class Groups196
    {
    }

    public class Properties205
    {
    }

    public class Propertiessource196
    {
    }

    public class Wp3
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata392 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style207 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata392
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style207
    {
        public Properties206 properties { get; set; }
    }

    public class Properties206
    {
        public string alphabrd { get; set; }
        public string brd { get; set; }
        public string brw { get; set; }
        public string rd { get; set; }
    }

    public class Wp4
    {
        public string compId { get; set; }
        public string componentClassName { get; set; }
        public string id { get; set; }
        public Metadata393 metaData { get; set; }
        public string pageId { get; set; }
        public string skin { get; set; }
        public Style208 style { get; set; }
        public string styleType { get; set; }
        public string type { get; set; }
    }

    public class Metadata393
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Style208
    {
        public Groups197 groups { get; set; }
        public Properties207 properties { get; set; }
        public Propertiessource197 propertiesSource { get; set; }
    }

    public class Groups197
    {
    }

    public class Properties207
    {
        public string alphabrd { get; set; }
        public string boxShadowToggleOnshd { get; set; }
        public string brd { get; set; }
        public string brw { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
    }

    public class Propertiessource197
    {
        public string brd { get; set; }
        public string brw { get; set; }
        public string rd { get; set; }
        public string shd { get; set; }
    }

    public class Structure1
    {
        public DESKTOP20 DESKTOP { get; set; }
        public MOBILE19 MOBILE { get; set; }
    }

    public class DESKTOP20
    {
        public PAGES_CONTAINER PAGES_CONTAINER { get; set; }
        public SITE_FOOTER SITE_FOOTER { get; set; }
        public SITE_HEADER SITE_HEADER { get; set; }
        public SITE_PAGES1 SITE_PAGES { get; set; }
        public CompJ2a70sza compj2a70sza { get; set; }
        public CompJ2a78xj6 compj2a78xj6 { get; set; }
        public CompJ2bmyplk compj2bmyplk { get; set; }
        public CompJ2hkvwsi compj2hkvwsi { get; set; }
        public CompJ2hkwwx3 compj2hkwwx3 { get; set; }
        public CompJ2hkyb4y compj2hkyb4y { get; set; }
        public CompJ3blw2v3 compj3blw2v3 { get; set; }
        public CompJ5806vho compj5806vho { get; set; }
        public CompJ58bjlnt compj58bjlnt { get; set; }
        public CompJ58bpu78 compj58bpu78 { get; set; }
        public CompJ58dn2v6 compj58dn2v6 { get; set; }
        public CompJ5hvoav8 compj5hvoav8 { get; set; }
        public CompJ5hvpd07 compj5hvpd07 { get; set; }
        public CompJ9y1lr1v compj9y1lr1v { get; set; }
        public CompJgdpjt88 compjgdpjt88 { get; set; }
        public CompJgdpjtag compjgdpjtag { get; set; }
        public CompJhw101zo compjhw101zo { get; set; }
        public CompJmhheyly compjmhheyly { get; set; }
        public Masterpage2 masterPage { get; set; }
    }

    public class PAGES_CONTAINER
    {
        public string componentType { get; set; }
        public string[] components { get; set; }
        public string connectionQuery { get; set; }
        public string id { get; set; }
        public Layout32 layout { get; set; }
        public string parent { get; set; }
        public string skin { get; set; }
        public string styleId { get; set; }
        public string type { get; set; }
    }

    public class Layout32
    {
        public bool fixedPosition { get; set; }
        public int height { get; set; }
        public int rotationInDegrees { get; set; }
        public int scale { get; set; }
        public int width { get; set; }
        public int x { get; set; }
        public int y { get; set; }
    }

    public class SITE_FOOTER
    {
        public string componentType { get; set; }
        public string[] components { get; set; }
        public string connectionQuery { get; set; }
        public string id { get; set; }
        public Layout33 layout { get; set; }
        public string parent { get; set; }
        public string skin { get; set; }
        public string styleId { get; set; }
        public string type { get; set; }
    }

    public class Layout33
    {
        public bool fixedPosition { get; set; }
        public int height { get; set; }
        public int rotationInDegrees { get; set; }
        public int scale { get; set; }
        public int width { get; set; }
        public int x { get; set; }
        public int y { get; set; }
    }

    public class SITE_HEADER
    {
        public string componentType { get; set; }
        public string[] components { get; set; }
        public string connectionQuery { get; set; }
        public string id { get; set; }
        public Layout34 layout { get; set; }
        public string parent { get; set; }
        public string skin { get; set; }
        public string styleId { get; set; }
        public string type { get; set; }
    }

    public class Layout34
    {
        public bool fixedPosition { get; set; }
        public int height { get; set; }
        public int rotationInDegrees { get; set; }
        public int scale { get; set; }
        public int width { get; set; }
        public int x { get; set; }
        public int y { get; set; }
    }

    public class SITE_PAGES1
    {
        public string componentType { get; set; }
        public object[] components { get; set; }
        public string connectionQuery { get; set; }
        public string id { get; set; }
        public Layout35 layout { get; set; }
        public string parent { get; set; }
        public string propertyQuery { get; set; }
        public string skin { get; set; }
        public string type { get; set; }
    }

    public class Layout35
    {
        public bool fixedPosition { get; set; }
        public int height { get; set; }
        public int rotationInDegrees { get; set; }
        public int scale { get; set; }
        public int width { get; set; }
        public int x { get; set; }
        public int y { get; set; }
    }

    public class CompJ2a70sza
    {
        public string componentType { get; set; }
        public string connectionQuery { get; set; }
        public string dataQuery { get; set; }
        public string id { get; set; }
        public Layout36 layout { get; set; }
        public string parent { get; set; }
        public string propertyQuery { get; set; }
        public string skin { get; set; }
        public string styleId { get; set; }
        public string type { get; set; }
    }

    public class Layout36
    {
        public bool fixedPosition { get; set; }
        public int height { get; set; }
        public int rotationInDegrees { get; set; }
        public int scale { get; set; }
        public int width { get; set; }
        public int x { get; set; }
        public int y { get; set; }
    }

    public class CompJ2a78xj6
    {
        public string componentType { get; set; }
        public string connectionQuery { get; set; }
        public string dataQuery { get; set; }
        public string id { get; set; }
        public Layout37 layout { get; set; }
        public string mobileHintsQuery { get; set; }
        public string parent { get; set; }
        public string propertyQuery { get; set; }
        public string styleId { get; set; }
        public string type { get; set; }
    }

    public class Layout37
    {
        public bool fixedPosition { get; set; }
        public int height { get; set; }
        public int rotationInDegrees { get; set; }
        public int scale { get; set; }
        public int width { get; set; }
        public int x { get; set; }
        public int y { get; set; }
    }

    public class CompJ2bmyplk
    {
        public string componentType { get; set; }
        public string connectionQuery { get; set; }
        public string dataQuery { get; set; }
        public string id { get; set; }
        public Layout38 layout { get; set; }
        public string parent { get; set; }
        public string propertyQuery { get; set; }
        public string skin { get; set; }
        public string styleId { get; set; }
        public string type { get; set; }
    }

    public class Layout38
    {
        public bool fixedPosition { get; set; }
        public int height { get; set; }
        public int rotationInDegrees { get; set; }
        public int scale { get; set; }
        public int width { get; set; }
        public int x { get; set; }
        public int y { get; set; }
    }

    public class CompJ2hkvwsi
    {
        public string componentType { get; set; }
        public string connectionQuery { get; set; }
        public string dataQuery { get; set; }
        public string id { get; set; }
        public Layout39 layout { get; set; }
        public string parent { get; set; }
        public string propertyQuery { get; set; }
        public string skin { get; set; }
        public string styleId { get; set; }
        public string type { get; set; }
    }

    public class Layout39
    {
        public bool fixedPosition { get; set; }
        public int height { get; set; }
        public int rotationInDegrees { get; set; }
        public int scale { get; set; }
        public int width { get; set; }
        public int x { get; set; }
        public int y { get; set; }
    }

    public class CompJ2hkwwx3
    {
        public string componentType { get; set; }
        public string connectionQuery { get; set; }
        public string dataQuery { get; set; }
        public string id { get; set; }
        public Layout40 layout { get; set; }
        public string mobileHintsQuery { get; set; }
        public string parent { get; set; }
        public string propertyQuery { get; set; }
        public string styleId { get; set; }
        public string type { get; set; }
    }

    public class Layout40
    {
        public bool fixedPosition { get; set; }
        public int height { get; set; }
        public int rotationInDegrees { get; set; }
        public int scale { get; set; }
        public int width { get; set; }
        public int x { get; set; }
        public int y { get; set; }
    }

    public class CompJ2hkyb4y
    {
        public string componentType { get; set; }
        public string connectionQuery { get; set; }
        public string dataQuery { get; set; }
        public string id { get; set; }
        public Layout41 layout { get; set; }
        public string parent { get; set; }
        public string propertyQuery { get; set; }
        public string styleId { get; set; }
        public string type { get; set; }
    }

    public class Layout41
    {
        public bool fixedPosition { get; set; }
        public int height { get; set; }
        public int rotationInDegrees { get; set; }
        public int scale { get; set; }
        public int width { get; set; }
        public int x { get; set; }
        public int y { get; set; }
    }

    public class CompJ3blw2v3
    {
        public string componentType { get; set; }
        public string connectionQuery { get; set; }
        public string dataQuery { get; set; }
        public string id { get; set; }
        public Layout42 layout { get; set; }
        public string parent { get; set; }
        public string propertyQuery { get; set; }
        public string skin { get; set; }
        public string styleId { get; set; }
        public string type { get; set; }
    }

    public class Layout42
    {
        public bool fixedPosition { get; set; }
        public int height { get; set; }
        public int rotationInDegrees { get; set; }
        public int scale { get; set; }
        public int width { get; set; }
        public int x { get; set; }
        public int y { get; set; }
    }

    public class CompJ5806vho
    {
        public string componentType { get; set; }
        public string connectionQuery { get; set; }
        public string dataQuery { get; set; }
        public string id { get; set; }
        public Layout43 layout { get; set; }
        public string parent { get; set; }
        public string propertyQuery { get; set; }
        public string styleId { get; set; }
        public string type { get; set; }
    }

    public class Layout43
    {
        public bool fixedPosition { get; set; }
        public int height { get; set; }
        public int rotationInDegrees { get; set; }
        public int scale { get; set; }
        public int width { get; set; }
        public int x { get; set; }
        public int y { get; set; }
    }

    public class CompJ58bjlnt
    {
        public string componentType { get; set; }
        public string connectionQuery { get; set; }
        public string dataQuery { get; set; }
        public string id { get; set; }
        public Layout44 layout { get; set; }
        public string parent { get; set; }
        public string propertyQuery { get; set; }
        public string styleId { get; set; }
        public string type { get; set; }
    }

    public class Layout44
    {
        public bool fixedPosition { get; set; }
        public int height { get; set; }
        public int rotationInDegrees { get; set; }
        public int scale { get; set; }
        public int width { get; set; }
        public int x { get; set; }
        public int y { get; set; }
    }

    public class CompJ58bpu78
    {
        public string componentType { get; set; }
        public string connectionQuery { get; set; }
        public string dataQuery { get; set; }
        public string id { get; set; }
        public Layout45 layout { get; set; }
        public string parent { get; set; }
        public string propertyQuery { get; set; }
        public string styleId { get; set; }
        public string type { get; set; }
    }

    public class Layout45
    {
        public bool fixedPosition { get; set; }
        public int height { get; set; }
        public int rotationInDegrees { get; set; }
        public int scale { get; set; }
        public int width { get; set; }
        public int x { get; set; }
        public int y { get; set; }
    }

    public class CompJ58dn2v6
    {
        public string componentType { get; set; }
        public string connectionQuery { get; set; }
        public string dataQuery { get; set; }
        public string id { get; set; }
        public Layout46 layout { get; set; }
        public string parent { get; set; }
        public string propertyQuery { get; set; }
        public string styleId { get; set; }
        public string type { get; set; }
    }

    public class Layout46
    {
        public bool fixedPosition { get; set; }
        public int height { get; set; }
        public int rotationInDegrees { get; set; }
        public int scale { get; set; }
        public int width { get; set; }
        public int x { get; set; }
        public int y { get; set; }
    }

    public class CompJ5hvoav8
    {
        public string componentType { get; set; }
        public string connectionQuery { get; set; }
        public string dataQuery { get; set; }
        public string id { get; set; }
        public Layout47 layout { get; set; }
        public string parent { get; set; }
        public string propertyQuery { get; set; }
        public string styleId { get; set; }
        public string type { get; set; }
    }

    public class Layout47
    {
        public bool fixedPosition { get; set; }
        public int height { get; set; }
        public int rotationInDegrees { get; set; }
        public int scale { get; set; }
        public int width { get; set; }
        public int x { get; set; }
        public int y { get; set; }
    }

    public class CompJ5hvpd07
    {
        public string componentType { get; set; }
        public string connectionQuery { get; set; }
        public string dataQuery { get; set; }
        public string id { get; set; }
        public Layout48 layout { get; set; }
        public string parent { get; set; }
        public string propertyQuery { get; set; }
        public string styleId { get; set; }
        public string type { get; set; }
    }

    public class Layout48
    {
        public bool fixedPosition { get; set; }
        public int height { get; set; }
        public int rotationInDegrees { get; set; }
        public int scale { get; set; }
        public int width { get; set; }
        public int x { get; set; }
        public int y { get; set; }
    }

    public class CompJ9y1lr1v
    {
        public string componentType { get; set; }
        public string connectionQuery { get; set; }
        public string dataQuery { get; set; }
        public string id { get; set; }
        public Layout49 layout { get; set; }
        public string parent { get; set; }
        public string propertyQuery { get; set; }
        public string skin { get; set; }
        public string styleId { get; set; }
        public string type { get; set; }
    }

    public class Layout49
    {
        public bool fixedPosition { get; set; }
        public int height { get; set; }
        public int rotationInDegrees { get; set; }
        public int scale { get; set; }
        public int width { get; set; }
        public int x { get; set; }
        public int y { get; set; }
    }

    public class CompJgdpjt88
    {
        public string componentType { get; set; }
        public string[] components { get; set; }
        public string connectionQuery { get; set; }
        public string designQuery { get; set; }
        public string id { get; set; }
        public Layout50 layout { get; set; }
        public string mobileHintsQuery { get; set; }
        public string parent { get; set; }
        public string propertyQuery { get; set; }
        public string styleId { get; set; }
        public string type { get; set; }
    }

    public class Layout50
    {
        public bool fixedPosition { get; set; }
        public int height { get; set; }
        public int rotationInDegrees { get; set; }
        public int scale { get; set; }
        public int width { get; set; }
        public int x { get; set; }
        public int y { get; set; }
    }

    public class CompJgdpjtag
    {
        public string componentType { get; set; }
        public object[] components { get; set; }
        public string connectionQuery { get; set; }
        public string designQuery { get; set; }
        public string id { get; set; }
        public Layout51 layout { get; set; }
        public string mobileHintsQuery { get; set; }
        public string parent { get; set; }
        public string propertyQuery { get; set; }
        public string styleId { get; set; }
        public string type { get; set; }
    }

    public class Layout51
    {
        public bool fixedPosition { get; set; }
        public int height { get; set; }
        public int rotationInDegrees { get; set; }
        public int scale { get; set; }
        public int width { get; set; }
        public int x { get; set; }
        public int y { get; set; }
    }

    public class CompJhw101zo
    {
        public string componentType { get; set; }
        public string connectionQuery { get; set; }
        public string dataQuery { get; set; }
        public string id { get; set; }
        public Layout52 layout { get; set; }
        public string parent { get; set; }
        public string propertyQuery { get; set; }
        public string styleId { get; set; }
        public string type { get; set; }
    }

    public class Layout52
    {
        public bool fixedPosition { get; set; }
        public int height { get; set; }
        public int rotationInDegrees { get; set; }
        public int scale { get; set; }
        public int width { get; set; }
        public int x { get; set; }
        public int y { get; set; }
    }

    public class CompJmhheyly
    {
        public string componentType { get; set; }
        public string connectionQuery { get; set; }
        public string dataQuery { get; set; }
        public string id { get; set; }
        public Layout53 layout { get; set; }
        public string mobileHintsQuery { get; set; }
        public string parent { get; set; }
        public string propertyQuery { get; set; }
        public string styleId { get; set; }
        public string type { get; set; }
    }

    public class Layout53
    {
        public bool fixedPosition { get; set; }
        public int height { get; set; }
        public int rotationInDegrees { get; set; }
        public int scale { get; set; }
        public int width { get; set; }
        public int x { get; set; }
        public int y { get; set; }
    }

    public class Masterpage2
    {
        public Componentproperties componentProperties { get; set; }
        public string componentType { get; set; }
        public string[] components { get; set; }
        public string dataQuery { get; set; }
        public string documentType { get; set; }
        public string id { get; set; }
        public Layout54 layout { get; set; }
        public string mobileHintsQuery { get; set; }
        public Themedata themeData { get; set; }
        public string type { get; set; }
    }

    public class Componentproperties
    {
    }

    public class Layout54
    {
        public Anchor[] anchors { get; set; }
        public int rotationInDegrees { get; set; }
        public int y { get; set; }
    }

    public class Anchor
    {
        public int distance { get; set; }
        public bool locked { get; set; }
        public string targetComponent { get; set; }
        public string type { get; set; }
    }

    public class Themedata
    {
    }

    public class MOBILE19
    {
        public BACK_TO_TOP_BUTTON BACK_TO_TOP_BUTTON { get; set; }
        public PAGES_CONTAINER1 PAGES_CONTAINER { get; set; }
        public SITE_FOOTER1 SITE_FOOTER { get; set; }
        public SITE_HEADER1 SITE_HEADER { get; set; }
        public SITE_PAGES2 SITE_PAGES { get; set; }
        public TINY_MENU2 TINY_MENU { get; set; }
        public CompJ2a78xj61 compj2a78xj6 { get; set; }
        public CompJ2bmyplk1 compj2bmyplk { get; set; }
        public CompJ2hkvwsi1 compj2hkvwsi { get; set; }
        public CompJ2hkyb4y1 compj2hkyb4y { get; set; }
        public CompJ3blw2v31 compj3blw2v3 { get; set; }
        public CompJ5806vho1 compj5806vho { get; set; }
        public CompJ58bjlnt1 compj58bjlnt { get; set; }
        public CompJ58bpu781 compj58bpu78 { get; set; }
        public CompJ58dn2v61 compj58dn2v6 { get; set; }
        public CompJ5hvoav81 compj5hvoav8 { get; set; }
        public CompJ5hvpd071 compj5hvpd07 { get; set; }
        public CompJ9y1lr1v1 compj9y1lr1v { get; set; }
        public CompJhw101zo1 compjhw101zo { get; set; }
        public CompJmhheyly1 compjmhheyly { get; set; }
        public Masterpage3 masterPage { get; set; }
    }

    public class BACK_TO_TOP_BUTTON
    {
        public string componentType { get; set; }
        public string connectionQuery { get; set; }
        public string id { get; set; }
        public Layout55 layout { get; set; }
        public string parent { get; set; }
        public string skin { get; set; }
        public string styleId { get; set; }
        public string type { get; set; }
    }

    public class Layout55
    {
        public int height { get; set; }
        public int rotationInDegrees { get; set; }
        public int width { get; set; }
        public int x { get; set; }
        public int y { get; set; }
    }

    public class PAGES_CONTAINER1
    {
        public string componentType { get; set; }
        public string[] components { get; set; }
        public string connectionQuery { get; set; }
        public string id { get; set; }
        public Layout56 layout { get; set; }
        public string parent { get; set; }
        public string skin { get; set; }
        public string styleId { get; set; }
        public string type { get; set; }
    }

    public class Layout56
    {
        public bool fixedPosition { get; set; }
        public int height { get; set; }
        public int rotationInDegrees { get; set; }
        public int scale { get; set; }
        public int width { get; set; }
        public int x { get; set; }
        public int y { get; set; }
    }

    public class SITE_FOOTER1
    {
        public string componentType { get; set; }
        public string[] components { get; set; }
        public string connectionQuery { get; set; }
        public string id { get; set; }
        public Layout57 layout { get; set; }
        public string parent { get; set; }
        public string skin { get; set; }
        public string styleId { get; set; }
        public string type { get; set; }
    }

    public class Layout57
    {
        public bool fixedPosition { get; set; }
        public int height { get; set; }
        public int rotationInDegrees { get; set; }
        public int scale { get; set; }
        public int width { get; set; }
        public int x { get; set; }
        public int y { get; set; }
    }

    public class SITE_HEADER1
    {
        public string componentType { get; set; }
        public string[] components { get; set; }
        public string connectionQuery { get; set; }
        public string id { get; set; }
        public Layout58 layout { get; set; }
        public string parent { get; set; }
        public string skin { get; set; }
        public string styleId { get; set; }
        public string type { get; set; }
    }

    public class Layout58
    {
        public bool fixedPosition { get; set; }
        public int height { get; set; }
        public int rotationInDegrees { get; set; }
        public int scale { get; set; }
        public int width { get; set; }
        public int x { get; set; }
        public int y { get; set; }
    }

    public class SITE_PAGES2
    {
        public string componentType { get; set; }
        public object[] components { get; set; }
        public string connectionQuery { get; set; }
        public string id { get; set; }
        public Layout59 layout { get; set; }
        public string parent { get; set; }
        public string propertyQuery { get; set; }
        public string skin { get; set; }
        public string type { get; set; }
    }

    public class Layout59
    {
        public bool fixedPosition { get; set; }
        public int height { get; set; }
        public int rotationInDegrees { get; set; }
        public int scale { get; set; }
        public int width { get; set; }
        public int x { get; set; }
        public int y { get; set; }
    }

    public class TINY_MENU2
    {
        public string componentType { get; set; }
        public string connectionQuery { get; set; }
        public string dataQuery { get; set; }
        public string id { get; set; }
        public Layout60 layout { get; set; }
        public string parent { get; set; }
        public string propertyQuery { get; set; }
        public string skin { get; set; }
        public string styleId { get; set; }
        public string type { get; set; }
    }

    public class Layout60
    {
        public bool fixedPosition { get; set; }
        public int height { get; set; }
        public int rotationInDegrees { get; set; }
        public int scale { get; set; }
        public int width { get; set; }
        public int x { get; set; }
        public int y { get; set; }
    }

    public class CompJ2a78xj61
    {
        public string componentType { get; set; }
        public string connectionQuery { get; set; }
        public string dataQuery { get; set; }
        public string id { get; set; }
        public Layout61 layout { get; set; }
        public string mobileHintsQuery { get; set; }
        public string parent { get; set; }
        public string propertyQuery { get; set; }
        public string styleId { get; set; }
        public string type { get; set; }
    }

    public class Layout61
    {
        public bool fixedPosition { get; set; }
        public int height { get; set; }
        public int rotationInDegrees { get; set; }
        public int scale { get; set; }
        public int width { get; set; }
        public int x { get; set; }
        public int y { get; set; }
    }

    public class CompJ2bmyplk1
    {
        public string componentType { get; set; }
        public string connectionQuery { get; set; }
        public string dataQuery { get; set; }
        public string id { get; set; }
        public Layout62 layout { get; set; }
        public string parent { get; set; }
        public string propertyQuery { get; set; }
        public string skin { get; set; }
        public string styleId { get; set; }
        public string type { get; set; }
    }

    public class Layout62
    {
        public bool fixedPosition { get; set; }
        public int height { get; set; }
        public int rotationInDegrees { get; set; }
        public int scale { get; set; }
        public int width { get; set; }
        public int x { get; set; }
        public int y { get; set; }
    }

    public class CompJ2hkvwsi1
    {
        public string componentType { get; set; }
        public string connectionQuery { get; set; }
        public string dataQuery { get; set; }
        public string id { get; set; }
        public Layout63 layout { get; set; }
        public string parent { get; set; }
        public string propertyQuery { get; set; }
        public string skin { get; set; }
        public string styleId { get; set; }
        public string type { get; set; }
    }

    public class Layout63
    {
        public bool fixedPosition { get; set; }
        public int height { get; set; }
        public int rotationInDegrees { get; set; }
        public int scale { get; set; }
        public int width { get; set; }
        public int x { get; set; }
        public int y { get; set; }
    }

    public class CompJ2hkyb4y1
    {
        public string componentType { get; set; }
        public string connectionQuery { get; set; }
        public string dataQuery { get; set; }
        public string id { get; set; }
        public Layout64 layout { get; set; }
        public string parent { get; set; }
        public string propertyQuery { get; set; }
        public string styleId { get; set; }
        public string type { get; set; }
    }

    public class Layout64
    {
        public bool fixedPosition { get; set; }
        public int height { get; set; }
        public int rotationInDegrees { get; set; }
        public int scale { get; set; }
        public int width { get; set; }
        public int x { get; set; }
        public int y { get; set; }
    }

    public class CompJ3blw2v31
    {
        public string componentType { get; set; }
        public string connectionQuery { get; set; }
        public string dataQuery { get; set; }
        public string id { get; set; }
        public Layout65 layout { get; set; }
        public string parent { get; set; }
        public string propertyQuery { get; set; }
        public string skin { get; set; }
        public string styleId { get; set; }
        public string type { get; set; }
    }

    public class Layout65
    {
        public bool fixedPosition { get; set; }
        public int height { get; set; }
        public int rotationInDegrees { get; set; }
        public int scale { get; set; }
        public int width { get; set; }
        public int x { get; set; }
        public int y { get; set; }
    }

    public class CompJ5806vho1
    {
        public string componentType { get; set; }
        public string connectionQuery { get; set; }
        public string dataQuery { get; set; }
        public string id { get; set; }
        public Layout66 layout { get; set; }
        public string parent { get; set; }
        public string propertyQuery { get; set; }
        public string styleId { get; set; }
        public string type { get; set; }
    }

    public class Layout66
    {
        public bool fixedPosition { get; set; }
        public int height { get; set; }
        public int rotationInDegrees { get; set; }
        public float scale { get; set; }
        public int width { get; set; }
        public int x { get; set; }
        public int y { get; set; }
    }

    public class CompJ58bjlnt1
    {
        public string componentType { get; set; }
        public string connectionQuery { get; set; }
        public string dataQuery { get; set; }
        public string id { get; set; }
        public Layout67 layout { get; set; }
        public string parent { get; set; }
        public string propertyQuery { get; set; }
        public string styleId { get; set; }
        public string type { get; set; }
    }

    public class Layout67
    {
        public bool fixedPosition { get; set; }
        public int height { get; set; }
        public int rotationInDegrees { get; set; }
        public int scale { get; set; }
        public int width { get; set; }
        public int x { get; set; }
        public int y { get; set; }
    }

    public class CompJ58bpu781
    {
        public string componentType { get; set; }
        public string connectionQuery { get; set; }
        public string dataQuery { get; set; }
        public string id { get; set; }
        public Layout68 layout { get; set; }
        public string parent { get; set; }
        public string propertyQuery { get; set; }
        public string styleId { get; set; }
        public string type { get; set; }
    }

    public class Layout68
    {
        public bool fixedPosition { get; set; }
        public int height { get; set; }
        public int rotationInDegrees { get; set; }
        public int scale { get; set; }
        public int width { get; set; }
        public int x { get; set; }
        public int y { get; set; }
    }

    public class CompJ58dn2v61
    {
        public string componentType { get; set; }
        public string connectionQuery { get; set; }
        public string dataQuery { get; set; }
        public string id { get; set; }
        public Layout69 layout { get; set; }
        public string parent { get; set; }
        public string propertyQuery { get; set; }
        public string styleId { get; set; }
        public string type { get; set; }
    }

    public class Layout69
    {
        public bool fixedPosition { get; set; }
        public int height { get; set; }
        public int rotationInDegrees { get; set; }
        public int scale { get; set; }
        public int width { get; set; }
        public int x { get; set; }
        public int y { get; set; }
    }

    public class CompJ5hvoav81
    {
        public string componentType { get; set; }
        public string connectionQuery { get; set; }
        public string dataQuery { get; set; }
        public string id { get; set; }
        public Layout70 layout { get; set; }
        public string parent { get; set; }
        public string propertyQuery { get; set; }
        public string styleId { get; set; }
        public string type { get; set; }
    }

    public class Layout70
    {
        public bool fixedPosition { get; set; }
        public int height { get; set; }
        public int rotationInDegrees { get; set; }
        public int scale { get; set; }
        public int width { get; set; }
        public int x { get; set; }
        public int y { get; set; }
    }

    public class CompJ5hvpd071
    {
        public string componentType { get; set; }
        public string connectionQuery { get; set; }
        public string dataQuery { get; set; }
        public string id { get; set; }
        public Layout71 layout { get; set; }
        public string parent { get; set; }
        public string propertyQuery { get; set; }
        public string styleId { get; set; }
        public string type { get; set; }
    }

    public class Layout71
    {
        public bool fixedPosition { get; set; }
        public int height { get; set; }
        public int rotationInDegrees { get; set; }
        public int scale { get; set; }
        public int width { get; set; }
        public int x { get; set; }
        public int y { get; set; }
    }

    public class CompJ9y1lr1v1
    {
        public string componentType { get; set; }
        public string connectionQuery { get; set; }
        public string dataQuery { get; set; }
        public string id { get; set; }
        public Layout72 layout { get; set; }
        public string parent { get; set; }
        public string propertyQuery { get; set; }
        public string skin { get; set; }
        public string styleId { get; set; }
        public string type { get; set; }
    }

    public class Layout72
    {
        public bool fixedPosition { get; set; }
        public int height { get; set; }
        public int rotationInDegrees { get; set; }
        public int scale { get; set; }
        public int width { get; set; }
        public int x { get; set; }
        public int y { get; set; }
    }

    public class CompJhw101zo1
    {
        public string componentType { get; set; }
        public string connectionQuery { get; set; }
        public string dataQuery { get; set; }
        public string id { get; set; }
        public Layout73 layout { get; set; }
        public string parent { get; set; }
        public string propertyQuery { get; set; }
        public string styleId { get; set; }
        public string type { get; set; }
    }

    public class Layout73
    {
        public bool fixedPosition { get; set; }
        public int height { get; set; }
        public int rotationInDegrees { get; set; }
        public int scale { get; set; }
        public int width { get; set; }
        public int x { get; set; }
        public int y { get; set; }
    }

    public class CompJmhheyly1
    {
        public string componentType { get; set; }
        public string connectionQuery { get; set; }
        public string dataQuery { get; set; }
        public string id { get; set; }
        public Layout74 layout { get; set; }
        public string mobileHintsQuery { get; set; }
        public string parent { get; set; }
        public string propertyQuery { get; set; }
        public string styleId { get; set; }
        public string type { get; set; }
    }

    public class Layout74
    {
        public bool fixedPosition { get; set; }
        public int height { get; set; }
        public int rotationInDegrees { get; set; }
        public float scale { get; set; }
        public int width { get; set; }
        public int x { get; set; }
        public int y { get; set; }
    }

    public class Masterpage3
    {
        public Componentproperties1 componentProperties { get; set; }
        public string componentType { get; set; }
        public string[] components { get; set; }
        public string dataQuery { get; set; }
        public string documentType { get; set; }
        public string id { get; set; }
        public Layout75 layout { get; set; }
        public string mobileHintsQuery { get; set; }
        public Themedata1 themeData { get; set; }
        public string type { get; set; }
    }

    public class Componentproperties1
    {
    }

    public class Layout75
    {
        public Anchor1[] anchors { get; set; }
        public int rotationInDegrees { get; set; }
        public int y { get; set; }
    }

    public class Anchor1
    {
        public int distance { get; set; }
        public bool locked { get; set; }
        public string targetComponent { get; set; }
        public string type { get; set; }
    }

    public class Themedata1
    {
    }

    public class Dynamicpages
    {
        public Data2 data { get; set; }
        public Headdata headData { get; set; }
    }

    public class Data2
    {
        public Ai3xt4 ai3xt { get; set; }
    }

    public class Ai3xt4
    {
        public Routerdata routerData { get; set; }
        public Routerdefinition routerDefinition { get; set; }
    }

    public class Routerdata
    {
        public Config config { get; set; }
        public string dynamicUrl { get; set; }
        public Item40[] items { get; set; }
        public Schemas schemas { get; set; }
        public int totalCount { get; set; }
        public Userdefinedfilter userDefinedFilter { get; set; }
    }

    public class Config
    {
        public Dataset dataset { get; set; }
    }

    public class Dataset
    {
        public string collection { get; set; }
        public string collectionName { get; set; }
        public Filter filter { get; set; }
        public object[] sort { get; set; }
    }

    public class Filter
    {
        public And[] and { get; set; }
    }

    public class And
    {
        public Title title { get; set; }
    }

    public class Title
    {
        public Matches matches { get; set; }
    }

    public class Matches
    {
        public bool ignoreCase { get; set; }
        public Spec[] spec { get; set; }
    }

    public class Spec
    {
        public string type { get; set; }
        public string value { get; set; }
    }

    public class Schemas
    {
        public LesTraiteurs lestraiteurs { get; set; }
    }

    public class LesTraiteurs
    {
        public string[] allowedOperations { get; set; }
        public string displayField { get; set; }
        public string displayName { get; set; }
        public object displayNamespace { get; set; }
        public Fields fields { get; set; }
        public string id { get; set; }
        public bool isDeleted { get; set; }
        public object _namespace { get; set; }
        public object ownerAppId { get; set; }
        public string storage { get; set; }
    }

    public class Fields
    {
        public _Createddate _createdDate { get; set; }
        public _Id _id { get; set; }
        public _Owner _owner { get; set; }
        public _Updateddate _updatedDate { get; set; }
        public Adresse adresse { get; set; }
        public Contact contact { get; set; }
        public Contactcommercial contactCommercial { get; set; }
        public Dirigeant dirigeant { get; set; }
        public Imagedroite imageDroite { get; set; }
        public Imagegauche imageGauche { get; set; }
        public Liendusite lienDuSite { get; set; }
        public Liensite lienSite { get; set; }
        public Lieudintervention lieuDIntervention { get; set; }
        public Lieuintervention lieuIntervention { get; set; }
        public LinkLesTraiteursAll linklestraiteursall { get; set; }
        public LinkLesTraiteursTitle linklestraiteurstitle { get; set; }
        public Logo logo { get; set; }
        public Region region { get; set; }
        public Title1 title { get; set; }
    }

    public class _Createddate
    {
        public string displayName { get; set; }
        public int index { get; set; }
        public bool isDeleted { get; set; }
        public bool sortable { get; set; }
        public bool systemField { get; set; }
        public string type { get; set; }
    }

    public class _Id
    {
        public string displayName { get; set; }
        public int index { get; set; }
        public bool isDeleted { get; set; }
        public bool primaryKey { get; set; }
        public bool sortable { get; set; }
        public bool systemField { get; set; }
        public string type { get; set; }
    }

    public class _Owner
    {
        public string displayName { get; set; }
        public int index { get; set; }
        public bool isDeleted { get; set; }
        public bool sortable { get; set; }
        public bool systemField { get; set; }
        public string type { get; set; }
    }

    public class _Updateddate
    {
        public string displayName { get; set; }
        public int index { get; set; }
        public bool isDeleted { get; set; }
        public bool sortable { get; set; }
        public bool systemField { get; set; }
        public string type { get; set; }
    }

    public class Adresse
    {
        public string displayName { get; set; }
        public int index { get; set; }
        public bool isDeleted { get; set; }
        public bool sortable { get; set; }
        public bool systemField { get; set; }
        public string type { get; set; }
    }

    public class Contact
    {
        public string displayName { get; set; }
        public int index { get; set; }
        public bool isDeleted { get; set; }
        public string referencedCollection { get; set; }
        public bool sortable { get; set; }
        public bool systemField { get; set; }
        public string type { get; set; }
    }

    public class Contactcommercial
    {
        public string displayName { get; set; }
        public int index { get; set; }
        public bool isDeleted { get; set; }
        public bool sortable { get; set; }
        public bool systemField { get; set; }
        public string type { get; set; }
    }

    public class Dirigeant
    {
        public string displayName { get; set; }
        public int index { get; set; }
        public bool isDeleted { get; set; }
        public bool sortable { get; set; }
        public bool systemField { get; set; }
        public string type { get; set; }
    }

    public class Imagedroite
    {
        public string displayName { get; set; }
        public int index { get; set; }
        public bool isDeleted { get; set; }
        public bool sortable { get; set; }
        public bool systemField { get; set; }
        public string type { get; set; }
    }

    public class Imagegauche
    {
        public string displayName { get; set; }
        public int index { get; set; }
        public bool isDeleted { get; set; }
        public bool sortable { get; set; }
        public bool systemField { get; set; }
        public string type { get; set; }
    }

    public class Liendusite
    {
        public string displayName { get; set; }
        public int index { get; set; }
        public bool isDeleted { get; set; }
        public bool sortable { get; set; }
        public bool systemField { get; set; }
        public string type { get; set; }
    }

    public class Liensite
    {
        public string displayName { get; set; }
        public int index { get; set; }
        public bool isDeleted { get; set; }
        public bool sortable { get; set; }
        public bool systemField { get; set; }
        public string type { get; set; }
    }

    public class Lieudintervention
    {
        public string displayName { get; set; }
        public int index { get; set; }
        public bool isDeleted { get; set; }
        public bool sortable { get; set; }
        public bool systemField { get; set; }
        public string type { get; set; }
    }

    public class Lieuintervention
    {
        public string displayName { get; set; }
        public int index { get; set; }
        public bool isDeleted { get; set; }
        public bool sortable { get; set; }
        public bool systemField { get; set; }
        public string type { get; set; }
    }

    public class LinkLesTraiteursAll
    {
        public Calculator calculator { get; set; }
        public string displayName { get; set; }
        public int index { get; set; }
        public bool isDeleted { get; set; }
        public string plugin { get; set; }
        public bool sortable { get; set; }
        public bool systemField { get; set; }
        public string type { get; set; }
    }

    public class Calculator
    {
        public Config1 config { get; set; }
        public string id { get; set; }
    }

    public class Config1
    {
        public string pattern { get; set; }
    }

    public class LinkLesTraiteursTitle
    {
        public Calculator1 calculator { get; set; }
        public string displayName { get; set; }
        public int index { get; set; }
        public bool isDeleted { get; set; }
        public string plugin { get; set; }
        public bool sortable { get; set; }
        public bool systemField { get; set; }
        public string type { get; set; }
    }

    public class Calculator1
    {
        public Config2 config { get; set; }
        public string id { get; set; }
    }

    public class Config2
    {
        public string pattern { get; set; }
    }

    public class Logo
    {
        public string displayName { get; set; }
        public int index { get; set; }
        public bool isDeleted { get; set; }
        public bool sortable { get; set; }
        public bool systemField { get; set; }
        public string type { get; set; }
    }

    public class Region
    {
        public string displayName { get; set; }
        public int index { get; set; }
        public bool isDeleted { get; set; }
        public bool sortable { get; set; }
        public bool systemField { get; set; }
        public string type { get; set; }
    }

    public class Title1
    {
        public string displayName { get; set; }
        public int index { get; set; }
        public bool isDeleted { get; set; }
        public bool sortable { get; set; }
        public bool systemField { get; set; }
        public string type { get; set; }
    }

    public class Userdefinedfilter
    {
    }

    public class Item40
    {
        public _Createddate1 _createdDate { get; set; }
        public string _id { get; set; }
        public string _owner { get; set; }
        public _Updateddate1 _updatedDate { get; set; }
        public string adresse { get; set; }
        public string contactCommercial { get; set; }
        public string dirigeant { get; set; }
        public string imageDroite { get; set; }
        public string imageGauche { get; set; }
        public string lienSite { get; set; }
        public string lieuIntervention { get; set; }
        public string linklestraiteursall { get; set; }
        public string linklestraiteurstitle { get; set; }
        public string logo { get; set; }
        public string region { get; set; }
        public string title { get; set; }
    }

    public class _Createddate1
    {
        public DateTime date { get; set; }
    }

    public class _Updateddate1
    {
        public DateTime date { get; set; }
    }

    public class Routerdefinition
    {
        public string appDefinitionId { get; set; }
        public string config { get; set; }
        public Pages pages { get; set; }
        public string prefix { get; set; }
        public string routerId { get; set; }
    }

    public class Pages
    {
        public string _61ce7fc8fa5948088d63730c2e1dca33 { get; set; }
    }

    public class Headdata
    {
        public Ai3xt5 ai3xt { get; set; }
    }

    public class Ai3xt5
    {
        public string description { get; set; }
        public string keywords { get; set; }
        public Metatags metaTags { get; set; }
        public string title { get; set; }
    }

    public class Metatags
    {
        public string ogdescription { get; set; }
        public string ogimage { get; set; }
        public string ogtitle { get; set; }
        public string robots { get; set; }
    }

    public class Externalstyles
    {
        public string googleFonts { get; set; }
        public string languages { get; set; }
    }

    public class Fixedpagesurls
    {
        public string ai3xt { get; set; }
        public string masterPage { get; set; }
    }

    public class Landingpagenavigationinfo
    {
        public string format { get; set; }
        public string innerRoute { get; set; }
        public string pageAdditionalData { get; set; }
        public string pageId { get; set; }
        public Routerdefinition1 routerDefinition { get; set; }
        public string routersRendererIndex { get; set; }
        public string title { get; set; }
    }

    public class Routerdefinition1
    {
        public string appDefinitionId { get; set; }
        public string config { get; set; }
        public Pages1 pages { get; set; }
        public string prefix { get; set; }
        public string routerId { get; set; }
    }

    public class Pages1
    {
        public string _61ce7fc8fa5948088d63730c2e1dca33 { get; set; }
    }

    public class Mediarichtextinnercomponents
    {
    }

    public class Ssrspecific
    {
        public bool afterWixCode { get; set; }
        public Aspectscomponentstructures aspectsComponentStructures { get; set; }
        public object[] pendingBehaviours { get; set; }
        public Pendingruntimedalchange[] pendingRuntimeDalChanges { get; set; }
        public Runtime runtime { get; set; }
        public bool shouldRenderPage { get; set; }
    }

    public class Aspectscomponentstructures
    {
        public Tpaworker_7 tpaWorker_7 { get; set; }
    }

    public class Tpaworker_7
    {
        public Structure2 structure { get; set; }
    }

    public class Structure2
    {
        public string componentType { get; set; }
        public string id { get; set; }
        public string skin { get; set; }
        public string type { get; set; }
    }

    public class Runtime
    {
        public Components components { get; set; }
    }

    public class Components
    {
        public CompJiq6e6e63 compjiq6e6e6 { get; set; }
        public CompJiq6e6g83 compjiq6e6g8 { get; set; }
        public CompJj6xf07r2 compjj6xf07r { get; set; }
        public CompJj6xgzsd2 compjj6xgzsd { get; set; }
        public CompJj6xjv402 compjj6xjv40 { get; set; }
        public CompJj6xybvu2 compjj6xybvu { get; set; }
        public CompJj6xyumv2 compjj6xyumv { get; set; }
        public CompJj74jg7l2 compjj74jg7l { get; set; }
    }

    public class CompJiq6e6e63
    {
        public Overrides overrides { get; set; }
    }

    public class Overrides
    {
        public Design design { get; set; }
    }

    public class Design
    {
        public Background background { get; set; }
        public string charas { get; set; }
        public object[] dataChangeBehaviors { get; set; }
        public string id { get; set; }
        public Metadata395 metaData { get; set; }
        public string type { get; set; }
    }

    public class Background
    {
        public string alignType { get; set; }
        public string color { get; set; }
        public int colorOpacity { get; set; }
        public string colorOverlay { get; set; }
        public int colorOverlayOpacity { get; set; }
        public string fittingType { get; set; }
        public string id { get; set; }
        public Mediaref mediaRef { get; set; }
        public Metadata394 metaData { get; set; }
        public string scrollType { get; set; }
        public string showOverlayForMediaType { get; set; }
        public string type { get; set; }
    }

    public class Mediaref
    {
        public int height { get; set; }
        public string title { get; set; }
        public string type { get; set; }
        public string uri { get; set; }
        public int width { get; set; }
    }

    public class Metadata394
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Metadata395
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class CompJiq6e6g83
    {
        public Overrides1 overrides { get; set; }
    }

    public class Overrides1
    {
        public Design1 design { get; set; }
    }

    public class Design1
    {
        public Background1 background { get; set; }
        public string charas { get; set; }
        public object[] dataChangeBehaviors { get; set; }
        public string id { get; set; }
        public Metadata397 metaData { get; set; }
        public string type { get; set; }
    }

    public class Background1
    {
        public string alignType { get; set; }
        public string color { get; set; }
        public int colorOpacity { get; set; }
        public string colorOverlay { get; set; }
        public int colorOverlayOpacity { get; set; }
        public string fittingType { get; set; }
        public string id { get; set; }
        public Mediaref1 mediaRef { get; set; }
        public Metadata396 metaData { get; set; }
        public string scrollType { get; set; }
        public string showOverlayForMediaType { get; set; }
        public string type { get; set; }
    }

    public class Mediaref1
    {
        public int height { get; set; }
        public string title { get; set; }
        public string type { get; set; }
        public string uri { get; set; }
        public int width { get; set; }
    }

    public class Metadata396
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Metadata397
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class CompJj6xf07r2
    {
        public Overrides2 overrides { get; set; }
    }

    public class Overrides2
    {
        public Data3 data { get; set; }
    }

    public class Data3
    {
        public string id { get; set; }
        public object[] linkList { get; set; }
        public Metadata398 metaData { get; set; }
        public string stylesMapId { get; set; }
        public string text { get; set; }
        public string type { get; set; }
    }

    public class Metadata398
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class CompJj6xgzsd2
    {
        public Overrides3 overrides { get; set; }
    }

    public class Overrides3
    {
        public Data4 data { get; set; }
    }

    public class Data4
    {
        public string id { get; set; }
        public object[] linkList { get; set; }
        public Metadata399 metaData { get; set; }
        public string stylesMapId { get; set; }
        public string text { get; set; }
        public string type { get; set; }
    }

    public class Metadata399
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class CompJj6xjv402
    {
        public Overrides4 overrides { get; set; }
    }

    public class Overrides4
    {
        public Data5 data { get; set; }
    }

    public class Data5
    {
        public string id { get; set; }
        public string label { get; set; }
        public Link link { get; set; }
        public Metadata400 metaData { get; set; }
        public string type { get; set; }
    }

    public class Link
    {
        public string target { get; set; }
        public string type { get; set; }
        public string url { get; set; }
    }

    public class Metadata400
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class CompJj6xybvu2
    {
        public Overrides5 overrides { get; set; }
    }

    public class Overrides5
    {
        public Data6 data { get; set; }
    }

    public class Data6
    {
        public string id { get; set; }
        public object[] linkList { get; set; }
        public Metadata401 metaData { get; set; }
        public string stylesMapId { get; set; }
        public string text { get; set; }
        public string type { get; set; }
    }

    public class Metadata401
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class CompJj6xyumv2
    {
        public Overrides6 overrides { get; set; }
    }

    public class Overrides6
    {
        public Data7 data { get; set; }
    }

    public class Data7
    {
        public string id { get; set; }
        public object[] linkList { get; set; }
        public Metadata402 metaData { get; set; }
        public string stylesMapId { get; set; }
        public string text { get; set; }
        public string type { get; set; }
    }

    public class Metadata402
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class CompJj74jg7l2
    {
        public Overrides7 overrides { get; set; }
    }

    public class Overrides7
    {
        public Data8 data { get; set; }
    }

    public class Data8
    {
        public string alt { get; set; }
        public object crop { get; set; }
        public string description { get; set; }
        public int height { get; set; }
        public string id { get; set; }
        public Metadata403 metaData { get; set; }
        public string title { get; set; }
        public string type { get; set; }
        public string uri { get; set; }
        public int width { get; set; }
    }

    public class Metadata403
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Pendingruntimedalchange
    {
        public Changeobject changeObject { get; set; }
        public string compId { get; set; }
        public Databeforechange dataBeforeChange { get; set; }
    }

    public class Changeobject
    {
        public string type { get; set; }
        public Value value { get; set; }
    }

    public class Value
    {
        public Background2 background { get; set; }
        public string charas { get; set; }
        public object[] dataChangeBehaviors { get; set; }
        public string id { get; set; }
        public Metadata405 metaData { get; set; }
        public string type { get; set; }
        public object[] linkList { get; set; }
        public string stylesMapId { get; set; }
        public string text { get; set; }
        public string label { get; set; }
        public Link1 link { get; set; }
        public string alt { get; set; }
        public object crop { get; set; }
        public string description { get; set; }
        public int height { get; set; }
        public string title { get; set; }
        public string uri { get; set; }
        public int width { get; set; }
    }

    public class Background2
    {
        public string alignType { get; set; }
        public string color { get; set; }
        public int colorOpacity { get; set; }
        public string colorOverlay { get; set; }
        public int colorOverlayOpacity { get; set; }
        public string fittingType { get; set; }
        public string id { get; set; }
        public Mediaref2 mediaRef { get; set; }
        public Metadata404 metaData { get; set; }
        public string scrollType { get; set; }
        public string showOverlayForMediaType { get; set; }
        public string type { get; set; }
    }

    public class Mediaref2
    {
        public int height { get; set; }
        public string title { get; set; }
        public string type { get; set; }
        public string uri { get; set; }
        public int width { get; set; }
    }

    public class Metadata404
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Metadata405
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Link1
    {
        public string target { get; set; }
        public string type { get; set; }
        public string url { get; set; }
    }

    public class Databeforechange
    {
        public Background3 background { get; set; }
        public string charas { get; set; }
        public object[] dataChangeBehaviors { get; set; }
        public string id { get; set; }
        public Metadata408 metaData { get; set; }
        public string type { get; set; }
        public Linklist[] linkList { get; set; }
        public string stylesMapId { get; set; }
        public string text { get; set; }
        public string label { get; set; }
        public string alt { get; set; }
        public Crop1 crop { get; set; }
        public string description { get; set; }
        public int height { get; set; }
        public string title { get; set; }
        public string uri { get; set; }
        public int width { get; set; }
    }

    public class Background3
    {
        public string alignType { get; set; }
        public string color { get; set; }
        public int colorOpacity { get; set; }
        public string colorOverlay { get; set; }
        public int colorOverlayOpacity { get; set; }
        public string fittingType { get; set; }
        public string id { get; set; }
        public Mediaref3 mediaRef { get; set; }
        public Metadata407 metaData { get; set; }
        public string scrollType { get; set; }
        public string showOverlayForMediaType { get; set; }
        public string type { get; set; }
    }

    public class Mediaref3
    {
        public string alt { get; set; }
        public Artist2 artist { get; set; }
        public string description { get; set; }
        public int height { get; set; }
        public string id { get; set; }
        public Metadata406 metaData { get; set; }
        public string title { get; set; }
        public string type { get; set; }
        public string uri { get; set; }
        public int width { get; set; }
    }

    public class Artist2
    {
        public string id { get; set; }
        public string name { get; set; }
    }

    public class Metadata406
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Metadata407
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Metadata408
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Crop1
    {
        public int height { get; set; }
        public int width { get; set; }
        public int x { get; set; }
        public int y { get; set; }
    }

    public class Linklist
    {
        public string id { get; set; }
        public Metadata409 metaData { get; set; }
        public string recipient { get; set; }
        public string subject { get; set; }
        public string type { get; set; }
    }

    public class Metadata409
    {
        public bool isHidden { get; set; }
        public bool isPreset { get; set; }
        public string schemaVersion { get; set; }
    }

    public class Svgshapes
    {
    }

    public class Tpawidgenativeaspectwarmupdata
    {
    }

    public class Userwarmup
    {
        public DataitemJiq4yu0a1 dataItemjiq4yu0a { get; set; }
    }

    public class DataitemJiq4yu0a1
    {
        public Schemas1 schemas { get; set; }
        public Store store { get; set; }
    }

    public class Schemas1
    {
        public LesTraiteurs1 lestraiteurs { get; set; }
    }

    public class LesTraiteurs1
    {
        public string[] allowedOperations { get; set; }
        public string displayField { get; set; }
        public string displayName { get; set; }
        public object displayNamespace { get; set; }
        public Fields1 fields { get; set; }
        public string id { get; set; }
        public bool isDeleted { get; set; }
        public object _namespace { get; set; }
        public object ownerAppId { get; set; }
        public string storage { get; set; }
    }

    public class Fields1
    {
        public _Createddate2 _createdDate { get; set; }
        public _Id1 _id { get; set; }
        public _Owner1 _owner { get; set; }
        public _Updateddate2 _updatedDate { get; set; }
        public Adresse1 adresse { get; set; }
        public Contact1 contact { get; set; }
        public Contactcommercial1 contactCommercial { get; set; }
        public Dirigeant1 dirigeant { get; set; }
        public Imagedroite1 imageDroite { get; set; }
        public Imagegauche1 imageGauche { get; set; }
        public Liendusite1 lienDuSite { get; set; }
        public Liensite1 lienSite { get; set; }
        public Lieudintervention1 lieuDIntervention { get; set; }
        public Lieuintervention1 lieuIntervention { get; set; }
        public LinkLesTraiteursAll1 linklestraiteursall { get; set; }
        public LinkLesTraiteursTitle1 linklestraiteurstitle { get; set; }
        public Logo1 logo { get; set; }
        public Region1 region { get; set; }
        public Title2 title { get; set; }
    }

    public class _Createddate2
    {
        public string displayName { get; set; }
        public int index { get; set; }
        public bool isDeleted { get; set; }
        public bool sortable { get; set; }
        public bool systemField { get; set; }
        public string type { get; set; }
    }

    public class _Id1
    {
        public string displayName { get; set; }
        public int index { get; set; }
        public bool isDeleted { get; set; }
        public bool primaryKey { get; set; }
        public bool sortable { get; set; }
        public bool systemField { get; set; }
        public string type { get; set; }
    }

    public class _Owner1
    {
        public string displayName { get; set; }
        public int index { get; set; }
        public bool isDeleted { get; set; }
        public bool sortable { get; set; }
        public bool systemField { get; set; }
        public string type { get; set; }
    }

    public class _Updateddate2
    {
        public string displayName { get; set; }
        public int index { get; set; }
        public bool isDeleted { get; set; }
        public bool sortable { get; set; }
        public bool systemField { get; set; }
        public string type { get; set; }
    }

    public class Adresse1
    {
        public string displayName { get; set; }
        public int index { get; set; }
        public bool isDeleted { get; set; }
        public bool sortable { get; set; }
        public bool systemField { get; set; }
        public string type { get; set; }
    }

    public class Contact1
    {
        public string displayName { get; set; }
        public int index { get; set; }
        public bool isDeleted { get; set; }
        public string referencedCollection { get; set; }
        public bool sortable { get; set; }
        public bool systemField { get; set; }
        public string type { get; set; }
    }

    public class Contactcommercial1
    {
        public string displayName { get; set; }
        public int index { get; set; }
        public bool isDeleted { get; set; }
        public bool sortable { get; set; }
        public bool systemField { get; set; }
        public string type { get; set; }
    }

    public class Dirigeant1
    {
        public string displayName { get; set; }
        public int index { get; set; }
        public bool isDeleted { get; set; }
        public bool sortable { get; set; }
        public bool systemField { get; set; }
        public string type { get; set; }
    }

    public class Imagedroite1
    {
        public string displayName { get; set; }
        public int index { get; set; }
        public bool isDeleted { get; set; }
        public bool sortable { get; set; }
        public bool systemField { get; set; }
        public string type { get; set; }
    }

    public class Imagegauche1
    {
        public string displayName { get; set; }
        public int index { get; set; }
        public bool isDeleted { get; set; }
        public bool sortable { get; set; }
        public bool systemField { get; set; }
        public string type { get; set; }
    }

    public class Liendusite1
    {
        public string displayName { get; set; }
        public int index { get; set; }
        public bool isDeleted { get; set; }
        public bool sortable { get; set; }
        public bool systemField { get; set; }
        public string type { get; set; }
    }

    public class Liensite1
    {
        public string displayName { get; set; }
        public int index { get; set; }
        public bool isDeleted { get; set; }
        public bool sortable { get; set; }
        public bool systemField { get; set; }
        public string type { get; set; }
    }

    public class Lieudintervention1
    {
        public string displayName { get; set; }
        public int index { get; set; }
        public bool isDeleted { get; set; }
        public bool sortable { get; set; }
        public bool systemField { get; set; }
        public string type { get; set; }
    }

    public class Lieuintervention1
    {
        public string displayName { get; set; }
        public int index { get; set; }
        public bool isDeleted { get; set; }
        public bool sortable { get; set; }
        public bool systemField { get; set; }
        public string type { get; set; }
    }

    public class LinkLesTraiteursAll1
    {
        public Calculator2 calculator { get; set; }
        public string displayName { get; set; }
        public int index { get; set; }
        public bool isDeleted { get; set; }
        public string plugin { get; set; }
        public bool sortable { get; set; }
        public bool systemField { get; set; }
        public string type { get; set; }
    }

    public class Calculator2
    {
        public Config3 config { get; set; }
        public string id { get; set; }
    }

    public class Config3
    {
        public string pattern { get; set; }
    }

    public class LinkLesTraiteursTitle1
    {
        public Calculator3 calculator { get; set; }
        public string displayName { get; set; }
        public int index { get; set; }
        public bool isDeleted { get; set; }
        public string plugin { get; set; }
        public bool sortable { get; set; }
        public bool systemField { get; set; }
        public string type { get; set; }
    }

    public class Calculator3
    {
        public Config4 config { get; set; }
        public string id { get; set; }
    }

    public class Config4
    {
        public string pattern { get; set; }
    }

    public class Logo1
    {
        public string displayName { get; set; }
        public int index { get; set; }
        public bool isDeleted { get; set; }
        public bool sortable { get; set; }
        public bool systemField { get; set; }
        public string type { get; set; }
    }

    public class Region1
    {
        public string displayName { get; set; }
        public int index { get; set; }
        public bool isDeleted { get; set; }
        public bool sortable { get; set; }
        public bool systemField { get; set; }
        public string type { get; set; }
    }

    public class Title2
    {
        public string displayName { get; set; }
        public int index { get; set; }
        public bool isDeleted { get; set; }
        public bool sortable { get; set; }
        public bool systemField { get; set; }
        public string type { get; set; }
    }

    public class Store
    {
        public LesTraiteurs2 lestraiteurs { get; set; }
    }

    public class LesTraiteurs2
    {
        public Drafts drafts { get; set; }
        public Records records { get; set; }
        public Scopes scopes { get; set; }
    }

    public class Drafts
    {
    }

    public class Records
    {
        public D01f2349Fc2e4A5c96F5C5bc411d20cd d01f2349fc2e4a5c96f5c5bc411d20cd { get; set; }
    }

    public class D01f2349Fc2e4A5c96F5C5bc411d20cd
    {
        public _Createddate3 _createdDate { get; set; }
        public string _id { get; set; }
        public string _owner { get; set; }
        public _Updateddate3 _updatedDate { get; set; }
        public string adresse { get; set; }
        public string contactCommercial { get; set; }
        public string dirigeant { get; set; }
        public string imageDroite { get; set; }
        public string imageGauche { get; set; }
        public string lienSite { get; set; }
        public string lieuIntervention { get; set; }
        public string linklestraiteursall { get; set; }
        public string linklestraiteurstitle { get; set; }
        public string logo { get; set; }
        public string region { get; set; }
        public string title { get; set; }
    }

    public class _Createddate3
    {
        public DateTime WixCodeDate { get; set; }
    }

    public class _Updateddate3
    {
        public DateTime WixCodeDate { get; set; }
    }

    public class Scopes
    {
        public FilterAndTitleMatchesIgnorecaseTrueSpecTypeLiteralValueLarsTypeAnyofValueTypeLiteralValueTraiteurSort filterandtitlematchesignoreCasetruespectypeliteralvalueLarstypeanyOfvaluetypeliteralvalueTraiteursort { get; set; }
    }

    public class FilterAndTitleMatchesIgnorecaseTrueSpecTypeLiteralValueLarsTypeAnyofValueTypeLiteralValueTraiteurSort
    {
        public object[] newRecordMarkers { get; set; }
        public int numMatchingRecords { get; set; }
        public int numSeedRecords { get; set; }
        public string[] records { get; set; }
    }

    public class Wixapps
    {
        public Appbuilder appbuilder { get; set; }
    }

    public class Appbuilder
    {
        public Metadata410 metadata { get; set; }
    }

    public class Metadata410
    {
        public Appbuilder_Metadata appbuilder_metadata { get; set; }
    }

    public class Appbuilder_Metadata
    {
        public object[] requestedPartNames { get; set; }
    }

}
