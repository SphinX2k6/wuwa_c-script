using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020029F8 RID: 10744
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/UMG.WidgetAnimationDelegateBinding")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 64)]
	public class UWidgetAnimationDelegateBinding : UDynamicBlueprintBinding, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06027E0C RID: 163340 RVA: 0x003CBECC File Offset: 0x003CA0CC
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UWidgetAnimationDelegateBinding._ClassPtr;
		}

		// Token: 0x06027E0D RID: 163341 RVA: 0x003CBED8 File Offset: 0x003CA0D8
		public UWidgetAnimationDelegateBinding() : this(BuiltinUtils.AllocNativeUObject(UWidgetAnimationDelegateBinding.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06027E0E RID: 163342 RVA: 0x003CBF00 File Offset: 0x003CA100
		public UWidgetAnimationDelegateBinding(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UWidgetAnimationDelegateBinding.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17009881 RID: 39041
		// (get) Token: 0x06027E0F RID: 163343 RVA: 0x003CBF34 File Offset: 0x003CA134
		// (set) Token: 0x06027E10 RID: 163344 RVA: 0x003CBF6D File Offset: 0x003CA16D
		public TArray<FBlueprintWidgetAnimationDelegateBinding> WidgetAnimationDelegateBindings
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FBlueprintWidgetAnimationDelegateBinding> result;
				if ((result = this._WidgetAnimationDelegateBindings) == null)
				{
					result = (this._WidgetAnimationDelegateBindings = new TArray<FBlueprintWidgetAnimationDelegateBinding>(base.NativePtr + (IntPtr)UWidgetAnimationDelegateBinding.__PropertyOffset_WidgetAnimationDelegateBindings, this));
				}
				return result;
			}
			set
			{
				this.WidgetAnimationDelegateBindings.CopyAssign(value);
			}
		}

		// Token: 0x06027E11 RID: 163345 RVA: 0x003CBF7B File Offset: 0x003CA17B
		static UWidgetAnimationDelegateBinding()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/UMG.WidgetAnimationDelegateBinding");
		}

		// Token: 0x06027E12 RID: 163346 RVA: 0x003CBF89 File Offset: 0x003CA189
		protected UWidgetAnimationDelegateBinding(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015CC2 RID: 89282
		public new const string __ObjectPath = "/Script/UMG.WidgetAnimationDelegateBinding";

		// Token: 0x04015CC3 RID: 89283
		private static IntPtr _ClassPtr;

		// Token: 0x04015CC4 RID: 89284
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04015CC5 RID: 89285
		internal static int __PropertyOffset_WidgetAnimationDelegateBindings;

		// Token: 0x04015CC6 RID: 89286
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FBlueprintWidgetAnimationDelegateBinding> _WidgetAnimationDelegateBindings;
	}
}
