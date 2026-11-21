using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020002CD RID: 717
	[HasGetTypeHash]
	[UnrealObjectPath("/Script/InputCore.Key")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FKey : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06004DEF RID: 19951 RVA: 0x0006CE4B File Offset: 0x0006B04B
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKey._ScriptStructPtr != 0) ? FKey._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/InputCore.Key", ref FKey._ScriptStructPtr);
		}

		// Token: 0x17000EF4 RID: 3828
		// (get) Token: 0x06004DF0 RID: 19952 RVA: 0x0006CE6F File Offset: 0x0006B06F
		// (set) Token: 0x06004DF1 RID: 19953 RVA: 0x0006CE83 File Offset: 0x0006B083
		public unsafe FName KeyName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKey.__PropertyOffset_KeyName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKey.__PropertyOffset_KeyName) = value;
			}
		}

		// Token: 0x06004DF2 RID: 19954 RVA: 0x0006CE98 File Offset: 0x0006B098
		public FKey()
		{
		}

		// Token: 0x06004DF3 RID: 19955 RVA: 0x0006CEA0 File Offset: 0x0006B0A0
		protected override IntPtr GetUStructPtr()
		{
			return FKey.StaticStruct();
		}

		// Token: 0x06004DF4 RID: 19956 RVA: 0x0006CEAC File Offset: 0x0006B0AC
		[NullableContext(2)]
		public FKey(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06004DF5 RID: 19957 RVA: 0x0006CEB6 File Offset: 0x0006B0B6
		public FKey(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06004DF6 RID: 19958 RVA: 0x0006CEC1 File Offset: 0x0006B0C1
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKey(Pointer, false, true);
		}

		// Token: 0x06004DF7 RID: 19959 RVA: 0x0006CECB File Offset: 0x0006B0CB
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKey(Pointer, MemoryOwner);
		}

		// Token: 0x04001F31 RID: 7985
		[Nullable(1)]
		public const string __ObjectPath = "/Script/InputCore.Key";

		// Token: 0x04001F32 RID: 7986
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04001F33 RID: 7987
		internal static int __PropertyOffset_KeyName;
	}
}
