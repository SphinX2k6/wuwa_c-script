using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000899 RID: 2201
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.BakedCustomAttributePerBoneData")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 56)]
	public class FBakedCustomAttributePerBoneData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600786E RID: 30830 RVA: 0x000AC737 File Offset: 0x000AA937
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FBakedCustomAttributePerBoneData._ScriptStructPtr != 0) ? FBakedCustomAttributePerBoneData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.BakedCustomAttributePerBoneData", ref FBakedCustomAttributePerBoneData._ScriptStructPtr);
		}

		// Token: 0x17001C72 RID: 7282
		// (get) Token: 0x0600786F RID: 30831 RVA: 0x000AC75B File Offset: 0x000AA95B
		// (set) Token: 0x06007870 RID: 30832 RVA: 0x000AC76B File Offset: 0x000AA96B
		public unsafe int BoneTreeIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBakedCustomAttributePerBoneData.__PropertyOffset_BoneTreeIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBakedCustomAttributePerBoneData.__PropertyOffset_BoneTreeIndex) = value;
			}
		}

		// Token: 0x17001C73 RID: 7283
		// (get) Token: 0x06007871 RID: 30833 RVA: 0x000AC77C File Offset: 0x000AA97C
		// (set) Token: 0x06007872 RID: 30834 RVA: 0x000AC7BF File Offset: 0x000AA9BF
		public TArray<FBakedStringCustomAttribute> StringAttributes
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FBakedStringCustomAttribute> result;
				if ((result = this._StringAttributes) == null)
				{
					result = (this._StringAttributes = new TArray<FBakedStringCustomAttribute>(base.NativePtr + (IntPtr)FBakedCustomAttributePerBoneData.__PropertyOffset_StringAttributes, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.StringAttributes.CopyAssign(value);
			}
		}

		// Token: 0x17001C74 RID: 7284
		// (get) Token: 0x06007873 RID: 30835 RVA: 0x000AC7D0 File Offset: 0x000AA9D0
		// (set) Token: 0x06007874 RID: 30836 RVA: 0x000AC813 File Offset: 0x000AAA13
		public TArray<FBakedIntegerCustomAttribute> IntAttributes
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FBakedIntegerCustomAttribute> result;
				if ((result = this._IntAttributes) == null)
				{
					result = (this._IntAttributes = new TArray<FBakedIntegerCustomAttribute>(base.NativePtr + (IntPtr)FBakedCustomAttributePerBoneData.__PropertyOffset_IntAttributes, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.IntAttributes.CopyAssign(value);
			}
		}

		// Token: 0x17001C75 RID: 7285
		// (get) Token: 0x06007875 RID: 30837 RVA: 0x000AC824 File Offset: 0x000AAA24
		// (set) Token: 0x06007876 RID: 30838 RVA: 0x000AC867 File Offset: 0x000AAA67
		public TArray<FBakedFloatCustomAttribute> FloatAttributes
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FBakedFloatCustomAttribute> result;
				if ((result = this._FloatAttributes) == null)
				{
					result = (this._FloatAttributes = new TArray<FBakedFloatCustomAttribute>(base.NativePtr + (IntPtr)FBakedCustomAttributePerBoneData.__PropertyOffset_FloatAttributes, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.FloatAttributes.CopyAssign(value);
			}
		}

		// Token: 0x06007877 RID: 30839 RVA: 0x000AC875 File Offset: 0x000AAA75
		public FBakedCustomAttributePerBoneData()
		{
		}

		// Token: 0x06007878 RID: 30840 RVA: 0x000AC87D File Offset: 0x000AAA7D
		public FBakedCustomAttributePerBoneData(int BoneTreeIndex, TArray<FBakedStringCustomAttribute> StringAttributes, TArray<FBakedIntegerCustomAttribute> IntAttributes, TArray<FBakedFloatCustomAttribute> FloatAttributes)
		{
			this.BoneTreeIndex = BoneTreeIndex;
			this.StringAttributes = StringAttributes;
			this.IntAttributes = IntAttributes;
			this.FloatAttributes = FloatAttributes;
		}

		// Token: 0x06007879 RID: 30841 RVA: 0x000AC8A2 File Offset: 0x000AAAA2
		protected override IntPtr GetUStructPtr()
		{
			return FBakedCustomAttributePerBoneData.StaticStruct();
		}

		// Token: 0x0600787A RID: 30842 RVA: 0x000AC8AE File Offset: 0x000AAAAE
		[NullableContext(2)]
		public FBakedCustomAttributePerBoneData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600787B RID: 30843 RVA: 0x000AC8B8 File Offset: 0x000AAAB8
		public FBakedCustomAttributePerBoneData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600787C RID: 30844 RVA: 0x000AC8C3 File Offset: 0x000AAAC3
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FBakedCustomAttributePerBoneData(Pointer, false, true);
		}

		// Token: 0x0600787D RID: 30845 RVA: 0x000AC8CD File Offset: 0x000AAACD
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FBakedCustomAttributePerBoneData(Pointer, MemoryOwner);
		}

		// Token: 0x040039D9 RID: 14809
		public const string __ObjectPath = "/Script/Engine.BakedCustomAttributePerBoneData";

		// Token: 0x040039DA RID: 14810
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040039DB RID: 14811
		internal static int __PropertyOffset_BoneTreeIndex;

		// Token: 0x040039DC RID: 14812
		internal static int __PropertyOffset_StringAttributes;

		// Token: 0x040039DD RID: 14813
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FBakedStringCustomAttribute> _StringAttributes;

		// Token: 0x040039DE RID: 14814
		internal static int __PropertyOffset_IntAttributes;

		// Token: 0x040039DF RID: 14815
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FBakedIntegerCustomAttribute> _IntAttributes;

		// Token: 0x040039E0 RID: 14816
		internal static int __PropertyOffset_FloatAttributes;

		// Token: 0x040039E1 RID: 14817
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FBakedFloatCustomAttribute> _FloatAttributes;
	}
}
