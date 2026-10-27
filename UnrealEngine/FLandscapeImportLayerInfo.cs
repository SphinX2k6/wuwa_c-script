using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001F76 RID: 8054
	[UnrealObjectPath("/Script/Landscape.LandscapeImportLayerInfo")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 56)]
	public class FLandscapeImportLayerInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601E8FD RID: 125181 RVA: 0x002D6C7A File Offset: 0x002D4E7A
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FLandscapeImportLayerInfo._ScriptStructPtr != 0) ? FLandscapeImportLayerInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Landscape.LandscapeImportLayerInfo", ref FLandscapeImportLayerInfo._ScriptStructPtr);
		}

		// Token: 0x0601E8FE RID: 125182 RVA: 0x002D6C9E File Offset: 0x002D4E9E
		public FLandscapeImportLayerInfo()
		{
		}

		// Token: 0x0601E8FF RID: 125183 RVA: 0x002D6CA6 File Offset: 0x002D4EA6
		[NullableContext(1)]
		public FLandscapeImportLayerInfo(FName LayerName, ULandscapeLayerInfoObject LayerInfo, string SourceFilePath)
		{
		}

		// Token: 0x0601E900 RID: 125184 RVA: 0x002D6CAE File Offset: 0x002D4EAE
		protected override IntPtr GetUStructPtr()
		{
			return FLandscapeImportLayerInfo.StaticStruct();
		}

		// Token: 0x0601E901 RID: 125185 RVA: 0x002D6CBA File Offset: 0x002D4EBA
		[NullableContext(2)]
		public FLandscapeImportLayerInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601E902 RID: 125186 RVA: 0x002D6CC4 File Offset: 0x002D4EC4
		public FLandscapeImportLayerInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601E903 RID: 125187 RVA: 0x002D6CCF File Offset: 0x002D4ECF
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FLandscapeImportLayerInfo(Pointer, false, true);
		}

		// Token: 0x0601E904 RID: 125188 RVA: 0x002D6CD9 File Offset: 0x002D4ED9
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FLandscapeImportLayerInfo(Pointer, MemoryOwner);
		}

		// Token: 0x04010846 RID: 67654
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Landscape.LandscapeImportLayerInfo";

		// Token: 0x04010847 RID: 67655
		private static IntPtr _ScriptStructPtr;
	}
}
