using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000EC5 RID: 3781
	[UnrealObjectPath("/Script/Engine.NamedColor")]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FNamedColor : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600CCB0 RID: 52400 RVA: 0x0012A3AC File Offset: 0x001285AC
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FNamedColor._ScriptStructPtr != 0) ? FNamedColor._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.NamedColor", ref FNamedColor._ScriptStructPtr);
		}

		// Token: 0x1700301E RID: 12318
		// (get) Token: 0x0600CCB1 RID: 52401 RVA: 0x0012A3D0 File Offset: 0x001285D0
		// (set) Token: 0x0600CCB2 RID: 52402 RVA: 0x0012A3E4 File Offset: 0x001285E4
		public unsafe FColor Value
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNamedColor.__PropertyOffset_Value);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNamedColor.__PropertyOffset_Value) = value;
			}
		}

		// Token: 0x1700301F RID: 12319
		// (get) Token: 0x0600CCB3 RID: 52403 RVA: 0x0012A3F9 File Offset: 0x001285F9
		// (set) Token: 0x0600CCB4 RID: 52404 RVA: 0x0012A40D File Offset: 0x0012860D
		public unsafe FName Name
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNamedColor.__PropertyOffset_Name);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNamedColor.__PropertyOffset_Name) = value;
			}
		}

		// Token: 0x0600CCB5 RID: 52405 RVA: 0x0012A422 File Offset: 0x00128622
		public FNamedColor()
		{
		}

		// Token: 0x0600CCB6 RID: 52406 RVA: 0x0012A42A File Offset: 0x0012862A
		public FNamedColor(FColor Value, FName Name)
		{
			this.Value = Value;
			this.Name = Name;
		}

		// Token: 0x0600CCB7 RID: 52407 RVA: 0x0012A440 File Offset: 0x00128640
		protected override IntPtr GetUStructPtr()
		{
			return FNamedColor.StaticStruct();
		}

		// Token: 0x0600CCB8 RID: 52408 RVA: 0x0012A44C File Offset: 0x0012864C
		[NullableContext(2)]
		public FNamedColor(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600CCB9 RID: 52409 RVA: 0x0012A456 File Offset: 0x00128656
		public FNamedColor(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600CCBA RID: 52410 RVA: 0x0012A461 File Offset: 0x00128661
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FNamedColor(Pointer, false, true);
		}

		// Token: 0x0600CCBB RID: 52411 RVA: 0x0012A46B File Offset: 0x0012866B
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FNamedColor(Pointer, MemoryOwner);
		}

		// Token: 0x04006E36 RID: 28214
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.NamedColor";

		// Token: 0x04006E37 RID: 28215
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04006E38 RID: 28216
		internal static int __PropertyOffset_Value;

		// Token: 0x04006E39 RID: 28217
		internal static int __PropertyOffset_Name;
	}
}
