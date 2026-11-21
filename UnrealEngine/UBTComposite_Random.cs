using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020002D8 RID: 728
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroAI.BTComposite_Random")]
	[UnrealStructLayout(216, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 216)]
	public class UBTComposite_Random : UBTCompositeNode, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06004EB1 RID: 20145 RVA: 0x0006DEED File Offset: 0x0006C0ED
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBTComposite_Random._ClassPtr;
		}

		// Token: 0x06004EB2 RID: 20146 RVA: 0x0006DEFC File Offset: 0x0006C0FC
		public UBTComposite_Random() : this(BuiltinUtils.AllocNativeUObject(UBTComposite_Random.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06004EB3 RID: 20147 RVA: 0x0006DF24 File Offset: 0x0006C124
		public UBTComposite_Random(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UBTComposite_Random.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000F0D RID: 3853
		// (get) Token: 0x06004EB4 RID: 20148 RVA: 0x0006DF58 File Offset: 0x0006C158
		// (set) Token: 0x06004EB5 RID: 20149 RVA: 0x0006DF91 File Offset: 0x0006C191
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

		// Token: 0x17000F0E RID: 3854
		// (get) Token: 0x06004EB6 RID: 20150 RVA: 0x0006DFA0 File Offset: 0x0006C1A0
		// (set) Token: 0x06004EB7 RID: 20151 RVA: 0x0006DFD9 File Offset: 0x0006C1D9
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

		// Token: 0x17000F0F RID: 3855
		// (get) Token: 0x06004EB8 RID: 20152 RVA: 0x0006DFE7 File Offset: 0x0006C1E7
		// (set) Token: 0x06004EB9 RID: 20153 RVA: 0x0006DFF7 File Offset: 0x0006C1F7
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

		// Token: 0x17000F10 RID: 3856
		// (get) Token: 0x06004EBA RID: 20154 RVA: 0x0006E008 File Offset: 0x0006C208
		// (set) Token: 0x06004EBB RID: 20155 RVA: 0x0006E01C File Offset: 0x0006C21C
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

		// Token: 0x06004EBC RID: 20156 RVA: 0x0006E031 File Offset: 0x0006C231
		static UBTComposite_Random()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroAI.BTComposite_Random");
		}

		// Token: 0x06004EBD RID: 20157 RVA: 0x0006E03F File Offset: 0x0006C23F
		protected UBTComposite_Random(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04001F75 RID: 8053
		public new const string __ObjectPath = "/Script/KuroAI.BTComposite_Random";

		// Token: 0x04001F76 RID: 8054
		private static IntPtr _ClassPtr;

		// Token: 0x04001F77 RID: 8055
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04001F78 RID: 8056
		internal static int __PropertyOffset_Weights;

		// Token: 0x04001F79 RID: 8057
		[Nullable(2)]
		private TArray<int> _Weights;

		// Token: 0x04001F7A RID: 8058
		internal static int __PropertyOffset_WeightIncrements;

		// Token: 0x04001F7B RID: 8059
		[Nullable(2)]
		private TArray<int> _WeightIncrements;

		// Token: 0x04001F7C RID: 8060
		internal static int __PropertyOffset_ResetTime;

		// Token: 0x04001F7D RID: 8061
		internal static int __PropertyOffset_Key;
	}
}
