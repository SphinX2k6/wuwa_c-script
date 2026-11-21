using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000576 RID: 1398
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_DA_WorldBounds")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 80)]
	public class UKSC_DA_WorldBounds : UDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06007F39 RID: 32569 RVA: 0x000BC589 File Offset: 0x000BA789
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_DA_WorldBounds._ClassPtr;
		}

		// Token: 0x06007F3A RID: 32570 RVA: 0x000BC598 File Offset: 0x000BA798
		public UKSC_DA_WorldBounds() : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_WorldBounds.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06007F3B RID: 32571 RVA: 0x000BC5C0 File Offset: 0x000BA7C0
		[NullableContext(1)]
		public UKSC_DA_WorldBounds(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_WorldBounds.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170018C7 RID: 6343
		// (get) Token: 0x06007F3C RID: 32572 RVA: 0x000BC5F3 File Offset: 0x000BA7F3
		// (set) Token: 0x06007F3D RID: 32573 RVA: 0x000BC603 File Offset: 0x000BA803
		public unsafe float GroundPositionZ
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_WorldBounds.__PropertyOffset_GroundPositionZ);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_WorldBounds.__PropertyOffset_GroundPositionZ) = value;
			}
		}

		// Token: 0x06007F3E RID: 32574 RVA: 0x000BC614 File Offset: 0x000BA814
		static UKSC_DA_WorldBounds()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_DA_WorldBounds");
		}

		// Token: 0x06007F3F RID: 32575 RVA: 0x000BC622 File Offset: 0x000BA822
		protected UKSC_DA_WorldBounds(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400379A RID: 14234
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_DA_WorldBounds";

		// Token: 0x0400379B RID: 14235
		private static IntPtr _ClassPtr;

		// Token: 0x0400379C RID: 14236
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400379D RID: 14237
		internal static int __PropertyOffset_GroundPositionZ;
	}
}
