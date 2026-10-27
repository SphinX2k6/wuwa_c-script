using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001B12 RID: 6930
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroGlobalMapOverrideSubsystem")]
	[UnrealStructLayout(120, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 120)]
	public class UKuroGlobalMapOverrideSubsystem : UWorldSubsystem, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601A117 RID: 106775 RVA: 0x00267A45 File Offset: 0x00265C45
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroGlobalMapOverrideSubsystem._ClassPtr;
		}

		// Token: 0x0601A118 RID: 106776 RVA: 0x00267A54 File Offset: 0x00265C54
		public UKuroGlobalMapOverrideSubsystem() : this(BuiltinUtils.AllocNativeUObject(UKuroGlobalMapOverrideSubsystem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601A119 RID: 106777 RVA: 0x00267A7C File Offset: 0x00265C7C
		[NullableContext(1)]
		public UKuroGlobalMapOverrideSubsystem(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroGlobalMapOverrideSubsystem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601A11A RID: 106778 RVA: 0x00267AAF File Offset: 0x00265CAF
		[NullableContext(2)]
		public UKuroGlobalMapOverrideComponent GetActiveOverride()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UKuroGlobalMapOverrideComponent>(UKuroGlobalMapOverrideSubsystem.__GetActiveOverride_Internal(base.NativePtr));
		}

		// Token: 0x0601A11B RID: 106779 RVA: 0x00267AC1 File Offset: 0x00265CC1
		[NullableContext(2)]
		public static UKuroGlobalMapOverrideSubsystem Get(UObject WorldContextObject)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UKuroGlobalMapOverrideSubsystem>(UKuroGlobalMapOverrideSubsystem.__Get_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero));
		}

		// Token: 0x0601A11C RID: 106780
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetActiveOverride_Internal(IntPtr @this);

		// Token: 0x0601A11D RID: 106781
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __Get_Internal(IntPtr WorldContextObject);

		// Token: 0x0601A11E RID: 106782 RVA: 0x00267ADD File Offset: 0x00265CDD
		static UKuroGlobalMapOverrideSubsystem()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroGlobalMapOverrideSubsystem");
		}

		// Token: 0x0601A11F RID: 106783 RVA: 0x00267AEB File Offset: 0x00265CEB
		protected UKuroGlobalMapOverrideSubsystem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400E27F RID: 57983
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroGlobalMapOverrideSubsystem";

		// Token: 0x0400E280 RID: 57984
		private static IntPtr _ClassPtr;

		// Token: 0x0400E281 RID: 57985
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
