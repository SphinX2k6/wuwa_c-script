using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001701 RID: 5889
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroBulletCore.KuroBulletPattern")]
	[UnrealStructLayout(288, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 288)]
	public class UKuroBulletPattern : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06015449 RID: 87113 RVA: 0x001F424A File Offset: 0x001F244A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroBulletPattern._ClassPtr;
		}

		// Token: 0x0601544A RID: 87114 RVA: 0x001F4258 File Offset: 0x001F2458
		public UKuroBulletPattern() : this(BuiltinUtils.AllocNativeUObject(UKuroBulletPattern.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601544B RID: 87115 RVA: 0x001F4280 File Offset: 0x001F2480
		[NullableContext(1)]
		public UKuroBulletPattern(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroBulletPattern.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700541E RID: 21534
		// (get) Token: 0x0601544C RID: 87116 RVA: 0x001F42B3 File Offset: 0x001F24B3
		// (set) Token: 0x0601544D RID: 87117 RVA: 0x001F42C7 File Offset: 0x001F24C7
		public unsafe UKuroBulletPatternDataAsset PatternDataAsset
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroBulletPatternDataAsset>(base.NativePtr / (IntPtr)sizeof(void*) + UKuroBulletPattern.__PropertyOffset_PatternDataAsset);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKuroBulletPattern.__PropertyOffset_PatternDataAsset, value);
			}
		}

		// Token: 0x1700541F RID: 21535
		// (get) Token: 0x0601544E RID: 87118 RVA: 0x001F42DC File Offset: 0x001F24DC
		// (set) Token: 0x0601544F RID: 87119 RVA: 0x001F42F6 File Offset: 0x001F24F6
		public unsafe IBulletContext PatternContext
		{
			get
			{
				return (IBulletContext)BuiltinUtils.GetOrCreateUObjectByNativePointer(*(base.NativePtr + (IntPtr)UKuroBulletPattern.__PropertyOffset_PatternContext));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroBulletPattern.__PropertyOffset_PatternContext) = new FScriptInterface(value, (value != null) ? value.InterfaceOffset() : 0);
			}
		}

		// Token: 0x17005420 RID: 21536
		// (get) Token: 0x06015450 RID: 87120 RVA: 0x001F431C File Offset: 0x001F251C
		// (set) Token: 0x06015451 RID: 87121 RVA: 0x001F4355 File Offset: 0x001F2555
		[Nullable(1)]
		public TArray<UKuroBulletEmitter> Emitters
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<UKuroBulletEmitter> result;
				if ((result = this._Emitters) == null)
				{
					result = (this._Emitters = new TArray<UKuroBulletEmitter>(base.NativePtr + (IntPtr)UKuroBulletPattern.__PropertyOffset_Emitters, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Emitters.CopyAssign(value);
			}
		}

		// Token: 0x06015452 RID: 87122 RVA: 0x001F4363 File Offset: 0x001F2563
		static UKuroBulletPattern()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroBulletCore.KuroBulletPattern");
		}

		// Token: 0x06015453 RID: 87123 RVA: 0x001F4371 File Offset: 0x001F2571
		protected UKuroBulletPattern(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400B989 RID: 47497
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroBulletCore.KuroBulletPattern";

		// Token: 0x0400B98A RID: 47498
		private static IntPtr _ClassPtr;

		// Token: 0x0400B98B RID: 47499
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400B98C RID: 47500
		internal static int __PropertyOffset_PatternDataAsset;

		// Token: 0x0400B98D RID: 47501
		internal static int __PropertyOffset_PatternContext;

		// Token: 0x0400B98E RID: 47502
		internal static int __PropertyOffset_Emitters;

		// Token: 0x0400B98F RID: 47503
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UKuroBulletEmitter> _Emitters;
	}
}
