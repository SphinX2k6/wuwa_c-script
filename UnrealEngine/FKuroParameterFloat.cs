using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020018FD RID: 6397
	[UnrealObjectPath("/Script/KuroGameplay.KuroParameterFloat")]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FKuroParameterFloat : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06017BD6 RID: 97238 RVA: 0x0022C88F File Offset: 0x0022AA8F
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroParameterFloat._ScriptStructPtr != 0) ? FKuroParameterFloat._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroGameplay.KuroParameterFloat", ref FKuroParameterFloat._ScriptStructPtr);
		}

		// Token: 0x17005F9C RID: 24476
		// (get) Token: 0x06017BD7 RID: 97239 RVA: 0x0022C8B3 File Offset: 0x0022AAB3
		// (set) Token: 0x06017BD8 RID: 97240 RVA: 0x0022C8C7 File Offset: 0x0022AAC7
		public unsafe FName Name
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroParameterFloat.__PropertyOffset_Name);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroParameterFloat.__PropertyOffset_Name) = value;
			}
		}

		// Token: 0x17005F9D RID: 24477
		// (get) Token: 0x06017BD9 RID: 97241 RVA: 0x0022C8DC File Offset: 0x0022AADC
		// (set) Token: 0x06017BDA RID: 97242 RVA: 0x0022C8EC File Offset: 0x0022AAEC
		public unsafe float Value
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroParameterFloat.__PropertyOffset_Value);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroParameterFloat.__PropertyOffset_Value) = value;
			}
		}

		// Token: 0x06017BDB RID: 97243 RVA: 0x0022C8FD File Offset: 0x0022AAFD
		public FKuroParameterFloat()
		{
		}

		// Token: 0x06017BDC RID: 97244 RVA: 0x0022C905 File Offset: 0x0022AB05
		public FKuroParameterFloat(FName Name, float Value)
		{
			this.Name = Name;
			this.Value = Value;
		}

		// Token: 0x06017BDD RID: 97245 RVA: 0x0022C91B File Offset: 0x0022AB1B
		protected override IntPtr GetUStructPtr()
		{
			return FKuroParameterFloat.StaticStruct();
		}

		// Token: 0x06017BDE RID: 97246 RVA: 0x0022C927 File Offset: 0x0022AB27
		[NullableContext(2)]
		public FKuroParameterFloat(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06017BDF RID: 97247 RVA: 0x0022C931 File Offset: 0x0022AB31
		public FKuroParameterFloat(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06017BE0 RID: 97248 RVA: 0x0022C93C File Offset: 0x0022AB3C
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroParameterFloat(Pointer, false, true);
		}

		// Token: 0x06017BE1 RID: 97249 RVA: 0x0022C946 File Offset: 0x0022AB46
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroParameterFloat(Pointer, MemoryOwner);
		}

		// Token: 0x0400CE21 RID: 52769
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroGameplay.KuroParameterFloat";

		// Token: 0x0400CE22 RID: 52770
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400CE23 RID: 52771
		internal static int __PropertyOffset_Name;

		// Token: 0x0400CE24 RID: 52772
		internal static int __PropertyOffset_Value;
	}
}
