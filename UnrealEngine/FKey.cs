using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001529 RID: 5417
	[HasGetTypeHash]
	[UnrealObjectPath("/Script/InputCore.Key")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FKey : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06013B35 RID: 80693 RVA: 0x001CEF51 File Offset: 0x001CD151
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKey._ScriptStructPtr != 0) ? FKey._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/InputCore.Key", ref FKey._ScriptStructPtr);
		}

		// Token: 0x17004D23 RID: 19747
		// (get) Token: 0x06013B36 RID: 80694 RVA: 0x001CEF75 File Offset: 0x001CD175
		// (set) Token: 0x06013B37 RID: 80695 RVA: 0x001CEF89 File Offset: 0x001CD189
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

		// Token: 0x06013B38 RID: 80696 RVA: 0x001CEF9E File Offset: 0x001CD19E
		public FKey()
		{
		}

		// Token: 0x06013B39 RID: 80697 RVA: 0x001CEFA6 File Offset: 0x001CD1A6
		public FKey(FName KeyName)
		{
			this.KeyName = KeyName;
		}

		// Token: 0x06013B3A RID: 80698 RVA: 0x001CEFB5 File Offset: 0x001CD1B5
		protected override IntPtr GetUStructPtr()
		{
			return FKey.StaticStruct();
		}

		// Token: 0x06013B3B RID: 80699 RVA: 0x001CEFC1 File Offset: 0x001CD1C1
		[NullableContext(2)]
		public FKey(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06013B3C RID: 80700 RVA: 0x001CEFCB File Offset: 0x001CD1CB
		public FKey(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06013B3D RID: 80701 RVA: 0x001CEFD6 File Offset: 0x001CD1D6
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKey(Pointer, false, true);
		}

		// Token: 0x06013B3E RID: 80702 RVA: 0x001CEFE0 File Offset: 0x001CD1E0
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKey(Pointer, MemoryOwner);
		}

		// Token: 0x0400AA5D RID: 43613
		[Nullable(1)]
		public const string __ObjectPath = "/Script/InputCore.Key";

		// Token: 0x0400AA5E RID: 43614
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400AA5F RID: 43615
		internal static int __PropertyOffset_KeyName;
	}
}
