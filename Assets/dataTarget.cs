using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Vuforia;

public class dataTarget : MonoBehaviour
{
    public Transform TextTargetName;
    public Transform TextDescription;
    public Transform PanelDescription;

    void Update()
    {
        StateManager sm = TrackerManager.Instance.GetStateManager();
        IEnumerable<TrackableBehaviour> tbs = sm.GetActiveTrackableBehaviours();

        foreach (TrackableBehaviour tb in tbs)
        {
            string name = tb.TrackableName;
            ImageTarget it = tb.Trackable as ImageTarget;
            Vector2 size = it.GetSize();

            Debug.Log("Active image target:" + name + "  -size: " + size.x + ", " + size.y);

            TextTargetName.GetComponent<Text>().text = name;
            TextDescription.gameObject.SetActive(true);
            PanelDescription.gameObject.SetActive(true);

            //1. Carrot
            if (name == "Seed_Carrot")
            {
                TextDescription.GetComponent<Text>().text = "\t\tCARROT" + "\n"+
                    ">Scientific Name: Daucus carota" + "\n" +
                    ">Family: Apiaceae" + "\n" +
                    ">Cultivation: Carrots are grown from seed and can take up to four months (120 days) to mature, but most cultivars mature within 70 to 80 days under the right conditions. They grow best in full sun but tolerate some shade. The optimum temperature is 16 to 21 °C (61 to 70 °F). The ideal soil is deep, loose and well-drained, sandy or loamy, with a pH of 6.3 to 6.8";
            }
            //2. Cucumber
            if (name == "Seed_cucumber")
            {
                TextDescription.GetComponent<Text>().text = "\t\tCUCUMBER" + "\n" +
                    ">Scientific Name: Cucumis sativus" + "\n" +
                    ">Family: Cucurbitacea" + "\n" +
                    ">Cultivation: The cucumber originated in India, where a great many varieties have been observed, from Cucumis hystrix. It has been cultivated for at least 3,000 years, and was probably introduced to other parts of Europe by the Greeks or Romans. Records of cucumber cultivation appear in France in the 9th century, England in the 14th century, and in North America by the mid-16th century.";
            }
            //3. Garlic
            if (name == "Seed_Garlic")
            {
                TextDescription.GetComponent<Text>().text = "\t\tGARLIC" + "\n" +
                    ">Scientific Name: Allium sativum" + "\n" +
                    ">Family: Alliacea" + "\n" +
                    ">Cultivation: Garlic is easy to grow and can be grown year-round in mild climates. While sexual propagation of garlic is possible, nearly all of the garlic in cultivation is propagated asexually, by planting individual cloves in the ground. In colder climates, cloves are best planted about six weeks before the soil freezes. The goal is to only have the bulbs produce roots and no shoots above the ground. Harvest is in late spring or early summer.";
            }
            //4. Mushroom
            if (name == "Seed_mushroom")
            {
                TextDescription.GetComponent<Text>().text = "\t\tMUSHROOM" + "\n" +
                     ">Scientific Name: Agaricus bisporus" + "\n" +
                     ">Family: Boletaceae" + "\n" +
                     ">Cultivation: Mushrooms grow on compost. The compost is produced at specialized companies. From the moment the raw materials are mixed, up to delivery of the compost to the mushroom farms. The process takes four to six weeks, depends depending on the raw materials and the system used at the Compost yard.";
            }
            //5. Okra
            if (name == "Seed_Okra")
            {
                TextDescription.GetComponent<Text>().text = "\t\tOKRA" + "\n" +
                     ">Scientific Name: Abelmoschus esculentus" + "\n" +
                     ">Family: Malvaceae" + "\n" +
                     ">Cultivation: Abelmoschus esculentus or Okra is cultivated throughout the tropical and warm temperate regions of the world for its fibrous fruits or pods containing round, white seeds. It is among the most heat- and drought-tolerant vegetable species in the world and will tolerate soils with heavy clay and intermittent moisture, but frost can damage the pods. In cultivation, the seeds are soaked overnight prior to planting to a depth of 1–2 centimetres (0.39–0.79 in).";
            }
            //6. Onion
            if (name == "Seed_Onion")
            {
                TextDescription.GetComponent<Text>().text = "\t\tONION" + "\n" +
                     ">Scientific Name: Allium sativum" + "\n" +
                     ">Family: Alliacea" + "\n" +
                     ">Cultivation: Garlic is easy to grow and can be grown year-round in mild climates. While sexual propagation of garlic is possible, nearly all of the garlic in cultivation is propagated asexually, by planting individual cloves in the ground. In colder climates, cloves are best planted about six weeks before the soil freezes. The goal is to only have the bulbs produce roots and no shoots above the ground. Harvest is in late spring or early summer.";
            }
            //7. Radish
            if (name == "Seed_Radish")
            {
                TextDescription.GetComponent<Text>().text = "\t\tRADISH" + "\n" +
                     ">Scientific Name: Raphanus sativus" + "\n" +
                     ">Family: Brassicaceae" + "\n" +
                     ">Cultivation: Radishes are a fast-growing, annual, cool-season crop. The seed germinates in three to four days in moist conditions with soil temperatures between 65 and 85 °F (18 and 29 °C). Best quality roots are obtained under moderate day lengths with air temperatures in the range 50 to 65 °F (10 to 18 °C). Under average conditions, the crop matures in 3–4 weeks, but in colder weather, 6–7 weeks may be required.";
            }
            //8. Sweet_corn
            if (name == "Seed_Sweet_corn")
            {
                TextDescription.GetComponent<Text>().text = "\t\tSWEET CORN" + "\n" +
                     ">Scientific Name: Zea mays (Saccharata group)" + "\n" +
                     ">Family: Poaceae" + "\n" +
                     ">Cultivation: Maize or Corn was planted by the Native Americans in hills, in a complex system known to some as the Three Sisters. Maize provided support for beans, and the beans provided nitrogen derived from nitrogen-fixing rhizobia bacteria which live on the roots of beans and other legumes; and squashes provided ground cover to stop weeds and inhibit evaporation by providing shade over the soil. This method was replaced by single species hill planting where each hill 60–120 cm (2.0–3.9 ft) apart was planted with three or four seeds, a method still used by home gardeners.";
            }
            //9. Tomato
            if (name == "Seed_Tomato")
            {
                TextDescription.GetComponent<Text>().text = "\t\tTOMATO" + "\n" +
                     ">Scientific Name: Solanum lycopersicum" + "\n" +
                     ">Family: Solanaceae" + "\n" +
                     ">Cultivation: The tomato is grown worldwide for its edible fruits, with thousands of cultivars. A fertilizer with an NPK ratio of 5–10–10 is often sold as tomato fertilizer or vegetable fertilizer, although manure and compost are also used..";
            }
            //10. Watermelon
            if (name == "Seed_Watermelon")
            {
                TextDescription.GetComponent<Text>().text = "\t\tWATERMELON" + "\n" +
                     ">Scientific Name: Citrullus lanatus" + "\n" +
                     ">Family: Cucurbitaceae" + "\n" +
                     ">Cultivation: Watermelons are tropical or subtropical plants and need temperatures higher than about 25 °C (77 °F) to thrive. On a garden scale, seeds are usually sown in pots under cover and transplanted into well-drained sandy loam with a pH between 5.5 and 7, and medium levels of nitrogen.";
            }
        }
    }
}
  
