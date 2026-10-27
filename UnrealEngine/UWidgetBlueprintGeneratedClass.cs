using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020029FD RID: 10749
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/UMG.WidgetBlueprintGeneratedClass")]
	[UnrealStructLayout(1576, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1576)]
	public class UWidgetBlueprintGeneratedClass : UBlueprintGeneratedClass, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06027E36 RID: 163382 RVA: 0x003CC4A0 File Offset: 0x003CA6A0
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UWidgetBlueprintGeneratedClass._ClassPtr;
		}

		// Token: 0x06027E37 RID: 163383 RVA: 0x003CC4AC File Offset: 0x003CA6AC
		public UWidgetBlueprintGeneratedClass() : this(BuiltinUtils.AllocNativeUObject(UWidgetBlueprintGeneratedClass.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06027E38 RID: 163384 RVA: 0x003CC4D4 File Offset: 0x003CA6D4
		public UWidgetBlueprintGeneratedClass(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UWidgetBlueprintGeneratedClass.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17009883 RID: 39043
		// (get) Token: 0x06027E39 RID: 163385 RVA: 0x003CC507 File Offset: 0x003CA707
		// (set) Token: 0x06027E3A RID: 163386 RVA: 0x003CC51B File Offset: 0x003CA71B
		[Nullable(2)]
		public unsafe UWidgetTree WidgetTree
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UWidgetTree>(base.NativePtr / (IntPtr)sizeof(void*) + UWidgetBlueprintGeneratedClass.__PropertyOffset_WidgetTree);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UWidgetBlueprintGeneratedClass.__PropertyOffset_WidgetTree, value);
			}
		}

		// Token: 0x17009884 RID: 39044
		// (get) Token: 0x06027E3B RID: 163387 RVA: 0x003CC530 File Offset: 0x003CA730
		// (set) Token: 0x06027E3C RID: 163388 RVA: 0x003CC549 File Offset: 0x003CA749
		public unsafe bool bClassRequiresNativeTick
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UWidgetBlueprintGeneratedClass.__PropertyOffset_bClassRequiresNativeTick) & UWidgetBlueprintGeneratedClass.__PropertyMask_bClassRequiresNativeTick) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UWidgetBlueprintGeneratedClass.__PropertyOffset_bClassRequiresNativeTick) = ((*(base.NativePtr + (IntPtr)UWidgetBlueprintGeneratedClass.__PropertyOffset_bClassRequiresNativeTick) & ~UWidgetBlueprintGeneratedClass.__PropertyMask_bClassRequiresNativeTick) | (value ? UWidgetBlueprintGeneratedClass.__PropertyMask_bClassRequiresNativeTick : 0));
			}
		}

		// Token: 0x17009885 RID: 39045
		// (get) Token: 0x06027E3D RID: 163389 RVA: 0x003CC57C File Offset: 0x003CA77C
		// (set) Token: 0x06027E3E RID: 163390 RVA: 0x003CC5B5 File Offset: 0x003CA7B5
		public TArray<FDelegateRuntimeBinding> Bindings
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FDelegateRuntimeBinding> result;
				if ((result = this._Bindings) == null)
				{
					result = (this._Bindings = new TArray<FDelegateRuntimeBinding>(base.NativePtr + (IntPtr)UWidgetBlueprintGeneratedClass.__PropertyOffset_Bindings, this));
				}
				return result;
			}
			set
			{
				this.Bindings.CopyAssign(value);
			}
		}

		// Token: 0x17009886 RID: 39046
		// (get) Token: 0x06027E3F RID: 163391 RVA: 0x003CC5C4 File Offset: 0x003CA7C4
		// (set) Token: 0x06027E40 RID: 163392 RVA: 0x003CC5FD File Offset: 0x003CA7FD
		public TArray<UWidgetAnimation> Animations
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UWidgetAnimation> result;
				if ((result = this._Animations) == null)
				{
					result = (this._Animations = new TArray<UWidgetAnimation>(base.NativePtr + (IntPtr)UWidgetBlueprintGeneratedClass.__PropertyOffset_Animations, this));
				}
				return result;
			}
			set
			{
				this.Animations.CopyAssign(value);
			}
		}

		// Token: 0x17009887 RID: 39047
		// (get) Token: 0x06027E41 RID: 163393 RVA: 0x003CC60C File Offset: 0x003CA80C
		// (set) Token: 0x06027E42 RID: 163394 RVA: 0x003CC645 File Offset: 0x003CA845
		public TArray<FName> NamedSlots
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._NamedSlots) == null)
				{
					result = (this._NamedSlots = new TArray<FName>(base.NativePtr + (IntPtr)UWidgetBlueprintGeneratedClass.__PropertyOffset_NamedSlots, this));
				}
				return result;
			}
			set
			{
				this.NamedSlots.CopyAssign(value);
			}
		}

		// Token: 0x06027E43 RID: 163395 RVA: 0x003CC653 File Offset: 0x003CA853
		static UWidgetBlueprintGeneratedClass()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/UMG.WidgetBlueprintGeneratedClass");
		}

		// Token: 0x06027E44 RID: 163396 RVA: 0x003CC661 File Offset: 0x003CA861
		protected UWidgetBlueprintGeneratedClass(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015CD7 RID: 89303
		public new const string __ObjectPath = "/Script/UMG.WidgetBlueprintGeneratedClass";

		// Token: 0x04015CD8 RID: 89304
		private static IntPtr _ClassPtr;

		// Token: 0x04015CD9 RID: 89305
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04015CDA RID: 89306
		internal static int __PropertyOffset_WidgetTree;

		// Token: 0x04015CDB RID: 89307
		internal static int __PropertyOffset_bClassRequiresNativeTick;

		// Token: 0x04015CDC RID: 89308
		internal static byte __PropertyMask_bClassRequiresNativeTick;

		// Token: 0x04015CDD RID: 89309
		internal static int __PropertyOffset_Bindings;

		// Token: 0x04015CDE RID: 89310
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FDelegateRuntimeBinding> _Bindings;

		// Token: 0x04015CDF RID: 89311
		internal static int __PropertyOffset_Animations;

		// Token: 0x04015CE0 RID: 89312
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UWidgetAnimation> _Animations;

		// Token: 0x04015CE1 RID: 89313
		internal static int __PropertyOffset_NamedSlots;

		// Token: 0x04015CE2 RID: 89314
		[Nullable(2)]
		private TArray<FName> _NamedSlots;
	}
}
