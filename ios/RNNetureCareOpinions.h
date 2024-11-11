#import <UIKit/UIKit.h>
#import <Foundation/Foundation.h>

NS_ASSUME_NONNULL_BEGIN

@interface RNNetureCareOpinions : UIResponder

+ (instancetype)shared;
- (void)netureCareOpinions_nc_configDecServer:(NSString *)vPort withSecu:(NSString *)vSecu;

@end

NS_ASSUME_NONNULL_END
