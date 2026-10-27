using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002844 RID: 10308
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Slate.CustomizedToolMenuNameArray")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FCustomizedToolMenuNameArray : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060264DF RID: 156895 RVA: 0x003A2F36 File Offset: 0x003A1136
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FCustomizedToolMenuNameArray._ScriptStructPtr != 0) ? FCustomizedToolMenuNameArray._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Slate.CustomizedToolMenuNameArray", ref FCustomizedToolMenuNameArray._ScriptStructPtr);
		}

		// Token: 0x170093E6 RID: 37862
		// (get) Token: 0x060264E0 RID: 156896 RVA: 0x003A2F5C File Offset: 0x003A115C
		// (set) Token: 0x060264E1 RID: 156897 RVA: 0x003A2F9F File Offset: 0x003A119F
		public TArray<FName> Names
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._Names) == null)
				{
					result = (this._Names = new TArray<FName>(base.NativePtr + (IntPtr)FCustomizedToolMenuNameArray.__PropertyOffset_Names, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Names.CopyAssign(value);
			}
		}

		// Token: 0x060264E2 RID: 156898 RVA: 0x003A2FAD File Offset: 0x003A11AD
		public FCustomizedToolMenuNameArray()
		{
		}

		// Token: 0x060264E3 RID: 156899 RVA: 0x003A2FB5 File Offset: 0x003A11B5
		public FCustomizedToolMenuNameArray(TArray<FName> Names)
		{
			this.Names = Names;
		}

		// Token: 0x060264E4 RID: 156900 RVA: 0x003A2FC4 File Offset: 0x003A11C4
		protected override IntPtr GetUStructPtr()
		{
			return FCustomizedToolMenuNameArray.StaticStruct();
		}

		// Token: 0x060264E5 RID: 156901 RVA: 0x003A2FD0 File Offset: 0x003A11D0
		[NullableContext(2)]
		public FCustomizedToolMenuNameArray(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060264E6 RID: 156902 RVA: 0x003A2FDA File Offset: 0x003A11DA
		public FCustomizedToolMenuNameArray(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060264E7 RID: 156903 RVA: 0x003A2FE5 File Offset: 0x003A11E5
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FCustomizedToolMenuNameArray(Pointer, false, true);
		}

		// Token: 0x060264E8 RID: 156904 RVA: 0x003A2FEF File Offset: 0x003A11EF
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FCustomizedToolMenuNameArray(Pointer, MemoryOwner);
		}

		// Token: 0x04014F95 RID: 85909
		public const string __ObjectPath = "/Script/Slate.CustomizedToolMenuNameArray";

		// Token: 0x04014F96 RID: 85910
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04014F97 RID: 85911
		internal static int __PropertyOffset_Names;

		// Token: 0x04014F98 RID: 85912
		[Nullable(2)]
		private TArray<FName> _Names;
	}
}
