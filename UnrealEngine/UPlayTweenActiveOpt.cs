using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020020F9 RID: 8441
	[UnrealObjectPath("/Script/LGUI.PlayTweenActiveOpt")]
	[UnrealStructLayout(280, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 280)]
	public class UPlayTweenActiveOpt : ULGUIBehaviour, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601FC4E RID: 130126 RVA: 0x002F3F3E File Offset: 0x002F213E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UPlayTweenActiveOpt._ClassPtr;
		}

		// Token: 0x0601FC4F RID: 130127 RVA: 0x002F3F4C File Offset: 0x002F214C
		public UPlayTweenActiveOpt() : this(BuiltinUtils.AllocNativeUObject(UPlayTweenActiveOpt.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601FC50 RID: 130128 RVA: 0x002F3F74 File Offset: 0x002F2174
		[NullableContext(1)]
		public UPlayTweenActiveOpt(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UPlayTweenActiveOpt.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007D01 RID: 32001
		// (get) Token: 0x0601FC51 RID: 130129 RVA: 0x002F3FA7 File Offset: 0x002F21A7
		// (set) Token: 0x0601FC52 RID: 130130 RVA: 0x002F3FBB File Offset: 0x002F21BB
		[Nullable(2)]
		public unsafe ULGUIPlayTweenComponent PlayTweenComponent
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ULGUIPlayTweenComponent>(base.NativePtr / (IntPtr)sizeof(void*) + UPlayTweenActiveOpt.__PropertyOffset_PlayTweenComponent);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UPlayTweenActiveOpt.__PropertyOffset_PlayTweenComponent, value);
			}
		}

		// Token: 0x0601FC53 RID: 130131 RVA: 0x002F3FD0 File Offset: 0x002F21D0
		static UPlayTweenActiveOpt()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.PlayTweenActiveOpt");
		}

		// Token: 0x0601FC54 RID: 130132 RVA: 0x002F3FDE File Offset: 0x002F21DE
		protected UPlayTweenActiveOpt(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040111F8 RID: 70136
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.PlayTweenActiveOpt";

		// Token: 0x040111F9 RID: 70137
		private static IntPtr _ClassPtr;

		// Token: 0x040111FA RID: 70138
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040111FB RID: 70139
		internal static int __PropertyOffset_PlayTweenComponent;
	}
}
