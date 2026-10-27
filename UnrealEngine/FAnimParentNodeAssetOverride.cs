using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000835 RID: 2101
	[UnrealObjectPath("/Script/Engine.AnimParentNodeAssetOverride")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FAnimParentNodeAssetOverride : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06007105 RID: 28933 RVA: 0x000A20AE File Offset: 0x000A02AE
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAnimParentNodeAssetOverride._ScriptStructPtr != 0) ? FAnimParentNodeAssetOverride._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.AnimParentNodeAssetOverride", ref FAnimParentNodeAssetOverride._ScriptStructPtr);
		}

		// Token: 0x17001A97 RID: 6807
		// (get) Token: 0x06007106 RID: 28934 RVA: 0x000A20D2 File Offset: 0x000A02D2
		// (set) Token: 0x06007107 RID: 28935 RVA: 0x000A20E6 File Offset: 0x000A02E6
		[Nullable(2)]
		public unsafe UAnimationAsset NewAsset
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAnimationAsset>(base.NativePtr / (IntPtr)sizeof(void*) + FAnimParentNodeAssetOverride.__PropertyOffset_NewAsset);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FAnimParentNodeAssetOverride.__PropertyOffset_NewAsset, value);
			}
		}

		// Token: 0x17001A98 RID: 6808
		// (get) Token: 0x06007108 RID: 28936 RVA: 0x000A20FB File Offset: 0x000A02FB
		// (set) Token: 0x06007109 RID: 28937 RVA: 0x000A210F File Offset: 0x000A030F
		public unsafe FGuid ParentNodeGuid
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimParentNodeAssetOverride.__PropertyOffset_ParentNodeGuid);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimParentNodeAssetOverride.__PropertyOffset_ParentNodeGuid) = value;
			}
		}

		// Token: 0x0600710A RID: 28938 RVA: 0x000A2124 File Offset: 0x000A0324
		public FAnimParentNodeAssetOverride()
		{
		}

		// Token: 0x0600710B RID: 28939 RVA: 0x000A212C File Offset: 0x000A032C
		[NullableContext(1)]
		public FAnimParentNodeAssetOverride(UAnimationAsset NewAsset, FGuid ParentNodeGuid)
		{
			this.NewAsset = NewAsset;
			this.ParentNodeGuid = ParentNodeGuid;
		}

		// Token: 0x0600710C RID: 28940 RVA: 0x000A2142 File Offset: 0x000A0342
		protected override IntPtr GetUStructPtr()
		{
			return FAnimParentNodeAssetOverride.StaticStruct();
		}

		// Token: 0x0600710D RID: 28941 RVA: 0x000A214E File Offset: 0x000A034E
		[NullableContext(2)]
		public FAnimParentNodeAssetOverride(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600710E RID: 28942 RVA: 0x000A2158 File Offset: 0x000A0358
		public FAnimParentNodeAssetOverride(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600710F RID: 28943 RVA: 0x000A2163 File Offset: 0x000A0363
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAnimParentNodeAssetOverride(Pointer, false, true);
		}

		// Token: 0x06007110 RID: 28944 RVA: 0x000A216D File Offset: 0x000A036D
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAnimParentNodeAssetOverride(Pointer, MemoryOwner);
		}

		// Token: 0x04003644 RID: 13892
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.AnimParentNodeAssetOverride";

		// Token: 0x04003645 RID: 13893
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04003646 RID: 13894
		internal static int __PropertyOffset_NewAsset;

		// Token: 0x04003647 RID: 13895
		internal static int __PropertyOffset_ParentNodeGuid;
	}
}
