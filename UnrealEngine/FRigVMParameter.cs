using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020026CA RID: 9930
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/RigVM.RigVMParameter")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class FRigVMParameter : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06024DD2 RID: 150994 RVA: 0x00368876 File Offset: 0x00366A76
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigVMParameter._ScriptStructPtr != 0) ? FRigVMParameter._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/RigVM.RigVMParameter", ref FRigVMParameter._ScriptStructPtr);
		}

		// Token: 0x17008E5C RID: 36444
		// (get) Token: 0x06024DD3 RID: 150995 RVA: 0x0036889A File Offset: 0x00366A9A
		// (set) Token: 0x06024DD4 RID: 150996 RVA: 0x003688AA File Offset: 0x00366AAA
		public unsafe ERigVMParameterType Type
		{
			get
			{
				return (ERigVMParameterType)(*(base.NativePtr + (IntPtr)FRigVMParameter.__PropertyOffset_Type));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigVMParameter.__PropertyOffset_Type) = (byte)value;
			}
		}

		// Token: 0x17008E5D RID: 36445
		// (get) Token: 0x06024DD5 RID: 150997 RVA: 0x003688BB File Offset: 0x00366ABB
		// (set) Token: 0x06024DD6 RID: 150998 RVA: 0x003688CF File Offset: 0x00366ACF
		public unsafe FName Name
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigVMParameter.__PropertyOffset_Name);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigVMParameter.__PropertyOffset_Name) = value;
			}
		}

		// Token: 0x17008E5E RID: 36446
		// (get) Token: 0x06024DD7 RID: 150999 RVA: 0x003688E4 File Offset: 0x00366AE4
		// (set) Token: 0x06024DD8 RID: 151000 RVA: 0x003688F4 File Offset: 0x00366AF4
		public unsafe int RegisterIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigVMParameter.__PropertyOffset_RegisterIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigVMParameter.__PropertyOffset_RegisterIndex) = value;
			}
		}

		// Token: 0x17008E5F RID: 36447
		// (get) Token: 0x06024DD9 RID: 151001 RVA: 0x00368905 File Offset: 0x00366B05
		// (set) Token: 0x06024DDA RID: 151002 RVA: 0x00368919 File Offset: 0x00366B19
		public unsafe string CPPType
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FRigVMParameter.__PropertyOffset_CPPType)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FRigVMParameter.__PropertyOffset_CPPType)), value);
			}
		}

		// Token: 0x17008E60 RID: 36448
		// (get) Token: 0x06024DDB RID: 151003 RVA: 0x0036892E File Offset: 0x00366B2E
		// (set) Token: 0x06024DDC RID: 151004 RVA: 0x00368942 File Offset: 0x00366B42
		[Nullable(2)]
		public unsafe UScriptStruct ScriptStruct
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UScriptStruct>(base.NativePtr / (IntPtr)sizeof(void*) + FRigVMParameter.__PropertyOffset_ScriptStruct);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FRigVMParameter.__PropertyOffset_ScriptStruct, value);
			}
		}

		// Token: 0x17008E61 RID: 36449
		// (get) Token: 0x06024DDD RID: 151005 RVA: 0x00368957 File Offset: 0x00366B57
		// (set) Token: 0x06024DDE RID: 151006 RVA: 0x0036896B File Offset: 0x00366B6B
		public unsafe FName ScriptStructPath
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigVMParameter.__PropertyOffset_ScriptStructPath);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigVMParameter.__PropertyOffset_ScriptStructPath) = value;
			}
		}

		// Token: 0x06024DDF RID: 151007 RVA: 0x00368980 File Offset: 0x00366B80
		public FRigVMParameter()
		{
		}

		// Token: 0x06024DE0 RID: 151008 RVA: 0x00368988 File Offset: 0x00366B88
		public FRigVMParameter(ERigVMParameterType Type, FName Name, int RegisterIndex, string CPPType, UScriptStruct ScriptStruct, FName ScriptStructPath)
		{
			this.Type = Type;
			this.Name = Name;
			this.RegisterIndex = RegisterIndex;
			this.CPPType = CPPType;
			this.ScriptStruct = ScriptStruct;
			this.ScriptStructPath = ScriptStructPath;
		}

		// Token: 0x06024DE1 RID: 151009 RVA: 0x003689BD File Offset: 0x00366BBD
		protected override IntPtr GetUStructPtr()
		{
			return FRigVMParameter.StaticStruct();
		}

		// Token: 0x06024DE2 RID: 151010 RVA: 0x003689C9 File Offset: 0x00366BC9
		[NullableContext(2)]
		public FRigVMParameter(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06024DE3 RID: 151011 RVA: 0x003689D3 File Offset: 0x00366BD3
		public FRigVMParameter(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06024DE4 RID: 151012 RVA: 0x003689DE File Offset: 0x00366BDE
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigVMParameter(Pointer, false, true);
		}

		// Token: 0x06024DE5 RID: 151013 RVA: 0x003689E8 File Offset: 0x00366BE8
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigVMParameter(Pointer, MemoryOwner);
		}

		// Token: 0x04013DC4 RID: 81348
		public const string __ObjectPath = "/Script/RigVM.RigVMParameter";

		// Token: 0x04013DC5 RID: 81349
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04013DC6 RID: 81350
		internal static int __PropertyOffset_Type;

		// Token: 0x04013DC7 RID: 81351
		internal static int __PropertyOffset_Name;

		// Token: 0x04013DC8 RID: 81352
		internal static int __PropertyOffset_RegisterIndex;

		// Token: 0x04013DC9 RID: 81353
		internal static int __PropertyOffset_CPPType;

		// Token: 0x04013DCA RID: 81354
		internal static int __PropertyOffset_ScriptStruct;

		// Token: 0x04013DCB RID: 81355
		internal static int __PropertyOffset_ScriptStructPath;
	}
}
