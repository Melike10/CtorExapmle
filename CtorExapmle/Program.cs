using CtorExapmle;

// call First object using default ctor
Baby baby1 = new Baby();
baby1.FirstName = "Hürreycan";
baby1.LastName = "Sezgin";
baby1.IntroduceBaby();

// call second object using ctor with parameters
Baby baby2 = new Baby("İpek","Nalburcuoğlu");
baby2.IntroduceBaby();

