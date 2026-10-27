using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000C78 RID: 3192
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.InterpCurveEdSetup")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 72)]
	public class UInterpCurveEdSetup : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600A21E RID: 41502 RVA: 0x000E62C0 File Offset: 0x000E44C0
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UInterpCurveEdSetup._ClassPtr;
		}

		// Token: 0x0600A21F RID: 41503 RVA: 0x000E62CC File Offset: 0x000E44CC
		public UInterpCurveEdSetup() : this(BuiltinUtils.AllocNativeUObject(UInterpCurveEdSetup.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600A220 RID: 41504 RVA: 0x000E62F4 File Offset: 0x000E44F4
		public UInterpCurveEdSetup(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UInterpCurveEdSetup.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002694 RID: 9876
		// (get) Token: 0x0600A221 RID: 41505 RVA: 0x000E6328 File Offset: 0x000E4528
		// (set) Token: 0x0600A222 RID: 41506 RVA: 0x000E6361 File Offset: 0x000E4561
		public TArray<FCurveEdTab> Tabs
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FCurveEdTab> result;
				if ((result = this._Tabs) == null)
				{
					result = (this._Tabs = new TArray<FCurveEdTab>(base.NativePtr + (IntPtr)UInterpCurveEdSetup.__PropertyOffset_Tabs, this));
				}
				return result;
			}
			set
			{
				this.Tabs.CopyAssign(value);
			}
		}

		// Token: 0x17002695 RID: 9877
		// (get) Token: 0x0600A223 RID: 41507 RVA: 0x000E636F File Offset: 0x000E456F
		// (set) Token: 0x0600A224 RID: 41508 RVA: 0x000E637F File Offset: 0x000E457F
		public unsafe int ActiveTab
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UInterpCurveEdSetup.__PropertyOffset_ActiveTab);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UInterpCurveEdSetup.__PropertyOffset_ActiveTab) = value;
			}
		}

		// Token: 0x0600A225 RID: 41509 RVA: 0x000E6390 File Offset: 0x000E4590
		static UInterpCurveEdSetup()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.InterpCurveEdSetup");
		}

		// Token: 0x0600A226 RID: 41510 RVA: 0x000E639E File Offset: 0x000E459E
		protected UInterpCurveEdSetup(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040058F3 RID: 22771
		public new const string __ObjectPath = "/Script/Engine.InterpCurveEdSetup";

		// Token: 0x040058F4 RID: 22772
		private static IntPtr _ClassPtr;

		// Token: 0x040058F5 RID: 22773
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040058F6 RID: 22774
		internal static int __PropertyOffset_Tabs;

		// Token: 0x040058F7 RID: 22775
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FCurveEdTab> _Tabs;

		// Token: 0x040058F8 RID: 22776
		internal static int __PropertyOffset_ActiveTab;
	}
}
