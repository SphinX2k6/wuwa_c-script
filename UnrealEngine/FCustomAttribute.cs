using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000986 RID: 2438
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.CustomAttribute")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FCustomAttribute : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060089CE RID: 35278 RVA: 0x000C5701 File Offset: 0x000C3901
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FCustomAttribute._ScriptStructPtr != 0) ? FCustomAttribute._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.CustomAttribute", ref FCustomAttribute._ScriptStructPtr);
		}

		// Token: 0x1700207D RID: 8317
		// (get) Token: 0x060089CF RID: 35279 RVA: 0x000C5725 File Offset: 0x000C3925
		// (set) Token: 0x060089D0 RID: 35280 RVA: 0x000C5739 File Offset: 0x000C3939
		public unsafe FName Name
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCustomAttribute.__PropertyOffset_Name);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCustomAttribute.__PropertyOffset_Name) = value;
			}
		}

		// Token: 0x1700207E RID: 8318
		// (get) Token: 0x060089D1 RID: 35281 RVA: 0x000C574E File Offset: 0x000C394E
		// (set) Token: 0x060089D2 RID: 35282 RVA: 0x000C575E File Offset: 0x000C395E
		public unsafe int VariantType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCustomAttribute.__PropertyOffset_VariantType);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCustomAttribute.__PropertyOffset_VariantType) = value;
			}
		}

		// Token: 0x1700207F RID: 8319
		// (get) Token: 0x060089D3 RID: 35283 RVA: 0x000C5770 File Offset: 0x000C3970
		// (set) Token: 0x060089D4 RID: 35284 RVA: 0x000C57B3 File Offset: 0x000C39B3
		public TArray<float> Times
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._Times) == null)
				{
					result = (this._Times = new TArray<float>(base.NativePtr + (IntPtr)FCustomAttribute.__PropertyOffset_Times, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Times.CopyAssign(value);
			}
		}

		// Token: 0x060089D5 RID: 35285 RVA: 0x000C57C1 File Offset: 0x000C39C1
		public FCustomAttribute()
		{
		}

		// Token: 0x060089D6 RID: 35286 RVA: 0x000C57C9 File Offset: 0x000C39C9
		public FCustomAttribute(FName Name, int VariantType, TArray<float> Times)
		{
			this.Name = Name;
			this.VariantType = VariantType;
			this.Times = Times;
		}

		// Token: 0x060089D7 RID: 35287 RVA: 0x000C57E6 File Offset: 0x000C39E6
		protected override IntPtr GetUStructPtr()
		{
			return FCustomAttribute.StaticStruct();
		}

		// Token: 0x060089D8 RID: 35288 RVA: 0x000C57F2 File Offset: 0x000C39F2
		[NullableContext(2)]
		public FCustomAttribute(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060089D9 RID: 35289 RVA: 0x000C57FC File Offset: 0x000C39FC
		public FCustomAttribute(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060089DA RID: 35290 RVA: 0x000C5807 File Offset: 0x000C3A07
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FCustomAttribute(Pointer, false, true);
		}

		// Token: 0x060089DB RID: 35291 RVA: 0x000C5811 File Offset: 0x000C3A11
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FCustomAttribute(Pointer, MemoryOwner);
		}

		// Token: 0x04004170 RID: 16752
		public const string __ObjectPath = "/Script/Engine.CustomAttribute";

		// Token: 0x04004171 RID: 16753
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04004172 RID: 16754
		internal static int __PropertyOffset_Name;

		// Token: 0x04004173 RID: 16755
		internal static int __PropertyOffset_VariantType;

		// Token: 0x04004174 RID: 16756
		internal static int __PropertyOffset_Times;

		// Token: 0x04004175 RID: 16757
		[Nullable(2)]
		private TArray<float> _Times;
	}
}
