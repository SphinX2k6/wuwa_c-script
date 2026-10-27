using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020015F2 RID: 5618
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroAI.BTComposite_IfDecorator")]
	[UnrealStructLayout(200, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 200)]
	public class UBTComposite_IfDecorator : UBTCompositeNode, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060143C9 RID: 82889 RVA: 0x001DB6AD File Offset: 0x001D98AD
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBTComposite_IfDecorator._ClassPtr;
		}

		// Token: 0x060143CA RID: 82890 RVA: 0x001DB6BC File Offset: 0x001D98BC
		public UBTComposite_IfDecorator() : this(BuiltinUtils.AllocNativeUObject(UBTComposite_IfDecorator.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060143CB RID: 82891 RVA: 0x001DB6E4 File Offset: 0x001D98E4
		public UBTComposite_IfDecorator(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UBTComposite_IfDecorator.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004F4D RID: 20301
		// (get) Token: 0x060143CC RID: 82892 RVA: 0x001DB718 File Offset: 0x001D9918
		// (set) Token: 0x060143CD RID: 82893 RVA: 0x001DB751 File Offset: 0x001D9951
		public TArray<UBTDecorator> ConditionDecorators
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UBTDecorator> result;
				if ((result = this._ConditionDecorators) == null)
				{
					result = (this._ConditionDecorators = new TArray<UBTDecorator>(base.NativePtr + (IntPtr)UBTComposite_IfDecorator.__PropertyOffset_ConditionDecorators, this));
				}
				return result;
			}
			set
			{
				this.ConditionDecorators.CopyAssign(value);
			}
		}

		// Token: 0x17004F4E RID: 20302
		// (get) Token: 0x060143CE RID: 82894 RVA: 0x001DB760 File Offset: 0x001D9960
		// (set) Token: 0x060143CF RID: 82895 RVA: 0x001DB799 File Offset: 0x001D9999
		public TArray<FBTDecoratorLogic> ConditionDecoratorOps
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FBTDecoratorLogic> result;
				if ((result = this._ConditionDecoratorOps) == null)
				{
					result = (this._ConditionDecoratorOps = new TArray<FBTDecoratorLogic>(base.NativePtr + (IntPtr)UBTComposite_IfDecorator.__PropertyOffset_ConditionDecoratorOps, this));
				}
				return result;
			}
			set
			{
				this.ConditionDecoratorOps.CopyAssign(value);
			}
		}

		// Token: 0x060143D0 RID: 82896 RVA: 0x001DB7A7 File Offset: 0x001D99A7
		static UBTComposite_IfDecorator()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroAI.BTComposite_IfDecorator");
		}

		// Token: 0x060143D1 RID: 82897 RVA: 0x001DB7B5 File Offset: 0x001D99B5
		protected UBTComposite_IfDecorator(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400B022 RID: 45090
		public new const string __ObjectPath = "/Script/KuroAI.BTComposite_IfDecorator";

		// Token: 0x0400B023 RID: 45091
		private static IntPtr _ClassPtr;

		// Token: 0x0400B024 RID: 45092
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400B025 RID: 45093
		internal static int __PropertyOffset_ConditionDecorators;

		// Token: 0x0400B026 RID: 45094
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UBTDecorator> _ConditionDecorators;

		// Token: 0x0400B027 RID: 45095
		internal static int __PropertyOffset_ConditionDecoratorOps;

		// Token: 0x0400B028 RID: 45096
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FBTDecoratorLogic> _ConditionDecoratorOps;
	}
}
