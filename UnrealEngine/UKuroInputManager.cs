using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020018E0 RID: 6368
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroGameplay.KuroInputManager")]
	[UnrealStructLayout(144, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 144)]
	public class UKuroInputManager : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601795A RID: 96602 RVA: 0x002286EA File Offset: 0x002268EA
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroInputManager._ClassPtr;
		}

		// Token: 0x0601795B RID: 96603 RVA: 0x002286F8 File Offset: 0x002268F8
		public UKuroInputManager() : this(BuiltinUtils.AllocNativeUObject(UKuroInputManager.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601795C RID: 96604 RVA: 0x00228720 File Offset: 0x00226920
		public UKuroInputManager(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroInputManager.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005EF6 RID: 24310
		// (get) Token: 0x0601795D RID: 96605 RVA: 0x00228754 File Offset: 0x00226954
		// (set) Token: 0x0601795E RID: 96606 RVA: 0x0022878D File Offset: 0x0022698D
		public TArray<UKuroInputEvent> HoldEvents
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UKuroInputEvent> result;
				if ((result = this._HoldEvents) == null)
				{
					result = (this._HoldEvents = new TArray<UKuroInputEvent>(base.NativePtr + (IntPtr)UKuroInputManager.__PropertyOffset_HoldEvents, this));
				}
				return result;
			}
			set
			{
				this.HoldEvents.CopyAssign(value);
			}
		}

		// Token: 0x0601795F RID: 96607 RVA: 0x0022879C File Offset: 0x0022699C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OnActorDestroy(AActor Actor)
		{
			UKuroInputManager.__OnActorDestroy_FunctionParams* ptr = stackalloc UKuroInputManager.__OnActorDestroy_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UKuroInputManager.__OnActorDestroy_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroInputManager.__OnActorDestroy_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Actor = ((Actor != null) ? Actor.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroInputManager.__OnActorDestroy_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06017960 RID: 96608 RVA: 0x002287F2 File Offset: 0x002269F2
		static UKuroInputManager()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGameplay.KuroInputManager");
		}

		// Token: 0x06017961 RID: 96609 RVA: 0x00228800 File Offset: 0x00226A00
		protected UKuroInputManager(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400CCCD RID: 52429
		public new const string __ObjectPath = "/Script/KuroGameplay.KuroInputManager";

		// Token: 0x0400CCCE RID: 52430
		private static IntPtr _ClassPtr;

		// Token: 0x0400CCCF RID: 52431
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400CCD0 RID: 52432
		internal static int __PropertyOffset_HoldEvents;

		// Token: 0x0400CCD1 RID: 52433
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UKuroInputEvent> _HoldEvents;

		// Token: 0x0400CCD2 RID: 52434
		private static IntPtr __OnActorDestroy_NativeFunctionPtr;

		// Token: 0x02002FC1 RID: 12225
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __OnActorDestroy_FunctionParams
		{
			// Token: 0x04016BA6 RID: 93094
			[FieldOffset(0)]
			public IntPtr Actor;
		}
	}
}
