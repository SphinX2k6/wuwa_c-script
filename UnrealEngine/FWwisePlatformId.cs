using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002A90 RID: 10896
	[HasGetTypeHash]
	[UnrealObjectPath("/Script/WwiseResourceLoader.WwisePlatformId")]
	[UnrealStructLayout(52, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 52)]
	public class FWwisePlatformId : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060282B9 RID: 164537 RVA: 0x003D1E4E File Offset: 0x003D004E
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FWwisePlatformId._ScriptStructPtr != 0) ? FWwisePlatformId._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/WwiseResourceLoader.WwisePlatformId", ref FWwisePlatformId._ScriptStructPtr);
		}

		// Token: 0x17009947 RID: 39239
		// (get) Token: 0x060282BA RID: 164538 RVA: 0x003D1E72 File Offset: 0x003D0072
		// (set) Token: 0x060282BB RID: 164539 RVA: 0x003D1E86 File Offset: 0x003D0086
		public unsafe FGuid PlatformGuid
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FWwisePlatformId.__PropertyOffset_PlatformGuid);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FWwisePlatformId.__PropertyOffset_PlatformGuid) = value;
			}
		}

		// Token: 0x17009948 RID: 39240
		// (get) Token: 0x060282BC RID: 164540 RVA: 0x003D1E9B File Offset: 0x003D009B
		// (set) Token: 0x060282BD RID: 164541 RVA: 0x003D1EAF File Offset: 0x003D00AF
		public unsafe FName PlatformName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FWwisePlatformId.__PropertyOffset_PlatformName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FWwisePlatformId.__PropertyOffset_PlatformName) = value;
			}
		}

		// Token: 0x060282BE RID: 164542 RVA: 0x003D1EC4 File Offset: 0x003D00C4
		public FWwisePlatformId()
		{
		}

		// Token: 0x060282BF RID: 164543 RVA: 0x003D1ECC File Offset: 0x003D00CC
		public FWwisePlatformId(FGuid PlatformGuid, FName PlatformName, FName PathRelativeToGeneratedSoundBanks, FName ExternalSourceRootPath)
		{
			this.PlatformGuid = PlatformGuid;
			this.PlatformName = PlatformName;
		}

		// Token: 0x060282C0 RID: 164544 RVA: 0x003D1EE2 File Offset: 0x003D00E2
		protected override IntPtr GetUStructPtr()
		{
			return FWwisePlatformId.StaticStruct();
		}

		// Token: 0x060282C1 RID: 164545 RVA: 0x003D1EEE File Offset: 0x003D00EE
		[NullableContext(2)]
		public FWwisePlatformId(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060282C2 RID: 164546 RVA: 0x003D1EF8 File Offset: 0x003D00F8
		public FWwisePlatformId(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060282C3 RID: 164547 RVA: 0x003D1F03 File Offset: 0x003D0103
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FWwisePlatformId(Pointer, false, true);
		}

		// Token: 0x060282C4 RID: 164548 RVA: 0x003D1F0D File Offset: 0x003D010D
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FWwisePlatformId(Pointer, MemoryOwner);
		}

		// Token: 0x0401607C RID: 90236
		[Nullable(1)]
		public const string __ObjectPath = "/Script/WwiseResourceLoader.WwisePlatformId";

		// Token: 0x0401607D RID: 90237
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401607E RID: 90238
		internal static int __PropertyOffset_PlatformGuid;

		// Token: 0x0401607F RID: 90239
		internal static int __PropertyOffset_PlatformName;
	}
}
