using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020014F4 RID: 5364
	[UnrealObjectPath("/Script/HoudiniEngineRuntime.HoudiniParameterOperatorPath")]
	[UnrealStructLayout(280, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 280)]
	public class UHoudiniParameterOperatorPath : UHoudiniParameter, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601370F RID: 79631 RVA: 0x001C94B7 File Offset: 0x001C76B7
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UHoudiniParameterOperatorPath._ClassPtr;
		}

		// Token: 0x06013710 RID: 79632 RVA: 0x001C94C4 File Offset: 0x001C76C4
		public UHoudiniParameterOperatorPath() : this(BuiltinUtils.AllocNativeUObject(UHoudiniParameterOperatorPath.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06013711 RID: 79633 RVA: 0x001C94EC File Offset: 0x001C76EC
		[NullableContext(1)]
		public UHoudiniParameterOperatorPath(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UHoudiniParameterOperatorPath.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004BF1 RID: 19441
		// (get) Token: 0x06013712 RID: 79634 RVA: 0x001C951F File Offset: 0x001C771F
		// (set) Token: 0x06013713 RID: 79635 RVA: 0x001C9533 File Offset: 0x001C7733
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TWeakObjectPtr<UHoudiniInput> HoudiniInput
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniParameterOperatorPath.__PropertyOffset_HoudiniInput);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniParameterOperatorPath.__PropertyOffset_HoudiniInput) = value;
			}
		}

		// Token: 0x06013714 RID: 79636 RVA: 0x001C9548 File Offset: 0x001C7748
		static UHoudiniParameterOperatorPath()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/HoudiniEngineRuntime.HoudiniParameterOperatorPath");
		}

		// Token: 0x06013715 RID: 79637 RVA: 0x001C9556 File Offset: 0x001C7756
		protected UHoudiniParameterOperatorPath(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400A81A RID: 43034
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/HoudiniEngineRuntime.HoudiniParameterOperatorPath";

		// Token: 0x0400A81B RID: 43035
		private static IntPtr _ClassPtr;

		// Token: 0x0400A81C RID: 43036
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400A81D RID: 43037
		internal static int __PropertyOffset_HoudiniInput;
	}
}
