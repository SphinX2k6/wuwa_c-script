using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020008DB RID: 2267
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.BoneReductionSetting")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FBoneReductionSetting : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06007CA4 RID: 31908 RVA: 0x000B2BF3 File Offset: 0x000B0DF3
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FBoneReductionSetting._ScriptStructPtr != 0) ? FBoneReductionSetting._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.BoneReductionSetting", ref FBoneReductionSetting._ScriptStructPtr);
		}

		// Token: 0x17001D4D RID: 7501
		// (get) Token: 0x06007CA5 RID: 31909 RVA: 0x000B2C18 File Offset: 0x000B0E18
		// (set) Token: 0x06007CA6 RID: 31910 RVA: 0x000B2C5B File Offset: 0x000B0E5B
		public TArray<FName> BonesToRemove
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._BonesToRemove) == null)
				{
					result = (this._BonesToRemove = new TArray<FName>(base.NativePtr + (IntPtr)FBoneReductionSetting.__PropertyOffset_BonesToRemove, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.BonesToRemove.CopyAssign(value);
			}
		}

		// Token: 0x06007CA7 RID: 31911 RVA: 0x000B2C69 File Offset: 0x000B0E69
		public FBoneReductionSetting()
		{
		}

		// Token: 0x06007CA8 RID: 31912 RVA: 0x000B2C71 File Offset: 0x000B0E71
		public FBoneReductionSetting(TArray<FName> BonesToRemove)
		{
			this.BonesToRemove = BonesToRemove;
		}

		// Token: 0x06007CA9 RID: 31913 RVA: 0x000B2C80 File Offset: 0x000B0E80
		protected override IntPtr GetUStructPtr()
		{
			return FBoneReductionSetting.StaticStruct();
		}

		// Token: 0x06007CAA RID: 31914 RVA: 0x000B2C8C File Offset: 0x000B0E8C
		[NullableContext(2)]
		public FBoneReductionSetting(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06007CAB RID: 31915 RVA: 0x000B2C96 File Offset: 0x000B0E96
		public FBoneReductionSetting(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06007CAC RID: 31916 RVA: 0x000B2CA1 File Offset: 0x000B0EA1
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FBoneReductionSetting(Pointer, false, true);
		}

		// Token: 0x06007CAD RID: 31917 RVA: 0x000B2CAB File Offset: 0x000B0EAB
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FBoneReductionSetting(Pointer, MemoryOwner);
		}

		// Token: 0x04003BBD RID: 15293
		public const string __ObjectPath = "/Script/Engine.BoneReductionSetting";

		// Token: 0x04003BBE RID: 15294
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04003BBF RID: 15295
		internal static int __PropertyOffset_BonesToRemove;

		// Token: 0x04003BC0 RID: 15296
		[Nullable(2)]
		private TArray<FName> _BonesToRemove;
	}
}
