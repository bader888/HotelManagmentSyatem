CREATE PROCEDURE sp_GetAllCountries 
                    AS
                    BEGIN
                    SELECT * FROM Countries;
                    END 
					
					
					create PROCEDURE sp_FindCountryByID 
                        @CountryID int 
                        as 
                        begin 
                          select * from Countries where CountryID = @CountryID ;
                        end
                        

							
					create PROCEDURE sp_FindCountryByName
                        @CountryName int 
                        as 
                        begin 
                          select * from Countries where CountryName = @CountryName ;
                        end