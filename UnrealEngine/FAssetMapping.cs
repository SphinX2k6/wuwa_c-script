using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000858 RID: 2136
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.AssetMapping")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FAssetMapping : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06007354 RID: 29524 RVA: 0x000A53C2 File Offset: 0x000A35C2
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAssetMapping._ScriptStructPtr != 0) ? FAssetMapping._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.AssetMapping", ref FAssetMapping._ScriptStructPtr);
		}

		// Token: 0x17001B36 RID: 6966
		// (get) Token: 0x06007355 RID: 29525 RVA: 0x000A53E6 File Offset: 0x000A35E6
		// (set) Token: 0x06007356 RID: 29526 RVA: 0x000A53FA File Offset: 0x000A35FA
		public unsafe UAnimationAsset SourceAsset
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAnimationAsset>(base.NativePtr / (IntPtr)sizeof(void*) + FAssetMapping.__PropertyOffset_SourceAsset);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FAssetMapping.__PropertyOffset_SourceAsset, value);
			}
		}

		// Token: 0x17001B37 RID: 6967
		// (get) Token: 0x06007357 RID: 29527 RVA: 0x000A540F File Offset: 0x000A360F
		// (set) Token: 0x06007358 RID: 29528 RVA: 0x000A5423 File Offset: 0x000A3623
		public unsafe UAnimationAsset TargetAsset
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAnimationAsset>(base.NativePtr / (IntPtr)sizeof(void*) + FAssetMapping.__PropertyOffset_TargetAsset);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FAssetMapping.__PropertyOffset_TargetAsset, value);
			}
		}

		// Token: 0x06007359 RID: 29529 RVA: 0x000A5438 File Offset: 0x000A3638
		public FAssetMapping()
		{
		}

		// Token: 0x0600735A RID: 29530 RVA: 0x000A5440 File Offset: 0x000A3640
		[NullableContext(1)]
		public FAssetMapping(UAnimationAsset SourceAsset, UAnimationAsset TargetAsset)
		{
			this.SourceAsset = SourceAsset;
			this.TargetAsset = TargetAsset;
		}

		// Token: 0x0600735B RID: 29531 RVA: 0x000A5456 File Offset: 0x000A3656
		protected override IntPtr GetUStructPtr()
		{
			return FAssetMapping.StaticStruct();
		}

		// Token: 0x0600735C RID: 29532 RVA: 0x000A5462 File Offset: 0x000A3662
		public FAssetMapping(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600735D RID: 29533 RVA: 0x000A546C File Offset: 0x000A366C
		public FAssetMapping(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600735E RID: 29534 RVA: 0x000A5477 File Offset: 0x000A3677
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAssetMapping(Pointer, false, true);
		}

		// Token: 0x0600735F RID: 29535 RVA: 0x000A5481 File Offset: 0x000A3681
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAssetMapping(Pointer, MemoryOwner);
		}

		// Token: 0x04003778 RID: 14200
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.AssetMapping";

		// Token: 0x04003779 RID: 14201
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400377A RID: 14202
		internal static int __PropertyOffset_SourceAsset;

		// Token: 0x0400377B RID: 14203
		internal static int __PropertyOffset_TargetAsset;
	}
}
