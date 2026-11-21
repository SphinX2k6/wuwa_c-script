using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000574 RID: 1396
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_DA_Shape2D_WorldBounds")]
	[UnrealStructLayout(120, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 120)]
	public class UKSC_DA_Shape2D_WorldBounds : UKSC_DA_WorldBounds, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06007EF0 RID: 32496 RVA: 0x000BBFF3 File Offset: 0x000BA1F3
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_DA_Shape2D_WorldBounds._ClassPtr;
		}

		// Token: 0x06007EF1 RID: 32497 RVA: 0x000BC000 File Offset: 0x000BA200
		public UKSC_DA_Shape2D_WorldBounds() : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Shape2D_WorldBounds.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06007EF2 RID: 32498 RVA: 0x000BC028 File Offset: 0x000BA228
		[NullableContext(1)]
		public UKSC_DA_Shape2D_WorldBounds(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Shape2D_WorldBounds.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170018A7 RID: 6311
		// (get) Token: 0x06007EF3 RID: 32499 RVA: 0x000BC05B File Offset: 0x000BA25B
		// (set) Token: 0x06007EF4 RID: 32500 RVA: 0x000BC06F File Offset: 0x000BA26F
		public unsafe FVectorDouble WorldCenterOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Shape2D_WorldBounds.__PropertyOffset_WorldCenterOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Shape2D_WorldBounds.__PropertyOffset_WorldCenterOffset) = value;
			}
		}

		// Token: 0x06007EF5 RID: 32501 RVA: 0x000BC084 File Offset: 0x000BA284
		static UKSC_DA_Shape2D_WorldBounds()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_DA_Shape2D_WorldBounds");
		}

		// Token: 0x06007EF6 RID: 32502 RVA: 0x000BC092 File Offset: 0x000BA292
		protected UKSC_DA_Shape2D_WorldBounds(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003772 RID: 14194
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_DA_Shape2D_WorldBounds";

		// Token: 0x04003773 RID: 14195
		private static IntPtr _ClassPtr;

		// Token: 0x04003774 RID: 14196
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04003775 RID: 14197
		internal static int __PropertyOffset_WorldCenterOffset;
	}
}
