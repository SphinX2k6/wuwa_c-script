using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001F78 RID: 8056
	[UnrealObjectPath("/Script/Landscape.LandscapeInfoLayerSettings")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FLandscapeInfoLayerSettings : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601E918 RID: 125208 RVA: 0x002D6E8A File Offset: 0x002D508A
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FLandscapeInfoLayerSettings._ScriptStructPtr != 0) ? FLandscapeInfoLayerSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Landscape.LandscapeInfoLayerSettings", ref FLandscapeInfoLayerSettings._ScriptStructPtr);
		}

		// Token: 0x170079A3 RID: 31139
		// (get) Token: 0x0601E919 RID: 125209 RVA: 0x002D6EAE File Offset: 0x002D50AE
		// (set) Token: 0x0601E91A RID: 125210 RVA: 0x002D6EC2 File Offset: 0x002D50C2
		[Nullable(2)]
		public unsafe ULandscapeLayerInfoObject LayerInfoObj
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ULandscapeLayerInfoObject>(base.NativePtr / (IntPtr)sizeof(void*) + FLandscapeInfoLayerSettings.__PropertyOffset_LayerInfoObj);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FLandscapeInfoLayerSettings.__PropertyOffset_LayerInfoObj, value);
			}
		}

		// Token: 0x170079A4 RID: 31140
		// (get) Token: 0x0601E91B RID: 125211 RVA: 0x002D6ED7 File Offset: 0x002D50D7
		// (set) Token: 0x0601E91C RID: 125212 RVA: 0x002D6EEB File Offset: 0x002D50EB
		public unsafe FName LayerName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLandscapeInfoLayerSettings.__PropertyOffset_LayerName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLandscapeInfoLayerSettings.__PropertyOffset_LayerName) = value;
			}
		}

		// Token: 0x0601E91D RID: 125213 RVA: 0x002D6F00 File Offset: 0x002D5100
		public FLandscapeInfoLayerSettings()
		{
		}

		// Token: 0x0601E91E RID: 125214 RVA: 0x002D6F08 File Offset: 0x002D5108
		[NullableContext(1)]
		public FLandscapeInfoLayerSettings(ULandscapeLayerInfoObject LayerInfoObj, FName LayerName, UMaterialInstanceConstant ThumbnailMIC, ALandscapeProxy Owner, int DebugColorChannel, bool bValid)
		{
			this.LayerInfoObj = LayerInfoObj;
			this.LayerName = LayerName;
		}

		// Token: 0x0601E91F RID: 125215 RVA: 0x002D6F1E File Offset: 0x002D511E
		protected override IntPtr GetUStructPtr()
		{
			return FLandscapeInfoLayerSettings.StaticStruct();
		}

		// Token: 0x0601E920 RID: 125216 RVA: 0x002D6F2A File Offset: 0x002D512A
		[NullableContext(2)]
		public FLandscapeInfoLayerSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601E921 RID: 125217 RVA: 0x002D6F34 File Offset: 0x002D5134
		public FLandscapeInfoLayerSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601E922 RID: 125218 RVA: 0x002D6F3F File Offset: 0x002D513F
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FLandscapeInfoLayerSettings(Pointer, false, true);
		}

		// Token: 0x0601E923 RID: 125219 RVA: 0x002D6F49 File Offset: 0x002D5149
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FLandscapeInfoLayerSettings(Pointer, MemoryOwner);
		}

		// Token: 0x04010853 RID: 67667
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Landscape.LandscapeInfoLayerSettings";

		// Token: 0x04010854 RID: 67668
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04010855 RID: 67669
		internal static int __PropertyOffset_LayerInfoObj;

		// Token: 0x04010856 RID: 67670
		internal static int __PropertyOffset_LayerName;
	}
}
