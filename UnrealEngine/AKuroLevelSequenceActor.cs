using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001B31 RID: 6961
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroLevelSequenceActor")]
	[UnrealStructLayout(1232, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1232)]
	public class AKuroLevelSequenceActor : ALevelSequenceActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601A477 RID: 107639 RVA: 0x0026C6CC File Offset: 0x0026A8CC
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKuroLevelSequenceActor._ClassPtr;
		}

		// Token: 0x0601A478 RID: 107640 RVA: 0x0026C6D8 File Offset: 0x0026A8D8
		public AKuroLevelSequenceActor() : this(BuiltinUtils.AllocNativeUObject(AKuroLevelSequenceActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601A479 RID: 107641 RVA: 0x0026C700 File Offset: 0x0026A900
		[NullableContext(1)]
		public AKuroLevelSequenceActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKuroLevelSequenceActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170069AE RID: 27054
		// (get) Token: 0x0601A47A RID: 107642 RVA: 0x0026C733 File Offset: 0x0026A933
		// (set) Token: 0x0601A47B RID: 107643 RVA: 0x0026C747 File Offset: 0x0026A947
		public unsafe FName Key
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroLevelSequenceActor.__PropertyOffset_Key);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroLevelSequenceActor.__PropertyOffset_Key) = value;
			}
		}

		// Token: 0x0601A47C RID: 107644 RVA: 0x0026C75C File Offset: 0x0026A95C
		static AKuroLevelSequenceActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroLevelSequenceActor");
		}

		// Token: 0x0601A47D RID: 107645 RVA: 0x0026C76A File Offset: 0x0026A96A
		protected AKuroLevelSequenceActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400E42E RID: 58414
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroLevelSequenceActor";

		// Token: 0x0400E42F RID: 58415
		private static IntPtr _ClassPtr;

		// Token: 0x0400E430 RID: 58416
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400E431 RID: 58417
		internal static int __PropertyOffset_Key;
	}
}
