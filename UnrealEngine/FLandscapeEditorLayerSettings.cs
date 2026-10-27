using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001F6F RID: 8047
	[UnrealObjectPath("/Script/Landscape.LandscapeEditorLayerSettings")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FLandscapeEditorLayerSettings : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601E897 RID: 125079 RVA: 0x002D63A7 File Offset: 0x002D45A7
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FLandscapeEditorLayerSettings._ScriptStructPtr != 0) ? FLandscapeEditorLayerSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Landscape.LandscapeEditorLayerSettings", ref FLandscapeEditorLayerSettings._ScriptStructPtr);
		}

		// Token: 0x0601E898 RID: 125080 RVA: 0x002D63CB File Offset: 0x002D45CB
		public FLandscapeEditorLayerSettings()
		{
		}

		// Token: 0x0601E899 RID: 125081 RVA: 0x002D63D3 File Offset: 0x002D45D3
		[NullableContext(1)]
		public FLandscapeEditorLayerSettings(ULandscapeLayerInfoObject LayerInfoObj, string ReimportLayerFilePath)
		{
		}

		// Token: 0x0601E89A RID: 125082 RVA: 0x002D63DB File Offset: 0x002D45DB
		protected override IntPtr GetUStructPtr()
		{
			return FLandscapeEditorLayerSettings.StaticStruct();
		}

		// Token: 0x0601E89B RID: 125083 RVA: 0x002D63E7 File Offset: 0x002D45E7
		[NullableContext(2)]
		public FLandscapeEditorLayerSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601E89C RID: 125084 RVA: 0x002D63F1 File Offset: 0x002D45F1
		public FLandscapeEditorLayerSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601E89D RID: 125085 RVA: 0x002D63FC File Offset: 0x002D45FC
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FLandscapeEditorLayerSettings(Pointer, false, true);
		}

		// Token: 0x0601E89E RID: 125086 RVA: 0x002D6406 File Offset: 0x002D4606
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FLandscapeEditorLayerSettings(Pointer, MemoryOwner);
		}

		// Token: 0x0401080F RID: 67599
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Landscape.LandscapeEditorLayerSettings";

		// Token: 0x04010810 RID: 67600
		private static IntPtr _ScriptStructPtr;
	}
}
