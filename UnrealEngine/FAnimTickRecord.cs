using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000849 RID: 2121
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.AnimTickRecord")]
	[UnrealStructLayout(128, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 128)]
	public class FAnimTickRecord : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06007241 RID: 29249 RVA: 0x000A38BF File Offset: 0x000A1ABF
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAnimTickRecord._ScriptStructPtr != 0) ? FAnimTickRecord._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.AnimTickRecord", ref FAnimTickRecord._ScriptStructPtr);
		}

		// Token: 0x17001AE2 RID: 6882
		// (get) Token: 0x06007242 RID: 29250 RVA: 0x000A38E3 File Offset: 0x000A1AE3
		// (set) Token: 0x06007243 RID: 29251 RVA: 0x000A38F7 File Offset: 0x000A1AF7
		[Nullable(2)]
		public unsafe UAnimationAsset SourceAsset
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAnimationAsset>(base.NativePtr / (IntPtr)sizeof(void*) + FAnimTickRecord.__PropertyOffset_SourceAsset);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FAnimTickRecord.__PropertyOffset_SourceAsset, value);
			}
		}

		// Token: 0x17001AE3 RID: 6883
		// (get) Token: 0x06007244 RID: 29252 RVA: 0x000A390C File Offset: 0x000A1B0C
		// (set) Token: 0x06007245 RID: 29253 RVA: 0x000A392B File Offset: 0x000A1B2B
		public TSoftObjectPtr<UAnimationAsset> SourceAssetSoft
		{
			get
			{
				return new TSoftObjectPtr<UAnimationAsset>(base.NativePtr + (IntPtr)FAnimTickRecord.__PropertyOffset_SourceAssetSoft, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)FAnimTickRecord.__PropertyOffset_SourceAssetSoft, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x06007246 RID: 29254 RVA: 0x000A3950 File Offset: 0x000A1B50
		public FAnimTickRecord()
		{
		}

		// Token: 0x06007247 RID: 29255 RVA: 0x000A3958 File Offset: 0x000A1B58
		public FAnimTickRecord(UAnimationAsset SourceAsset, TSoftObjectPtr<UAnimationAsset> SourceAssetSoft)
		{
			this.SourceAsset = SourceAsset;
			this.SourceAssetSoft = SourceAssetSoft;
		}

		// Token: 0x06007248 RID: 29256 RVA: 0x000A396E File Offset: 0x000A1B6E
		protected override IntPtr GetUStructPtr()
		{
			return FAnimTickRecord.StaticStruct();
		}

		// Token: 0x06007249 RID: 29257 RVA: 0x000A397A File Offset: 0x000A1B7A
		[NullableContext(2)]
		public FAnimTickRecord(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600724A RID: 29258 RVA: 0x000A3984 File Offset: 0x000A1B84
		public FAnimTickRecord(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600724B RID: 29259 RVA: 0x000A398F File Offset: 0x000A1B8F
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAnimTickRecord(Pointer, false, true);
		}

		// Token: 0x0600724C RID: 29260 RVA: 0x000A3999 File Offset: 0x000A1B99
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAnimTickRecord(Pointer, MemoryOwner);
		}

		// Token: 0x040036DA RID: 14042
		public const string __ObjectPath = "/Script/Engine.AnimTickRecord";

		// Token: 0x040036DB RID: 14043
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040036DC RID: 14044
		internal static int __PropertyOffset_SourceAsset;

		// Token: 0x040036DD RID: 14045
		internal static int __PropertyOffset_SourceAssetSoft;
	}
}
