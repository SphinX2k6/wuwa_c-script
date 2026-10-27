using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001F7B RID: 8059
	[UnrealObjectPath("/Script/Landscape.LandscapeLayerBrush")]
	[UnrealStructLayout(80, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 80)]
	public class FLandscapeLayerBrush : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601E943 RID: 125251 RVA: 0x002D7234 File Offset: 0x002D5434
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FLandscapeLayerBrush._ScriptStructPtr != 0) ? FLandscapeLayerBrush._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Landscape.LandscapeLayerBrush", ref FLandscapeLayerBrush._ScriptStructPtr);
		}

		// Token: 0x0601E944 RID: 125252 RVA: 0x002D7258 File Offset: 0x002D5458
		public FLandscapeLayerBrush()
		{
		}

		// Token: 0x0601E945 RID: 125253 RVA: 0x002D7260 File Offset: 0x002D5460
		[NullableContext(1)]
		public FLandscapeLayerBrush(ALandscapeBlueprintBrushBase BlueprintBrush)
		{
		}

		// Token: 0x0601E946 RID: 125254 RVA: 0x002D7268 File Offset: 0x002D5468
		protected override IntPtr GetUStructPtr()
		{
			return FLandscapeLayerBrush.StaticStruct();
		}

		// Token: 0x0601E947 RID: 125255 RVA: 0x002D7274 File Offset: 0x002D5474
		[NullableContext(2)]
		public FLandscapeLayerBrush(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601E948 RID: 125256 RVA: 0x002D727E File Offset: 0x002D547E
		public FLandscapeLayerBrush(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601E949 RID: 125257 RVA: 0x002D7289 File Offset: 0x002D5489
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FLandscapeLayerBrush(Pointer, false, true);
		}

		// Token: 0x0601E94A RID: 125258 RVA: 0x002D7293 File Offset: 0x002D5493
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FLandscapeLayerBrush(Pointer, MemoryOwner);
		}

		// Token: 0x04010867 RID: 67687
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Landscape.LandscapeLayerBrush";

		// Token: 0x04010868 RID: 67688
		private static IntPtr _ScriptStructPtr;
	}
}
