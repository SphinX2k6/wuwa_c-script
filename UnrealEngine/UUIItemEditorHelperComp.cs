using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200217D RID: 8573
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.UIItemEditorHelperComp")]
	[UnrealStructLayout(1584, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1584)]
	public class UUIItemEditorHelperComp : UPrimitiveComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06020769 RID: 132969 RVA: 0x00301D65 File Offset: 0x002FFF65
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUIItemEditorHelperComp._ClassPtr;
		}

		// Token: 0x0602076A RID: 132970 RVA: 0x00301D74 File Offset: 0x002FFF74
		public UUIItemEditorHelperComp() : this(BuiltinUtils.AllocNativeUObject(UUIItemEditorHelperComp.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602076B RID: 132971 RVA: 0x00301D9C File Offset: 0x002FFF9C
		[NullableContext(1)]
		public UUIItemEditorHelperComp(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUIItemEditorHelperComp.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007F0C RID: 32524
		// (get) Token: 0x0602076C RID: 132972 RVA: 0x00301DCF File Offset: 0x002FFFCF
		// (set) Token: 0x0602076D RID: 132973 RVA: 0x00301DE3 File Offset: 0x002FFFE3
		public unsafe UUIItem Parent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UUIItem>(base.NativePtr / (IntPtr)sizeof(void*) + UUIItemEditorHelperComp.__PropertyOffset_Parent);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UUIItemEditorHelperComp.__PropertyOffset_Parent, value);
			}
		}

		// Token: 0x17007F0D RID: 32525
		// (get) Token: 0x0602076E RID: 132974 RVA: 0x00301DF8 File Offset: 0x002FFFF8
		// (set) Token: 0x0602076F RID: 132975 RVA: 0x00301E0C File Offset: 0x0030000C
		public unsafe UBodySetup BodySetup
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBodySetup>(base.NativePtr / (IntPtr)sizeof(void*) + UUIItemEditorHelperComp.__PropertyOffset_BodySetup);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UUIItemEditorHelperComp.__PropertyOffset_BodySetup, value);
			}
		}

		// Token: 0x06020770 RID: 132976 RVA: 0x00301E21 File Offset: 0x00300021
		static UUIItemEditorHelperComp()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UIItemEditorHelperComp");
		}

		// Token: 0x06020771 RID: 132977 RVA: 0x00301E2F File Offset: 0x0030002F
		protected UUIItemEditorHelperComp(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401165C RID: 71260
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.UIItemEditorHelperComp";

		// Token: 0x0401165D RID: 71261
		private static IntPtr _ClassPtr;

		// Token: 0x0401165E RID: 71262
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401165F RID: 71263
		internal static int __PropertyOffset_Parent;

		// Token: 0x04011660 RID: 71264
		internal static int __PropertyOffset_BodySetup;
	}
}
