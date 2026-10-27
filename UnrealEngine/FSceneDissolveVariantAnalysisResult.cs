using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001938 RID: 6456
	[UnrealObjectPath("/Script/KuroGameplay.SceneDissolveVariantAnalysisResult")]
	[UnrealStructLayout(20, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 20)]
	public class FSceneDissolveVariantAnalysisResult : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06017F05 RID: 98053 RVA: 0x00231387 File Offset: 0x0022F587
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSceneDissolveVariantAnalysisResult._ScriptStructPtr != 0) ? FSceneDissolveVariantAnalysisResult._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroGameplay.SceneDissolveVariantAnalysisResult", ref FSceneDissolveVariantAnalysisResult._ScriptStructPtr);
		}

		// Token: 0x17006003 RID: 24579
		// (get) Token: 0x06017F06 RID: 98054 RVA: 0x002313AB File Offset: 0x0022F5AB
		// (set) Token: 0x06017F07 RID: 98055 RVA: 0x002313BB File Offset: 0x0022F5BB
		public unsafe int MaterialInstanceCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSceneDissolveVariantAnalysisResult.__PropertyOffset_MaterialInstanceCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSceneDissolveVariantAnalysisResult.__PropertyOffset_MaterialInstanceCount) = value;
			}
		}

		// Token: 0x17006004 RID: 24580
		// (get) Token: 0x06017F08 RID: 98056 RVA: 0x002313CC File Offset: 0x0022F5CC
		// (set) Token: 0x06017F09 RID: 98057 RVA: 0x002313DC File Offset: 0x0022F5DC
		public unsafe int SceneDissolveEnabledCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSceneDissolveVariantAnalysisResult.__PropertyOffset_SceneDissolveEnabledCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSceneDissolveVariantAnalysisResult.__PropertyOffset_SceneDissolveEnabledCount) = value;
			}
		}

		// Token: 0x17006005 RID: 24581
		// (get) Token: 0x06017F0A RID: 98058 RVA: 0x002313ED File Offset: 0x0022F5ED
		// (set) Token: 0x06017F0B RID: 98059 RVA: 0x002313FD File Offset: 0x0022F5FD
		public unsafe int SceneDissolveDisabledCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSceneDissolveVariantAnalysisResult.__PropertyOffset_SceneDissolveDisabledCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSceneDissolveVariantAnalysisResult.__PropertyOffset_SceneDissolveDisabledCount) = value;
			}
		}

		// Token: 0x17006006 RID: 24582
		// (get) Token: 0x06017F0C RID: 98060 RVA: 0x0023140E File Offset: 0x0022F60E
		// (set) Token: 0x06017F0D RID: 98061 RVA: 0x0023141E File Offset: 0x0022F61E
		public unsafe int UniqueShaderMapIdCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSceneDissolveVariantAnalysisResult.__PropertyOffset_UniqueShaderMapIdCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSceneDissolveVariantAnalysisResult.__PropertyOffset_UniqueShaderMapIdCount) = value;
			}
		}

		// Token: 0x17006007 RID: 24583
		// (get) Token: 0x06017F0E RID: 98062 RVA: 0x0023142F File Offset: 0x0022F62F
		// (set) Token: 0x06017F0F RID: 98063 RVA: 0x0023143F File Offset: 0x0022F63F
		public unsafe int TotalPermutationEntryCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSceneDissolveVariantAnalysisResult.__PropertyOffset_TotalPermutationEntryCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSceneDissolveVariantAnalysisResult.__PropertyOffset_TotalPermutationEntryCount) = value;
			}
		}

		// Token: 0x06017F10 RID: 98064 RVA: 0x00231450 File Offset: 0x0022F650
		public FSceneDissolveVariantAnalysisResult()
		{
		}

		// Token: 0x06017F11 RID: 98065 RVA: 0x00231458 File Offset: 0x0022F658
		public FSceneDissolveVariantAnalysisResult(int MaterialInstanceCount, int SceneDissolveEnabledCount, int SceneDissolveDisabledCount, int UniqueShaderMapIdCount, int TotalPermutationEntryCount)
		{
			this.MaterialInstanceCount = MaterialInstanceCount;
			this.SceneDissolveEnabledCount = SceneDissolveEnabledCount;
			this.SceneDissolveDisabledCount = SceneDissolveDisabledCount;
			this.UniqueShaderMapIdCount = UniqueShaderMapIdCount;
			this.TotalPermutationEntryCount = TotalPermutationEntryCount;
		}

		// Token: 0x06017F12 RID: 98066 RVA: 0x00231485 File Offset: 0x0022F685
		protected override IntPtr GetUStructPtr()
		{
			return FSceneDissolveVariantAnalysisResult.StaticStruct();
		}

		// Token: 0x06017F13 RID: 98067 RVA: 0x00231491 File Offset: 0x0022F691
		[NullableContext(2)]
		public FSceneDissolveVariantAnalysisResult(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06017F14 RID: 98068 RVA: 0x0023149B File Offset: 0x0022F69B
		public FSceneDissolveVariantAnalysisResult(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06017F15 RID: 98069 RVA: 0x002314A6 File Offset: 0x0022F6A6
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSceneDissolveVariantAnalysisResult(Pointer, false, true);
		}

		// Token: 0x06017F16 RID: 98070 RVA: 0x002314B0 File Offset: 0x0022F6B0
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSceneDissolveVariantAnalysisResult(Pointer, MemoryOwner);
		}

		// Token: 0x0400CF4C RID: 53068
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroGameplay.SceneDissolveVariantAnalysisResult";

		// Token: 0x0400CF4D RID: 53069
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400CF4E RID: 53070
		internal static int __PropertyOffset_MaterialInstanceCount;

		// Token: 0x0400CF4F RID: 53071
		internal static int __PropertyOffset_SceneDissolveEnabledCount;

		// Token: 0x0400CF50 RID: 53072
		internal static int __PropertyOffset_SceneDissolveDisabledCount;

		// Token: 0x0400CF51 RID: 53073
		internal static int __PropertyOffset_UniqueShaderMapIdCount;

		// Token: 0x0400CF52 RID: 53074
		internal static int __PropertyOffset_TotalPermutationEntryCount;
	}
}
