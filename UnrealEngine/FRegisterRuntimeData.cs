using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020020FD RID: 8445
	[UnrealObjectPath("/Script/LGUI.RegisterRuntimeData")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FRegisterRuntimeData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601FC70 RID: 130160 RVA: 0x002F41F0 File Offset: 0x002F23F0
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRegisterRuntimeData._ScriptStructPtr != 0) ? FRegisterRuntimeData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/LGUI.RegisterRuntimeData", ref FRegisterRuntimeData._ScriptStructPtr);
		}

		// Token: 0x17007D05 RID: 32005
		// (get) Token: 0x0601FC71 RID: 130161 RVA: 0x002F4214 File Offset: 0x002F2414
		// (set) Token: 0x0601FC72 RID: 130162 RVA: 0x002F4228 File Offset: 0x002F2428
		[Nullable(2)]
		public unsafe AActor TargetActor
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + FRegisterRuntimeData.__PropertyOffset_TargetActor);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FRegisterRuntimeData.__PropertyOffset_TargetActor, value);
			}
		}

		// Token: 0x17007D06 RID: 32006
		// (get) Token: 0x0601FC73 RID: 130163 RVA: 0x002F423D File Offset: 0x002F243D
		// (set) Token: 0x0601FC74 RID: 130164 RVA: 0x002F4251 File Offset: 0x002F2451
		public unsafe UClassStackOnlyPtr TargetComponentClass
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRegisterRuntimeData.__PropertyOffset_TargetComponentClass);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRegisterRuntimeData.__PropertyOffset_TargetComponentClass) = value;
			}
		}

		// Token: 0x17007D07 RID: 32007
		// (get) Token: 0x0601FC75 RID: 130165 RVA: 0x002F4266 File Offset: 0x002F2466
		// (set) Token: 0x0601FC76 RID: 130166 RVA: 0x002F427A File Offset: 0x002F247A
		public unsafe FName ComponentName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRegisterRuntimeData.__PropertyOffset_ComponentName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRegisterRuntimeData.__PropertyOffset_ComponentName) = value;
			}
		}

		// Token: 0x0601FC77 RID: 130167 RVA: 0x002F428F File Offset: 0x002F248F
		public FRegisterRuntimeData()
		{
		}

		// Token: 0x0601FC78 RID: 130168 RVA: 0x002F4297 File Offset: 0x002F2497
		[NullableContext(1)]
		public FRegisterRuntimeData(AActor TargetActor, UClassStackOnlyPtr TargetComponentClass, FName ComponentName)
		{
			this.TargetActor = TargetActor;
			this.TargetComponentClass = TargetComponentClass;
			this.ComponentName = ComponentName;
		}

		// Token: 0x0601FC79 RID: 130169 RVA: 0x002F42B4 File Offset: 0x002F24B4
		protected override IntPtr GetUStructPtr()
		{
			return FRegisterRuntimeData.StaticStruct();
		}

		// Token: 0x0601FC7A RID: 130170 RVA: 0x002F42C0 File Offset: 0x002F24C0
		[NullableContext(2)]
		public FRegisterRuntimeData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601FC7B RID: 130171 RVA: 0x002F42CA File Offset: 0x002F24CA
		public FRegisterRuntimeData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601FC7C RID: 130172 RVA: 0x002F42D5 File Offset: 0x002F24D5
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRegisterRuntimeData(Pointer, false, true);
		}

		// Token: 0x0601FC7D RID: 130173 RVA: 0x002F42DF File Offset: 0x002F24DF
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRegisterRuntimeData(Pointer, MemoryOwner);
		}

		// Token: 0x04011207 RID: 70151
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.RegisterRuntimeData";

		// Token: 0x04011208 RID: 70152
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04011209 RID: 70153
		internal static int __PropertyOffset_TargetActor;

		// Token: 0x0401120A RID: 70154
		internal static int __PropertyOffset_TargetComponentClass;

		// Token: 0x0401120B RID: 70155
		internal static int __PropertyOffset_ComponentName;
	}
}
