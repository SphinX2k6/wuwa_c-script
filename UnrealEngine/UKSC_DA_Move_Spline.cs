using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001DA5 RID: 7589
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_DA_Move_Spline")]
	[UnrealStructLayout(112, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 112)]
	public class UKSC_DA_Move_Spline : UKSC_DA_Move, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601D054 RID: 118868 RVA: 0x002AE423 File Offset: 0x002AC623
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_DA_Move_Spline._ClassPtr;
		}

		// Token: 0x0601D055 RID: 118869 RVA: 0x002AE430 File Offset: 0x002AC630
		public UKSC_DA_Move_Spline() : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Move_Spline.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601D056 RID: 118870 RVA: 0x002AE458 File Offset: 0x002AC658
		[NullableContext(1)]
		public UKSC_DA_Move_Spline(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Move_Spline.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007513 RID: 29971
		// (get) Token: 0x0601D057 RID: 118871 RVA: 0x002AE48B File Offset: 0x002AC68B
		// (set) Token: 0x0601D058 RID: 118872 RVA: 0x002AE49B File Offset: 0x002AC69B
		public unsafe bool RunAnim
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Move_Spline.__PropertyOffset_RunAnim) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Move_Spline.__PropertyOffset_RunAnim) = (value ? 1 : 0);
			}
		}

		// Token: 0x0601D059 RID: 118873 RVA: 0x002AE4AC File Offset: 0x002AC6AC
		static UKSC_DA_Move_Spline()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_DA_Move_Spline");
		}

		// Token: 0x0601D05A RID: 118874 RVA: 0x002AE4BA File Offset: 0x002AC6BA
		protected UKSC_DA_Move_Spline(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FC0C RID: 64524
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_DA_Move_Spline";

		// Token: 0x0400FC0D RID: 64525
		private static IntPtr _ClassPtr;

		// Token: 0x0400FC0E RID: 64526
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FC0F RID: 64527
		internal static int __PropertyOffset_RunAnim;
	}
}
