#include "OffAxisLocalPlayer.h"
#include "PerspectiveMatrix.h"


FSceneView * UOffAxisLocalPlayer::CalcSceneView(FSceneViewFamily * ViewFamily, FVector & OutViewLocation, FRotator & OutViewRotation, FViewport * Viewport, FViewElementDrawer * ViewDrawer, EStereoscopicPass StereoPass)
{

	FSceneView* View = ULocalPlayer::CalcSceneView(ViewFamily, OutViewLocation, OutViewRotation, Viewport, ViewDrawer, StereoPass);

	if (View)
	{
		FMatrix CurrentMatrix = View->ViewMatrices.GetProjectionMatrix();

		float FOV = FMath::DegreesToRadians(60.0f);
		FMatrix ProjectionMatrix = FReversedZPerspectiveMatrix(FOV, 16.0f, 9.0f, GNearClippingPlane);

		View->UpdateProjectionMatrix(ProjectionMatrix);
	}

	return View;
}
