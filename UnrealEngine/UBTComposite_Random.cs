using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020015F4 RID: 5620
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroAI.BTComposite_Random")]
	[UnrealStructLayout(216, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 216)]
	public class UBTComposite_Random : UBTCompositeNode, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060143D9 RID: 82905 RVA: 0x001DB85F File Offset: 0x001D9A5F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBTComposite_Random._ClassPtr;
		}

		// Token: 0x060143DA RID: 82906 RVA: 0x001DB86C File Offset: 0x001D9A6C
		public UBTComposite_Random() : this(BuiltinUtils.AllocNativeUObject(UBTComposite_Random.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060143DB RID: 82907 RVA: 0x001DB894 File Offset: 0x001D9A94
		public UBTComposite_Random(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UBTComposite_Random.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004F50 RID: 20304
		// (get) Token: 0x060143DC RID: 82908 RVA: 0x001DB8C8 File Offset: 0x001D9AC8
		// (set) Token: 0x060143DD RID: 82909 RVA: 0x001DB901 File Offset: 0x001D9B01
		public TArray<int> Weights
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._Weights) == null)
				{
					result = (this._Weights = new TArray<int>(base.NativePtr + (IntPtr)UBTComposite_Random.__PropertyOffset_Weights, this));
				}
				return result;
			}
			set
			{
				this.Weights.CopyAssign(value);
			}
		}

		// Token: 0x17004F51 RID: 20305
		// (get) Token: 0x060143DE RID: 82910 RVA: 0x001DB910 File Offset: 0x001D9B10
		// (set) Token: 0x060143DF RID: 82911 RVA: 0x001DB949 File Offset: 0x001D9B49
		public TArray<int> WeightIncrements
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._WeightIncrements) == null)
				{
					result = (this._WeightIncrements = new TArray<int>(base.NativePtr + (IntPtr)UBTComposite_Random.__PropertyOffset_WeightIncrements, this));
				}
				return result;
			}
			set
			{
				this.WeightIncrements.CopyAssign(value);
			}
		}

		// Token: 0x17004F52 RID: 20306
		// (get) Token: 0x060143E0 RID: 82912 RVA: 0x001DB957 File Offset: 0x001D9B57
		// (set) Token: 0x060143E1 RID: 82913 RVA: 0x001DB967 File Offset: 0x001D9B67
		public unsafe float ResetTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBTComposite_Random.__PropertyOffset_ResetTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBTComposite_Random.__PropertyOffset_ResetTime) = value;
			}
		}

		// Token: 0x17004F53 RID: 20307
		// (get) Token: 0x060143E2 RID: 82914 RVA: 0x001DB978 File Offset: 0x001D9B78
		// (set) Token: 0x060143E3 RID: 82915 RVA: 0x001DB98C File Offset: 0x001D9B8C
		public unsafe FName Key
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBTComposite_Random.__PropertyOffset_Key);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBTComposite_Random.__PropertyOffset_Key) = value;
			}
		}

		// Token: 0x060143E4 RID: 82916 RVA: 0x001DB9A1 File Offset: 0x001D9BA1
		static UBTComposite_Random()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroAI.BTComposite_Random");
		}

		// Token: 0x060143E5 RID: 82917 RVA: 0x001DB9AF File Offset: 0x001D9BAF
		protected UBTComposite_Random(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400B02D RID: 45101
		public new const string __ObjectPath = "/Script/KuroAI.BTComposite_Random";

		// Token: 0x0400B02E RID: 45102
		private static IntPtr _ClassPtr;

		// Token: 0x0400B02F RID: 45103
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400B030 RID: 45104
		internal static int __PropertyOffset_Weights;

		// Token: 0x0400B031 RID: 45105
		[Nullable(2)]
		private TArray<int> _Weights;

		// Token: 0x0400B032 RID: 45106
		internal static int __PropertyOffset_WeightIncrements;

		// Token: 0x0400B033 RID: 45107
		[Nullable(2)]
		private TArray<int> _WeightIncrements;

		// Token: 0x0400B034 RID: 45108
		internal static int __PropertyOffset_ResetTime;

		// Token: 0x0400B035 RID: 45109
		internal static int __PropertyOffset_Key;
	}
}
