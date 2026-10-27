using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020011B1 RID: 4529
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.StringCurve")]
	[UnrealStructLayout(136, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 136)]
	public class FStringCurve : FIndexedCurve, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06010B3D RID: 68413 RVA: 0x0018867A File Offset: 0x0018687A
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FStringCurve._ScriptStructPtr != 0) ? FStringCurve._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.StringCurve", ref FStringCurve._ScriptStructPtr);
		}

		// Token: 0x1700413E RID: 16702
		// (get) Token: 0x06010B3E RID: 68414 RVA: 0x0018869E File Offset: 0x0018689E
		// (set) Token: 0x06010B3F RID: 68415 RVA: 0x001886B2 File Offset: 0x001868B2
		public unsafe string DefaultValue
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FStringCurve.__PropertyOffset_DefaultValue)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FStringCurve.__PropertyOffset_DefaultValue)), value);
			}
		}

		// Token: 0x1700413F RID: 16703
		// (get) Token: 0x06010B40 RID: 68416 RVA: 0x001886C8 File Offset: 0x001868C8
		// (set) Token: 0x06010B41 RID: 68417 RVA: 0x0018870B File Offset: 0x0018690B
		public TArray<FStringCurveKey> Keys
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FStringCurveKey> result;
				if ((result = this._Keys) == null)
				{
					result = (this._Keys = new TArray<FStringCurveKey>(base.NativePtr + (IntPtr)FStringCurve.__PropertyOffset_Keys, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Keys.CopyAssign(value);
			}
		}

		// Token: 0x06010B42 RID: 68418 RVA: 0x00188719 File Offset: 0x00186919
		public FStringCurve()
		{
		}

		// Token: 0x06010B43 RID: 68419 RVA: 0x00188721 File Offset: 0x00186921
		public FStringCurve(string DefaultValue, TArray<FStringCurveKey> Keys, FKeyHandleMap KeyHandlesToIndices)
		{
			this.DefaultValue = DefaultValue;
			this.Keys = Keys;
			base.KeyHandlesToIndices = KeyHandlesToIndices;
		}

		// Token: 0x06010B44 RID: 68420 RVA: 0x0018873E File Offset: 0x0018693E
		protected override IntPtr GetUStructPtr()
		{
			return FStringCurve.StaticStruct();
		}

		// Token: 0x06010B45 RID: 68421 RVA: 0x0018874A File Offset: 0x0018694A
		[NullableContext(2)]
		public FStringCurve(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06010B46 RID: 68422 RVA: 0x00188754 File Offset: 0x00186954
		public FStringCurve(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06010B47 RID: 68423 RVA: 0x0018875F File Offset: 0x0018695F
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FStringCurve(Pointer, false, true);
		}

		// Token: 0x06010B48 RID: 68424 RVA: 0x00188769 File Offset: 0x00186969
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FStringCurve(Pointer, MemoryOwner);
		}

		// Token: 0x04008EE8 RID: 36584
		public new const string __ObjectPath = "/Script/Engine.StringCurve";

		// Token: 0x04008EE9 RID: 36585
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04008EEA RID: 36586
		internal static int __PropertyOffset_DefaultValue;

		// Token: 0x04008EEB RID: 36587
		internal static int __PropertyOffset_Keys;

		// Token: 0x04008EEC RID: 36588
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FStringCurveKey> _Keys;
	}
}
