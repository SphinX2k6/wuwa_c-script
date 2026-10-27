using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000FD4 RID: 4052
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.PerBoneBlendWeights")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FPerBoneBlendWeights : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600DAE8 RID: 56040 RVA: 0x00142B3C File Offset: 0x00140D3C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FPerBoneBlendWeights._ScriptStructPtr != 0) ? FPerBoneBlendWeights._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.PerBoneBlendWeights", ref FPerBoneBlendWeights._ScriptStructPtr);
		}

		// Token: 0x170033A4 RID: 13220
		// (get) Token: 0x0600DAE9 RID: 56041 RVA: 0x00142B60 File Offset: 0x00140D60
		// (set) Token: 0x0600DAEA RID: 56042 RVA: 0x00142BA3 File Offset: 0x00140DA3
		public TArray<FPerBoneBlendWeight> BoneBlendWeights
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FPerBoneBlendWeight> result;
				if ((result = this._BoneBlendWeights) == null)
				{
					result = (this._BoneBlendWeights = new TArray<FPerBoneBlendWeight>(base.NativePtr + (IntPtr)FPerBoneBlendWeights.__PropertyOffset_BoneBlendWeights, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.BoneBlendWeights.CopyAssign(value);
			}
		}

		// Token: 0x0600DAEB RID: 56043 RVA: 0x00142BB1 File Offset: 0x00140DB1
		public FPerBoneBlendWeights()
		{
		}

		// Token: 0x0600DAEC RID: 56044 RVA: 0x00142BB9 File Offset: 0x00140DB9
		public FPerBoneBlendWeights(TArray<FPerBoneBlendWeight> BoneBlendWeights)
		{
			this.BoneBlendWeights = BoneBlendWeights;
		}

		// Token: 0x0600DAED RID: 56045 RVA: 0x00142BC8 File Offset: 0x00140DC8
		protected override IntPtr GetUStructPtr()
		{
			return FPerBoneBlendWeights.StaticStruct();
		}

		// Token: 0x0600DAEE RID: 56046 RVA: 0x00142BD4 File Offset: 0x00140DD4
		[NullableContext(2)]
		public FPerBoneBlendWeights(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600DAEF RID: 56047 RVA: 0x00142BDE File Offset: 0x00140DDE
		public FPerBoneBlendWeights(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600DAF0 RID: 56048 RVA: 0x00142BE9 File Offset: 0x00140DE9
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FPerBoneBlendWeights(Pointer, false, true);
		}

		// Token: 0x0600DAF1 RID: 56049 RVA: 0x00142BF3 File Offset: 0x00140DF3
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FPerBoneBlendWeights(Pointer, MemoryOwner);
		}

		// Token: 0x04007684 RID: 30340
		public const string __ObjectPath = "/Script/Engine.PerBoneBlendWeights";

		// Token: 0x04007685 RID: 30341
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04007686 RID: 30342
		internal static int __PropertyOffset_BoneBlendWeights;

		// Token: 0x04007687 RID: 30343
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FPerBoneBlendWeight> _BoneBlendWeights;
	}
}
