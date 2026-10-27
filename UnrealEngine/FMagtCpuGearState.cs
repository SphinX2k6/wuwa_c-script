using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002272 RID: 8818
	[UnrealObjectPath("/Script/MagtModule.MagtCpuGearState")]
	[UnrealStructLayout(12, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 12)]
	public class FMagtCpuGearState : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602183D RID: 137277 RVA: 0x003182B1 File Offset: 0x003164B1
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMagtCpuGearState._ScriptStructPtr != 0) ? FMagtCpuGearState._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MagtModule.MagtCpuGearState", ref FMagtCpuGearState._ScriptStructPtr);
		}

		// Token: 0x17008251 RID: 33361
		// (get) Token: 0x0602183E RID: 137278 RVA: 0x003182D5 File Offset: 0x003164D5
		// (set) Token: 0x0602183F RID: 137279 RVA: 0x003182E5 File Offset: 0x003164E5
		public unsafe int LittleClusterLevel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMagtCpuGearState.__PropertyOffset_LittleClusterLevel);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMagtCpuGearState.__PropertyOffset_LittleClusterLevel) = value;
			}
		}

		// Token: 0x17008252 RID: 33362
		// (get) Token: 0x06021840 RID: 137280 RVA: 0x003182F6 File Offset: 0x003164F6
		// (set) Token: 0x06021841 RID: 137281 RVA: 0x00318306 File Offset: 0x00316506
		public unsafe int MiddleClusterLevel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMagtCpuGearState.__PropertyOffset_MiddleClusterLevel);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMagtCpuGearState.__PropertyOffset_MiddleClusterLevel) = value;
			}
		}

		// Token: 0x17008253 RID: 33363
		// (get) Token: 0x06021842 RID: 137282 RVA: 0x00318317 File Offset: 0x00316517
		// (set) Token: 0x06021843 RID: 137283 RVA: 0x00318327 File Offset: 0x00316527
		public unsafe int BigClusterLevel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMagtCpuGearState.__PropertyOffset_BigClusterLevel);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMagtCpuGearState.__PropertyOffset_BigClusterLevel) = value;
			}
		}

		// Token: 0x06021844 RID: 137284 RVA: 0x00318338 File Offset: 0x00316538
		public FMagtCpuGearState()
		{
		}

		// Token: 0x06021845 RID: 137285 RVA: 0x00318340 File Offset: 0x00316540
		public FMagtCpuGearState(int LittleClusterLevel, int MiddleClusterLevel, int BigClusterLevel)
		{
			this.LittleClusterLevel = LittleClusterLevel;
			this.MiddleClusterLevel = MiddleClusterLevel;
			this.BigClusterLevel = BigClusterLevel;
		}

		// Token: 0x06021846 RID: 137286 RVA: 0x0031835D File Offset: 0x0031655D
		protected override IntPtr GetUStructPtr()
		{
			return FMagtCpuGearState.StaticStruct();
		}

		// Token: 0x06021847 RID: 137287 RVA: 0x00318369 File Offset: 0x00316569
		[NullableContext(2)]
		public FMagtCpuGearState(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06021848 RID: 137288 RVA: 0x00318373 File Offset: 0x00316573
		public FMagtCpuGearState(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06021849 RID: 137289 RVA: 0x0031837E File Offset: 0x0031657E
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMagtCpuGearState(Pointer, false, true);
		}

		// Token: 0x0602184A RID: 137290 RVA: 0x00318388 File Offset: 0x00316588
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMagtCpuGearState(Pointer, MemoryOwner);
		}

		// Token: 0x04011E48 RID: 73288
		[Nullable(1)]
		public const string __ObjectPath = "/Script/MagtModule.MagtCpuGearState";

		// Token: 0x04011E49 RID: 73289
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04011E4A RID: 73290
		internal static int __PropertyOffset_LittleClusterLevel;

		// Token: 0x04011E4B RID: 73291
		internal static int __PropertyOffset_MiddleClusterLevel;

		// Token: 0x04011E4C RID: 73292
		internal static int __PropertyOffset_BigClusterLevel;
	}
}
