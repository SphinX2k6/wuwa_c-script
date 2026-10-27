using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001DAE RID: 7598
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_DA_Shape2DMove")]
	[UnrealStructLayout(112, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 112)]
	public class UKSC_DA_Shape2DMove : UKSC_DA_Move, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601D0B3 RID: 118963 RVA: 0x002AECF2 File Offset: 0x002ACEF2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_DA_Shape2DMove._ClassPtr;
		}

		// Token: 0x0601D0B4 RID: 118964 RVA: 0x002AED00 File Offset: 0x002ACF00
		public UKSC_DA_Shape2DMove() : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Shape2DMove.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601D0B5 RID: 118965 RVA: 0x002AED28 File Offset: 0x002ACF28
		[NullableContext(1)]
		public UKSC_DA_Shape2DMove(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Shape2DMove.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700752C RID: 29996
		// (get) Token: 0x0601D0B6 RID: 118966 RVA: 0x002AED5B File Offset: 0x002ACF5B
		// (set) Token: 0x0601D0B7 RID: 118967 RVA: 0x002AED6B File Offset: 0x002ACF6B
		public unsafe float GravityRatio
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Shape2DMove.__PropertyOffset_GravityRatio);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Shape2DMove.__PropertyOffset_GravityRatio) = value;
			}
		}

		// Token: 0x1700752D RID: 29997
		// (get) Token: 0x0601D0B8 RID: 118968 RVA: 0x002AED7C File Offset: 0x002ACF7C
		// (set) Token: 0x0601D0B9 RID: 118969 RVA: 0x002AED8C File Offset: 0x002ACF8C
		public unsafe float BounceRandomOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Shape2DMove.__PropertyOffset_BounceRandomOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Shape2DMove.__PropertyOffset_BounceRandomOffset) = value;
			}
		}

		// Token: 0x0601D0BA RID: 118970 RVA: 0x002AED9D File Offset: 0x002ACF9D
		static UKSC_DA_Shape2DMove()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_DA_Shape2DMove");
		}

		// Token: 0x0601D0BB RID: 118971 RVA: 0x002AEDAB File Offset: 0x002ACFAB
		protected UKSC_DA_Shape2DMove(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FC46 RID: 64582
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_DA_Shape2DMove";

		// Token: 0x0400FC47 RID: 64583
		private static IntPtr _ClassPtr;

		// Token: 0x0400FC48 RID: 64584
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FC49 RID: 64585
		internal static int __PropertyOffset_GravityRatio;

		// Token: 0x0400FC4A RID: 64586
		internal static int __PropertyOffset_BounceRandomOffset;
	}
}
