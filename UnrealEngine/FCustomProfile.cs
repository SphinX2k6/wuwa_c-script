using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200098F RID: 2447
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.CustomProfile")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FCustomProfile : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06008A3B RID: 35387 RVA: 0x000C5F34 File Offset: 0x000C4134
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FCustomProfile._ScriptStructPtr != 0) ? FCustomProfile._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.CustomProfile", ref FCustomProfile._ScriptStructPtr);
		}

		// Token: 0x17002091 RID: 8337
		// (get) Token: 0x06008A3C RID: 35388 RVA: 0x000C5F58 File Offset: 0x000C4158
		// (set) Token: 0x06008A3D RID: 35389 RVA: 0x000C5F6C File Offset: 0x000C416C
		public unsafe FName Name
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCustomProfile.__PropertyOffset_Name);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCustomProfile.__PropertyOffset_Name) = value;
			}
		}

		// Token: 0x17002092 RID: 8338
		// (get) Token: 0x06008A3E RID: 35390 RVA: 0x000C5F84 File Offset: 0x000C4184
		// (set) Token: 0x06008A3F RID: 35391 RVA: 0x000C5FC7 File Offset: 0x000C41C7
		public TArray<FResponseChannel> CustomResponses
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FResponseChannel> result;
				if ((result = this._CustomResponses) == null)
				{
					result = (this._CustomResponses = new TArray<FResponseChannel>(base.NativePtr + (IntPtr)FCustomProfile.__PropertyOffset_CustomResponses, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.CustomResponses.CopyAssign(value);
			}
		}

		// Token: 0x06008A40 RID: 35392 RVA: 0x000C5FD5 File Offset: 0x000C41D5
		public FCustomProfile()
		{
		}

		// Token: 0x06008A41 RID: 35393 RVA: 0x000C5FDD File Offset: 0x000C41DD
		public FCustomProfile(FName Name, TArray<FResponseChannel> CustomResponses)
		{
			this.Name = Name;
			this.CustomResponses = CustomResponses;
		}

		// Token: 0x06008A42 RID: 35394 RVA: 0x000C5FF3 File Offset: 0x000C41F3
		protected override IntPtr GetUStructPtr()
		{
			return FCustomProfile.StaticStruct();
		}

		// Token: 0x06008A43 RID: 35395 RVA: 0x000C5FFF File Offset: 0x000C41FF
		[NullableContext(2)]
		public FCustomProfile(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06008A44 RID: 35396 RVA: 0x000C6009 File Offset: 0x000C4209
		public FCustomProfile(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06008A45 RID: 35397 RVA: 0x000C6014 File Offset: 0x000C4214
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FCustomProfile(Pointer, false, true);
		}

		// Token: 0x06008A46 RID: 35398 RVA: 0x000C601E File Offset: 0x000C421E
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FCustomProfile(Pointer, MemoryOwner);
		}

		// Token: 0x0400419C RID: 16796
		public const string __ObjectPath = "/Script/Engine.CustomProfile";

		// Token: 0x0400419D RID: 16797
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400419E RID: 16798
		internal static int __PropertyOffset_Name;

		// Token: 0x0400419F RID: 16799
		internal static int __PropertyOffset_CustomResponses;

		// Token: 0x040041A0 RID: 16800
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FResponseChannel> _CustomResponses;
	}
}
