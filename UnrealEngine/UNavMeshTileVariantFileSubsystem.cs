using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020024A2 RID: 9378
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/NavigationSystem.NavMeshTileVariantFileSubsystem")]
	[UnrealStructLayout(176, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 176)]
	public class UNavMeshTileVariantFileSubsystem : UWorldSubsystem, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06023199 RID: 143769 RVA: 0x0033E876 File Offset: 0x0033CA76
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNavMeshTileVariantFileSubsystem._ClassPtr;
		}

		// Token: 0x0602319A RID: 143770 RVA: 0x0033E884 File Offset: 0x0033CA84
		public UNavMeshTileVariantFileSubsystem() : this(BuiltinUtils.AllocNativeUObject(UNavMeshTileVariantFileSubsystem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602319B RID: 143771 RVA: 0x0033E8AC File Offset: 0x0033CAAC
		public UNavMeshTileVariantFileSubsystem(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UNavMeshTileVariantFileSubsystem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170086DE RID: 34526
		// (get) Token: 0x0602319C RID: 143772 RVA: 0x0033E8DF File Offset: 0x0033CADF
		// (set) Token: 0x0602319D RID: 143773 RVA: 0x0033E8F3 File Offset: 0x0033CAF3
		public unsafe string ResourcePath
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UNavMeshTileVariantFileSubsystem.__PropertyOffset_ResourcePath)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UNavMeshTileVariantFileSubsystem.__PropertyOffset_ResourcePath)), value);
			}
		}

		// Token: 0x0602319E RID: 143774 RVA: 0x0033E908 File Offset: 0x0033CB08
		public bool IsStreamingCompleted()
		{
			return UNavMeshTileVariantFileSubsystem.__IsStreamingCompleted_Internal(base.NativePtr);
		}

		// Token: 0x0602319F RID: 143775
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsStreamingCompleted_Internal(IntPtr @this);

		// Token: 0x060231A0 RID: 143776 RVA: 0x0033E915 File Offset: 0x0033CB15
		static UNavMeshTileVariantFileSubsystem()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/NavigationSystem.NavMeshTileVariantFileSubsystem");
		}

		// Token: 0x060231A1 RID: 143777 RVA: 0x0033E923 File Offset: 0x0033CB23
		protected UNavMeshTileVariantFileSubsystem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012BD0 RID: 76752
		public new const string __ObjectPath = "/Script/NavigationSystem.NavMeshTileVariantFileSubsystem";

		// Token: 0x04012BD1 RID: 76753
		private static IntPtr _ClassPtr;

		// Token: 0x04012BD2 RID: 76754
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012BD3 RID: 76755
		internal static int __PropertyOffset_ResourcePath;
	}
}
