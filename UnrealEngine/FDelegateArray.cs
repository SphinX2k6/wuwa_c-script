using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020009B0 RID: 2480
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.DelegateArray")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FDelegateArray : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06008C48 RID: 35912 RVA: 0x000C8C72 File Offset: 0x000C6E72
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FDelegateArray._ScriptStructPtr != 0) ? FDelegateArray._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.DelegateArray", ref FDelegateArray._ScriptStructPtr);
		}

		// Token: 0x17002101 RID: 8449
		// (get) Token: 0x06008C49 RID: 35913 RVA: 0x000C8C98 File Offset: 0x000C6E98
		// (set) Token: 0x06008C4A RID: 35914 RVA: 0x000C8CDB File Offset: 0x000C6EDB
		public TArray<FPlatformInterfaceDelegate> Delegates
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FPlatformInterfaceDelegate> result;
				if ((result = this._Delegates) == null)
				{
					result = (this._Delegates = new TArray<FPlatformInterfaceDelegate>(base.NativePtr + (IntPtr)FDelegateArray.__PropertyOffset_Delegates, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Delegates.CopyAssign(value);
			}
		}

		// Token: 0x06008C4B RID: 35915 RVA: 0x000C8CE9 File Offset: 0x000C6EE9
		public FDelegateArray()
		{
		}

		// Token: 0x06008C4C RID: 35916 RVA: 0x000C8CF1 File Offset: 0x000C6EF1
		public FDelegateArray(TArray<FPlatformInterfaceDelegate> Delegates)
		{
			this.Delegates = Delegates;
		}

		// Token: 0x06008C4D RID: 35917 RVA: 0x000C8D00 File Offset: 0x000C6F00
		protected override IntPtr GetUStructPtr()
		{
			return FDelegateArray.StaticStruct();
		}

		// Token: 0x06008C4E RID: 35918 RVA: 0x000C8D0C File Offset: 0x000C6F0C
		[NullableContext(2)]
		public FDelegateArray(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06008C4F RID: 35919 RVA: 0x000C8D16 File Offset: 0x000C6F16
		public FDelegateArray(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06008C50 RID: 35920 RVA: 0x000C8D21 File Offset: 0x000C6F21
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FDelegateArray(Pointer, false, true);
		}

		// Token: 0x06008C51 RID: 35921 RVA: 0x000C8D2B File Offset: 0x000C6F2B
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FDelegateArray(Pointer, MemoryOwner);
		}

		// Token: 0x04004295 RID: 17045
		public const string __ObjectPath = "/Script/Engine.DelegateArray";

		// Token: 0x04004296 RID: 17046
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04004297 RID: 17047
		internal static int __PropertyOffset_Delegates;

		// Token: 0x04004298 RID: 17048
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FPlatformInterfaceDelegate> _Delegates;
	}
}
