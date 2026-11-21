using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000210 RID: 528
	[UnrealObjectPath("/Script/Engine.ForceFeedbackEffect")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 88)]
	public class UForceFeedbackEffect : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060021E9 RID: 8681 RVA: 0x00031B6F File Offset: 0x0002FD6F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UForceFeedbackEffect._ClassPtr;
		}

		// Token: 0x060021EA RID: 8682 RVA: 0x00031B7C File Offset: 0x0002FD7C
		public UForceFeedbackEffect() : this(BuiltinUtils.AllocNativeUObject(UForceFeedbackEffect.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060021EB RID: 8683 RVA: 0x00031BA4 File Offset: 0x0002FDA4
		[NullableContext(1)]
		public UForceFeedbackEffect(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UForceFeedbackEffect.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170004CC RID: 1228
		// (get) Token: 0x060021EC RID: 8684 RVA: 0x00031BD7 File Offset: 0x0002FDD7
		// (set) Token: 0x060021ED RID: 8685 RVA: 0x00031BE7 File Offset: 0x0002FDE7
		public unsafe float Duration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UForceFeedbackEffect.__PropertyOffset_Duration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UForceFeedbackEffect.__PropertyOffset_Duration) = value;
			}
		}

		// Token: 0x060021EE RID: 8686 RVA: 0x00031BF8 File Offset: 0x0002FDF8
		static UForceFeedbackEffect()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.ForceFeedbackEffect");
		}

		// Token: 0x060021EF RID: 8687 RVA: 0x00031C06 File Offset: 0x0002FE06
		protected UForceFeedbackEffect(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000D48 RID: 3400
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.ForceFeedbackEffect";

		// Token: 0x04000D49 RID: 3401
		private static IntPtr _ClassPtr;

		// Token: 0x04000D4A RID: 3402
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04000D4B RID: 3403
		internal static int __PropertyOffset_Duration;
	}
}
