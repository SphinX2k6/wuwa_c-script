using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020018FC RID: 6396
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroGameplay.KuroParameterArrayVector")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FKuroParameterArrayVector : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06017BCA RID: 97226 RVA: 0x0022C79D File Offset: 0x0022A99D
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroParameterArrayVector._ScriptStructPtr != 0) ? FKuroParameterArrayVector._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroGameplay.KuroParameterArrayVector", ref FKuroParameterArrayVector._ScriptStructPtr);
		}

		// Token: 0x17005F9A RID: 24474
		// (get) Token: 0x06017BCB RID: 97227 RVA: 0x0022C7C1 File Offset: 0x0022A9C1
		// (set) Token: 0x06017BCC RID: 97228 RVA: 0x0022C7D5 File Offset: 0x0022A9D5
		public unsafe FName Name
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroParameterArrayVector.__PropertyOffset_Name);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroParameterArrayVector.__PropertyOffset_Name) = value;
			}
		}

		// Token: 0x17005F9B RID: 24475
		// (get) Token: 0x06017BCD RID: 97229 RVA: 0x0022C7EC File Offset: 0x0022A9EC
		// (set) Token: 0x06017BCE RID: 97230 RVA: 0x0022C82F File Offset: 0x0022AA2F
		public TArray<FVector> Value
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FVector> result;
				if ((result = this._Value) == null)
				{
					result = (this._Value = new TArray<FVector>(base.NativePtr + (IntPtr)FKuroParameterArrayVector.__PropertyOffset_Value, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Value.CopyAssign(value);
			}
		}

		// Token: 0x06017BCF RID: 97231 RVA: 0x0022C83D File Offset: 0x0022AA3D
		public FKuroParameterArrayVector()
		{
		}

		// Token: 0x06017BD0 RID: 97232 RVA: 0x0022C845 File Offset: 0x0022AA45
		public FKuroParameterArrayVector(FName Name, TArray<FVector> Value)
		{
			this.Name = Name;
			this.Value = Value;
		}

		// Token: 0x06017BD1 RID: 97233 RVA: 0x0022C85B File Offset: 0x0022AA5B
		protected override IntPtr GetUStructPtr()
		{
			return FKuroParameterArrayVector.StaticStruct();
		}

		// Token: 0x06017BD2 RID: 97234 RVA: 0x0022C867 File Offset: 0x0022AA67
		[NullableContext(2)]
		public FKuroParameterArrayVector(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06017BD3 RID: 97235 RVA: 0x0022C871 File Offset: 0x0022AA71
		public FKuroParameterArrayVector(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06017BD4 RID: 97236 RVA: 0x0022C87C File Offset: 0x0022AA7C
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroParameterArrayVector(Pointer, false, true);
		}

		// Token: 0x06017BD5 RID: 97237 RVA: 0x0022C886 File Offset: 0x0022AA86
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroParameterArrayVector(Pointer, MemoryOwner);
		}

		// Token: 0x0400CE1C RID: 52764
		public const string __ObjectPath = "/Script/KuroGameplay.KuroParameterArrayVector";

		// Token: 0x0400CE1D RID: 52765
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400CE1E RID: 52766
		internal static int __PropertyOffset_Name;

		// Token: 0x0400CE1F RID: 52767
		internal static int __PropertyOffset_Value;

		// Token: 0x0400CE20 RID: 52768
		[Nullable(2)]
		private TArray<FVector> _Value;
	}
}
