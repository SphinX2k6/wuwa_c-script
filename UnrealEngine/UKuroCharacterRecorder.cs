using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020002F9 RID: 761
	[UnrealObjectPath("/Script/KuroAnim.KuroCharacterRecorder")]
	[UnrealStructLayout(496, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 496)]
	public class UKuroCharacterRecorder : UKuroTrackRecorder, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600527B RID: 21115 RVA: 0x000735D2 File Offset: 0x000717D2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroCharacterRecorder._ClassPtr;
		}

		// Token: 0x0600527C RID: 21116 RVA: 0x000735E0 File Offset: 0x000717E0
		public UKuroCharacterRecorder() : this(BuiltinUtils.AllocNativeUObject(UKuroCharacterRecorder.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600527D RID: 21117 RVA: 0x00073608 File Offset: 0x00071808
		[NullableContext(1)]
		public UKuroCharacterRecorder(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroCharacterRecorder.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001066 RID: 4198
		// (get) Token: 0x0600527E RID: 21118 RVA: 0x0007363B File Offset: 0x0007183B
		// (set) Token: 0x0600527F RID: 21119 RVA: 0x0007364B File Offset: 0x0007184B
		public unsafe bool bUseClone
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroCharacterRecorder.__PropertyOffset_bUseClone) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroCharacterRecorder.__PropertyOffset_bUseClone) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001067 RID: 4199
		// (get) Token: 0x06005280 RID: 21120 RVA: 0x0007365C File Offset: 0x0007185C
		// (set) Token: 0x06005281 RID: 21121 RVA: 0x0007366C File Offset: 0x0007186C
		public unsafe bool bRecordSkeletalMeshAnimSeq
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroCharacterRecorder.__PropertyOffset_bRecordSkeletalMeshAnimSeq) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroCharacterRecorder.__PropertyOffset_bRecordSkeletalMeshAnimSeq) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001068 RID: 4200
		// (get) Token: 0x06005282 RID: 21122 RVA: 0x0007367D File Offset: 0x0007187D
		// (set) Token: 0x06005283 RID: 21123 RVA: 0x0007368D File Offset: 0x0007188D
		public unsafe bool bComponentPossessable
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroCharacterRecorder.__PropertyOffset_bComponentPossessable) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroCharacterRecorder.__PropertyOffset_bComponentPossessable) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001069 RID: 4201
		// (get) Token: 0x06005284 RID: 21124 RVA: 0x0007369E File Offset: 0x0007189E
		// (set) Token: 0x06005285 RID: 21125 RVA: 0x000736AE File Offset: 0x000718AE
		public unsafe bool bActorPossessable
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroCharacterRecorder.__PropertyOffset_bActorPossessable) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroCharacterRecorder.__PropertyOffset_bActorPossessable) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700106A RID: 4202
		// (get) Token: 0x06005286 RID: 21126 RVA: 0x000736BF File Offset: 0x000718BF
		// (set) Token: 0x06005287 RID: 21127 RVA: 0x000736D3 File Offset: 0x000718D3
		[Nullable(2)]
		public unsafe UObject BaseBlueprint
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UObject>(base.NativePtr / (IntPtr)sizeof(void*) + UKuroCharacterRecorder.__PropertyOffset_BaseBlueprint);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKuroCharacterRecorder.__PropertyOffset_BaseBlueprint, value);
			}
		}

		// Token: 0x06005288 RID: 21128 RVA: 0x000736E8 File Offset: 0x000718E8
		static UKuroCharacterRecorder()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroAnim.KuroCharacterRecorder");
		}

		// Token: 0x06005289 RID: 21129 RVA: 0x000736F6 File Offset: 0x000718F6
		protected UKuroCharacterRecorder(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04002197 RID: 8599
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroAnim.KuroCharacterRecorder";

		// Token: 0x04002198 RID: 8600
		private static IntPtr _ClassPtr;

		// Token: 0x04002199 RID: 8601
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400219A RID: 8602
		internal static int __PropertyOffset_bUseClone;

		// Token: 0x0400219B RID: 8603
		internal static int __PropertyOffset_bRecordSkeletalMeshAnimSeq;

		// Token: 0x0400219C RID: 8604
		internal static int __PropertyOffset_bComponentPossessable;

		// Token: 0x0400219D RID: 8605
		internal static int __PropertyOffset_bActorPossessable;

		// Token: 0x0400219E RID: 8606
		internal static int __PropertyOffset_BaseBlueprint;
	}
}
