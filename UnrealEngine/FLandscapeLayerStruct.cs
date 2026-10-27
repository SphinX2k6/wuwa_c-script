using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001F7E RID: 8062
	[UnrealObjectPath("/Script/Landscape.LandscapeLayerStruct")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FLandscapeLayerStruct : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601E964 RID: 125284 RVA: 0x002D74F6 File Offset: 0x002D56F6
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FLandscapeLayerStruct._ScriptStructPtr != 0) ? FLandscapeLayerStruct._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Landscape.LandscapeLayerStruct", ref FLandscapeLayerStruct._ScriptStructPtr);
		}

		// Token: 0x170079B4 RID: 31156
		// (get) Token: 0x0601E965 RID: 125285 RVA: 0x002D751A File Offset: 0x002D571A
		// (set) Token: 0x0601E966 RID: 125286 RVA: 0x002D752E File Offset: 0x002D572E
		[Nullable(2)]
		public unsafe ULandscapeLayerInfoObject LayerInfoObj
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ULandscapeLayerInfoObject>(base.NativePtr / (IntPtr)sizeof(void*) + FLandscapeLayerStruct.__PropertyOffset_LayerInfoObj);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FLandscapeLayerStruct.__PropertyOffset_LayerInfoObj, value);
			}
		}

		// Token: 0x0601E967 RID: 125287 RVA: 0x002D7543 File Offset: 0x002D5743
		public FLandscapeLayerStruct()
		{
		}

		// Token: 0x0601E968 RID: 125288 RVA: 0x002D754B File Offset: 0x002D574B
		[NullableContext(1)]
		public FLandscapeLayerStruct(ULandscapeLayerInfoObject LayerInfoObj, ULandscapeMaterialInstanceConstant ThumbnailMIC, ALandscapeProxy Owner, int DebugColorChannel, bool bSelected, string SourceFilePath)
		{
			this.LayerInfoObj = LayerInfoObj;
		}

		// Token: 0x0601E969 RID: 125289 RVA: 0x002D755A File Offset: 0x002D575A
		protected override IntPtr GetUStructPtr()
		{
			return FLandscapeLayerStruct.StaticStruct();
		}

		// Token: 0x0601E96A RID: 125290 RVA: 0x002D7566 File Offset: 0x002D5766
		[NullableContext(2)]
		public FLandscapeLayerStruct(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601E96B RID: 125291 RVA: 0x002D7570 File Offset: 0x002D5770
		public FLandscapeLayerStruct(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601E96C RID: 125292 RVA: 0x002D757B File Offset: 0x002D577B
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FLandscapeLayerStruct(Pointer, false, true);
		}

		// Token: 0x0601E96D RID: 125293 RVA: 0x002D7585 File Offset: 0x002D5785
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FLandscapeLayerStruct(Pointer, MemoryOwner);
		}

		// Token: 0x04010876 RID: 67702
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Landscape.LandscapeLayerStruct";

		// Token: 0x04010877 RID: 67703
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04010878 RID: 67704
		internal static int __PropertyOffset_LayerInfoObj;
	}
}
