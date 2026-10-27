using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020029D8 RID: 10712
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/UMG.SlateAccessibleWidgetData")]
	[UnrealStructLayout(184, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 184)]
	public class USlateAccessibleWidgetData : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06027A18 RID: 162328 RVA: 0x003C7091 File Offset: 0x003C5291
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USlateAccessibleWidgetData._ClassPtr;
		}

		// Token: 0x06027A19 RID: 162329 RVA: 0x003C70A0 File Offset: 0x003C52A0
		public USlateAccessibleWidgetData() : this(BuiltinUtils.AllocNativeUObject(USlateAccessibleWidgetData.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06027A1A RID: 162330 RVA: 0x003C70C8 File Offset: 0x003C52C8
		public USlateAccessibleWidgetData(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USlateAccessibleWidgetData.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170097D6 RID: 38870
		// (get) Token: 0x06027A1B RID: 162331 RVA: 0x003C70FB File Offset: 0x003C52FB
		// (set) Token: 0x06027A1C RID: 162332 RVA: 0x003C710B File Offset: 0x003C530B
		public unsafe bool bCanChildrenBeAccessible
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USlateAccessibleWidgetData.__PropertyOffset_bCanChildrenBeAccessible) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)USlateAccessibleWidgetData.__PropertyOffset_bCanChildrenBeAccessible) = (value ? 1 : 0);
			}
		}

		// Token: 0x170097D7 RID: 38871
		// (get) Token: 0x06027A1D RID: 162333 RVA: 0x003C711C File Offset: 0x003C531C
		// (set) Token: 0x06027A1E RID: 162334 RVA: 0x003C712C File Offset: 0x003C532C
		public unsafe ESlateAccessibleBehavior AccessibleBehavior
		{
			get
			{
				return (ESlateAccessibleBehavior)(*(base.NativePtr + (IntPtr)USlateAccessibleWidgetData.__PropertyOffset_AccessibleBehavior));
			}
			set
			{
				*(base.NativePtr + (IntPtr)USlateAccessibleWidgetData.__PropertyOffset_AccessibleBehavior) = (byte)value;
			}
		}

		// Token: 0x170097D8 RID: 38872
		// (get) Token: 0x06027A1F RID: 162335 RVA: 0x003C713D File Offset: 0x003C533D
		// (set) Token: 0x06027A20 RID: 162336 RVA: 0x003C714D File Offset: 0x003C534D
		public unsafe ESlateAccessibleBehavior AccessibleSummaryBehavior
		{
			get
			{
				return (ESlateAccessibleBehavior)(*(base.NativePtr + (IntPtr)USlateAccessibleWidgetData.__PropertyOffset_AccessibleSummaryBehavior));
			}
			set
			{
				*(base.NativePtr + (IntPtr)USlateAccessibleWidgetData.__PropertyOffset_AccessibleSummaryBehavior) = (byte)value;
			}
		}

		// Token: 0x170097D9 RID: 38873
		// (get) Token: 0x06027A21 RID: 162337 RVA: 0x003C7160 File Offset: 0x003C5360
		// (set) Token: 0x06027A22 RID: 162338 RVA: 0x003C7199 File Offset: 0x003C5399
		public unsafe FText AccessibleText
		{
			get
			{
				base.FastCheckIsValid();
				FText result;
				if ((result = this._AccessibleText) == null)
				{
					result = (this._AccessibleText = new FText(base.NativePtr + (IntPtr)USlateAccessibleWidgetData.__PropertyOffset_AccessibleText, this));
				}
				return result;
			}
			set
			{
				FText.NativeCopy((void*)(base.NativePtr + (byte*)((IntPtr)USlateAccessibleWidgetData.__PropertyOffset_AccessibleText)), value.NativePtr, 1);
			}
		}

		// Token: 0x170097DA RID: 38874
		// (get) Token: 0x06027A23 RID: 162339 RVA: 0x003C71B4 File Offset: 0x003C53B4
		// (set) Token: 0x06027A24 RID: 162340 RVA: 0x003C71ED File Offset: 0x003C53ED
		public FGetText AccessibleTextDelegate
		{
			get
			{
				base.FastCheckIsValid();
				FGetText result;
				if ((result = this._AccessibleTextDelegate) == null)
				{
					result = (this._AccessibleTextDelegate = new FGetText(base.NativePtr + (IntPtr)USlateAccessibleWidgetData.__PropertyOffset_AccessibleTextDelegate, this));
				}
				return result;
			}
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)USlateAccessibleWidgetData.__PropertyOffset_AccessibleTextDelegate, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x170097DB RID: 38875
		// (get) Token: 0x06027A25 RID: 162341 RVA: 0x003C7210 File Offset: 0x003C5410
		// (set) Token: 0x06027A26 RID: 162342 RVA: 0x003C7249 File Offset: 0x003C5449
		public unsafe FText AccessibleSummaryText
		{
			get
			{
				base.FastCheckIsValid();
				FText result;
				if ((result = this._AccessibleSummaryText) == null)
				{
					result = (this._AccessibleSummaryText = new FText(base.NativePtr + (IntPtr)USlateAccessibleWidgetData.__PropertyOffset_AccessibleSummaryText, this));
				}
				return result;
			}
			set
			{
				FText.NativeCopy((void*)(base.NativePtr + (byte*)((IntPtr)USlateAccessibleWidgetData.__PropertyOffset_AccessibleSummaryText)), value.NativePtr, 1);
			}
		}

		// Token: 0x170097DC RID: 38876
		// (get) Token: 0x06027A27 RID: 162343 RVA: 0x003C7264 File Offset: 0x003C5464
		// (set) Token: 0x06027A28 RID: 162344 RVA: 0x003C729D File Offset: 0x003C549D
		public FGetText AccessibleSummaryTextDelegate
		{
			get
			{
				base.FastCheckIsValid();
				FGetText result;
				if ((result = this._AccessibleSummaryTextDelegate) == null)
				{
					result = (this._AccessibleSummaryTextDelegate = new FGetText(base.NativePtr + (IntPtr)USlateAccessibleWidgetData.__PropertyOffset_AccessibleSummaryTextDelegate, this));
				}
				return result;
			}
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)USlateAccessibleWidgetData.__PropertyOffset_AccessibleSummaryTextDelegate, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x06027A29 RID: 162345 RVA: 0x003C72BE File Offset: 0x003C54BE
		static USlateAccessibleWidgetData()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/UMG.SlateAccessibleWidgetData");
		}

		// Token: 0x06027A2A RID: 162346 RVA: 0x003C72CC File Offset: 0x003C54CC
		protected USlateAccessibleWidgetData(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015B61 RID: 88929
		public new const string __ObjectPath = "/Script/UMG.SlateAccessibleWidgetData";

		// Token: 0x04015B62 RID: 88930
		private static IntPtr _ClassPtr;

		// Token: 0x04015B63 RID: 88931
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04015B64 RID: 88932
		public static IntPtr __GetText__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04015B65 RID: 88933
		internal static int __PropertyOffset_bCanChildrenBeAccessible;

		// Token: 0x04015B66 RID: 88934
		internal static int __PropertyOffset_AccessibleBehavior;

		// Token: 0x04015B67 RID: 88935
		internal static int __PropertyOffset_AccessibleSummaryBehavior;

		// Token: 0x04015B68 RID: 88936
		internal static int __PropertyOffset_AccessibleText;

		// Token: 0x04015B69 RID: 88937
		[Nullable(2)]
		private FText _AccessibleText;

		// Token: 0x04015B6A RID: 88938
		internal static int __PropertyOffset_AccessibleTextDelegate;

		// Token: 0x04015B6B RID: 88939
		[Nullable(2)]
		private FGetText _AccessibleTextDelegate;

		// Token: 0x04015B6C RID: 88940
		internal static int __PropertyOffset_AccessibleSummaryText;

		// Token: 0x04015B6D RID: 88941
		[Nullable(2)]
		private FText _AccessibleSummaryText;

		// Token: 0x04015B6E RID: 88942
		internal static int __PropertyOffset_AccessibleSummaryTextDelegate;

		// Token: 0x04015B6F RID: 88943
		[Nullable(2)]
		private FGetText _AccessibleSummaryTextDelegate;
	}
}
