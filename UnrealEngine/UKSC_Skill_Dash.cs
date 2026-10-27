using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001E48 RID: 7752
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_Skill_Dash")]
	[UnrealStructLayout(216, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 216)]
	public class UKSC_Skill_Dash : UKSC_Skill_Anim, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601D876 RID: 120950 RVA: 0x002B9A17 File Offset: 0x002B7C17
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_Skill_Dash._ClassPtr;
		}

		// Token: 0x0601D877 RID: 120951 RVA: 0x002B9A24 File Offset: 0x002B7C24
		public UKSC_Skill_Dash() : this(BuiltinUtils.AllocNativeUObject(UKSC_Skill_Dash.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601D878 RID: 120952 RVA: 0x002B9A4C File Offset: 0x002B7C4C
		[NullableContext(1)]
		public UKSC_Skill_Dash(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_Skill_Dash.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170076F6 RID: 30454
		// (get) Token: 0x0601D879 RID: 120953 RVA: 0x002B9A7F File Offset: 0x002B7C7F
		// (set) Token: 0x0601D87A RID: 120954 RVA: 0x002B9A93 File Offset: 0x002B7C93
		[Nullable(2)]
		public unsafe UKSC_DA_Skill_Dash Dash
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_DA_Skill_Dash>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Skill_Dash.__PropertyOffset_Dash);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Skill_Dash.__PropertyOffset_Dash, value);
			}
		}

		// Token: 0x0601D87B RID: 120955 RVA: 0x002B9AA8 File Offset: 0x002B7CA8
		static UKSC_Skill_Dash()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_Skill_Dash");
		}

		// Token: 0x0601D87C RID: 120956 RVA: 0x002B9AB6 File Offset: 0x002B7CB6
		protected UKSC_Skill_Dash(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401001F RID: 65567
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_Skill_Dash";

		// Token: 0x04010020 RID: 65568
		private static IntPtr _ClassPtr;

		// Token: 0x04010021 RID: 65569
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010022 RID: 65570
		internal static int __PropertyOffset_Dash;
	}
}
