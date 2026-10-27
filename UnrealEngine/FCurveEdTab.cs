using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200097B RID: 2427
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.CurveEdTab")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FCurveEdTab : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600894E RID: 35150 RVA: 0x000C499E File Offset: 0x000C2B9E
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FCurveEdTab._ScriptStructPtr != 0) ? FCurveEdTab._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.CurveEdTab", ref FCurveEdTab._ScriptStructPtr);
		}

		// Token: 0x17002064 RID: 8292
		// (get) Token: 0x0600894F RID: 35151 RVA: 0x000C49C2 File Offset: 0x000C2BC2
		// (set) Token: 0x06008950 RID: 35152 RVA: 0x000C49D6 File Offset: 0x000C2BD6
		public unsafe string TabName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FCurveEdTab.__PropertyOffset_TabName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FCurveEdTab.__PropertyOffset_TabName)), value);
			}
		}

		// Token: 0x17002065 RID: 8293
		// (get) Token: 0x06008951 RID: 35153 RVA: 0x000C49EC File Offset: 0x000C2BEC
		// (set) Token: 0x06008952 RID: 35154 RVA: 0x000C4A2F File Offset: 0x000C2C2F
		public TArray<FCurveEdEntry> Curves
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FCurveEdEntry> result;
				if ((result = this._Curves) == null)
				{
					result = (this._Curves = new TArray<FCurveEdEntry>(base.NativePtr + (IntPtr)FCurveEdTab.__PropertyOffset_Curves, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Curves.CopyAssign(value);
			}
		}

		// Token: 0x17002066 RID: 8294
		// (get) Token: 0x06008953 RID: 35155 RVA: 0x000C4A3D File Offset: 0x000C2C3D
		// (set) Token: 0x06008954 RID: 35156 RVA: 0x000C4A4D File Offset: 0x000C2C4D
		public unsafe float ViewStartInput
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCurveEdTab.__PropertyOffset_ViewStartInput);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCurveEdTab.__PropertyOffset_ViewStartInput) = value;
			}
		}

		// Token: 0x17002067 RID: 8295
		// (get) Token: 0x06008955 RID: 35157 RVA: 0x000C4A5E File Offset: 0x000C2C5E
		// (set) Token: 0x06008956 RID: 35158 RVA: 0x000C4A6E File Offset: 0x000C2C6E
		public unsafe float ViewEndInput
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCurveEdTab.__PropertyOffset_ViewEndInput);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCurveEdTab.__PropertyOffset_ViewEndInput) = value;
			}
		}

		// Token: 0x17002068 RID: 8296
		// (get) Token: 0x06008957 RID: 35159 RVA: 0x000C4A7F File Offset: 0x000C2C7F
		// (set) Token: 0x06008958 RID: 35160 RVA: 0x000C4A8F File Offset: 0x000C2C8F
		public unsafe float ViewStartOutput
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCurveEdTab.__PropertyOffset_ViewStartOutput);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCurveEdTab.__PropertyOffset_ViewStartOutput) = value;
			}
		}

		// Token: 0x17002069 RID: 8297
		// (get) Token: 0x06008959 RID: 35161 RVA: 0x000C4AA0 File Offset: 0x000C2CA0
		// (set) Token: 0x0600895A RID: 35162 RVA: 0x000C4AB0 File Offset: 0x000C2CB0
		public unsafe float ViewEndOutput
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCurveEdTab.__PropertyOffset_ViewEndOutput);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCurveEdTab.__PropertyOffset_ViewEndOutput) = value;
			}
		}

		// Token: 0x0600895B RID: 35163 RVA: 0x000C4AC1 File Offset: 0x000C2CC1
		public FCurveEdTab()
		{
		}

		// Token: 0x0600895C RID: 35164 RVA: 0x000C4AC9 File Offset: 0x000C2CC9
		public FCurveEdTab(string TabName, TArray<FCurveEdEntry> Curves, float ViewStartInput, float ViewEndInput, float ViewStartOutput, float ViewEndOutput)
		{
			this.TabName = TabName;
			this.Curves = Curves;
			this.ViewStartInput = ViewStartInput;
			this.ViewEndInput = ViewEndInput;
			this.ViewStartOutput = ViewStartOutput;
			this.ViewEndOutput = ViewEndOutput;
		}

		// Token: 0x0600895D RID: 35165 RVA: 0x000C4AFE File Offset: 0x000C2CFE
		protected override IntPtr GetUStructPtr()
		{
			return FCurveEdTab.StaticStruct();
		}

		// Token: 0x0600895E RID: 35166 RVA: 0x000C4B0A File Offset: 0x000C2D0A
		[NullableContext(2)]
		public FCurveEdTab(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600895F RID: 35167 RVA: 0x000C4B14 File Offset: 0x000C2D14
		public FCurveEdTab(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06008960 RID: 35168 RVA: 0x000C4B1F File Offset: 0x000C2D1F
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FCurveEdTab(Pointer, false, true);
		}

		// Token: 0x06008961 RID: 35169 RVA: 0x000C4B29 File Offset: 0x000C2D29
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FCurveEdTab(Pointer, MemoryOwner);
		}

		// Token: 0x04004137 RID: 16695
		public const string __ObjectPath = "/Script/Engine.CurveEdTab";

		// Token: 0x04004138 RID: 16696
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04004139 RID: 16697
		internal static int __PropertyOffset_TabName;

		// Token: 0x0400413A RID: 16698
		internal static int __PropertyOffset_Curves;

		// Token: 0x0400413B RID: 16699
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FCurveEdEntry> _Curves;

		// Token: 0x0400413C RID: 16700
		internal static int __PropertyOffset_ViewStartInput;

		// Token: 0x0400413D RID: 16701
		internal static int __PropertyOffset_ViewEndInput;

		// Token: 0x0400413E RID: 16702
		internal static int __PropertyOffset_ViewStartOutput;

		// Token: 0x0400413F RID: 16703
		internal static int __PropertyOffset_ViewEndOutput;
	}
}
