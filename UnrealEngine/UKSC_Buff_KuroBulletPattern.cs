using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001D1A RID: 7450
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_Buff_KuroBulletPattern")]
	[UnrealStructLayout(112, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 112)]
	public class UKSC_Buff_KuroBulletPattern : UKSC_Buff, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601C9C1 RID: 117185 RVA: 0x002A4B22 File Offset: 0x002A2D22
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_Buff_KuroBulletPattern._ClassPtr;
		}

		// Token: 0x0601C9C2 RID: 117186 RVA: 0x002A4B30 File Offset: 0x002A2D30
		public UKSC_Buff_KuroBulletPattern() : this(BuiltinUtils.AllocNativeUObject(UKSC_Buff_KuroBulletPattern.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601C9C3 RID: 117187 RVA: 0x002A4B58 File Offset: 0x002A2D58
		[NullableContext(1)]
		public UKSC_Buff_KuroBulletPattern(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_Buff_KuroBulletPattern.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700732B RID: 29483
		// (get) Token: 0x0601C9C4 RID: 117188 RVA: 0x002A4B8B File Offset: 0x002A2D8B
		// (set) Token: 0x0601C9C5 RID: 117189 RVA: 0x002A4B9F File Offset: 0x002A2D9F
		[Nullable(2)]
		public unsafe UKSC_DA_Buff_KuroBulletPattern Da_Buff_KuroBulletPattern
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_DA_Buff_KuroBulletPattern>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Buff_KuroBulletPattern.__PropertyOffset_Da_Buff_KuroBulletPattern);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Buff_KuroBulletPattern.__PropertyOffset_Da_Buff_KuroBulletPattern, value);
			}
		}

		// Token: 0x0601C9C6 RID: 117190 RVA: 0x002A4BB4 File Offset: 0x002A2DB4
		static UKSC_Buff_KuroBulletPattern()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_Buff_KuroBulletPattern");
		}

		// Token: 0x0601C9C7 RID: 117191 RVA: 0x002A4BC2 File Offset: 0x002A2DC2
		protected UKSC_Buff_KuroBulletPattern(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F824 RID: 63524
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_Buff_KuroBulletPattern";

		// Token: 0x0400F825 RID: 63525
		private static IntPtr _ClassPtr;

		// Token: 0x0400F826 RID: 63526
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F827 RID: 63527
		internal static int __PropertyOffset_Da_Buff_KuroBulletPattern;
	}
}
