using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000C7E RID: 3198
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.InterpGroup")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 96)]
	public class UInterpGroup : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600A25F RID: 41567 RVA: 0x000E6896 File Offset: 0x000E4A96
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UInterpGroup._ClassPtr;
		}

		// Token: 0x0600A260 RID: 41568 RVA: 0x000E68A4 File Offset: 0x000E4AA4
		public UInterpGroup() : this(BuiltinUtils.AllocNativeUObject(UInterpGroup.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600A261 RID: 41569 RVA: 0x000E68CC File Offset: 0x000E4ACC
		public UInterpGroup(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UInterpGroup.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170026A4 RID: 9892
		// (get) Token: 0x0600A262 RID: 41570 RVA: 0x000E6900 File Offset: 0x000E4B00
		// (set) Token: 0x0600A263 RID: 41571 RVA: 0x000E6939 File Offset: 0x000E4B39
		public TArray<UInterpTrack> InterpTracks
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UInterpTrack> result;
				if ((result = this._InterpTracks) == null)
				{
					result = (this._InterpTracks = new TArray<UInterpTrack>(base.NativePtr + (IntPtr)UInterpGroup.__PropertyOffset_InterpTracks, this));
				}
				return result;
			}
			set
			{
				this.InterpTracks.CopyAssign(value);
			}
		}

		// Token: 0x170026A5 RID: 9893
		// (get) Token: 0x0600A264 RID: 41572 RVA: 0x000E6947 File Offset: 0x000E4B47
		// (set) Token: 0x0600A265 RID: 41573 RVA: 0x000E695B File Offset: 0x000E4B5B
		public unsafe FName GroupName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UInterpGroup.__PropertyOffset_GroupName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UInterpGroup.__PropertyOffset_GroupName) = value;
			}
		}

		// Token: 0x170026A6 RID: 9894
		// (get) Token: 0x0600A266 RID: 41574 RVA: 0x000E6970 File Offset: 0x000E4B70
		// (set) Token: 0x0600A267 RID: 41575 RVA: 0x000E6984 File Offset: 0x000E4B84
		public unsafe FColor GroupColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UInterpGroup.__PropertyOffset_GroupColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UInterpGroup.__PropertyOffset_GroupColor) = value;
			}
		}

		// Token: 0x170026A7 RID: 9895
		// (get) Token: 0x0600A268 RID: 41576 RVA: 0x000E6999 File Offset: 0x000E4B99
		// (set) Token: 0x0600A269 RID: 41577 RVA: 0x000E69B2 File Offset: 0x000E4BB2
		public unsafe bool bCollapsed
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UInterpGroup.__PropertyOffset_bCollapsed) & UInterpGroup.__PropertyMask_bCollapsed) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UInterpGroup.__PropertyOffset_bCollapsed) = ((*(base.NativePtr + (IntPtr)UInterpGroup.__PropertyOffset_bCollapsed) & ~UInterpGroup.__PropertyMask_bCollapsed) | (value ? UInterpGroup.__PropertyMask_bCollapsed : 0));
			}
		}

		// Token: 0x170026A8 RID: 9896
		// (get) Token: 0x0600A26A RID: 41578 RVA: 0x000E69E2 File Offset: 0x000E4BE2
		// (set) Token: 0x0600A26B RID: 41579 RVA: 0x000E69FB File Offset: 0x000E4BFB
		public unsafe bool bVisible
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UInterpGroup.__PropertyOffset_bVisible) & UInterpGroup.__PropertyMask_bVisible) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UInterpGroup.__PropertyOffset_bVisible) = ((*(base.NativePtr + (IntPtr)UInterpGroup.__PropertyOffset_bVisible) & ~UInterpGroup.__PropertyMask_bVisible) | (value ? UInterpGroup.__PropertyMask_bVisible : 0));
			}
		}

		// Token: 0x170026A9 RID: 9897
		// (get) Token: 0x0600A26C RID: 41580 RVA: 0x000E6A2B File Offset: 0x000E4C2B
		// (set) Token: 0x0600A26D RID: 41581 RVA: 0x000E6A44 File Offset: 0x000E4C44
		public unsafe bool bIsFolder
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UInterpGroup.__PropertyOffset_bIsFolder) & UInterpGroup.__PropertyMask_bIsFolder) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UInterpGroup.__PropertyOffset_bIsFolder) = ((*(base.NativePtr + (IntPtr)UInterpGroup.__PropertyOffset_bIsFolder) & ~UInterpGroup.__PropertyMask_bIsFolder) | (value ? UInterpGroup.__PropertyMask_bIsFolder : 0));
			}
		}

		// Token: 0x170026AA RID: 9898
		// (get) Token: 0x0600A26E RID: 41582 RVA: 0x000E6A74 File Offset: 0x000E4C74
		// (set) Token: 0x0600A26F RID: 41583 RVA: 0x000E6A8D File Offset: 0x000E4C8D
		public unsafe bool bIsParented
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UInterpGroup.__PropertyOffset_bIsParented) & UInterpGroup.__PropertyMask_bIsParented) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UInterpGroup.__PropertyOffset_bIsParented) = ((*(base.NativePtr + (IntPtr)UInterpGroup.__PropertyOffset_bIsParented) & ~UInterpGroup.__PropertyMask_bIsParented) | (value ? UInterpGroup.__PropertyMask_bIsParented : 0));
			}
		}

		// Token: 0x170026AB RID: 9899
		// (get) Token: 0x0600A270 RID: 41584 RVA: 0x000E6ABD File Offset: 0x000E4CBD
		// (set) Token: 0x0600A271 RID: 41585 RVA: 0x000E6AD6 File Offset: 0x000E4CD6
		public unsafe bool bIsSelected
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UInterpGroup.__PropertyOffset_bIsSelected) & UInterpGroup.__PropertyMask_bIsSelected) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UInterpGroup.__PropertyOffset_bIsSelected) = ((*(base.NativePtr + (IntPtr)UInterpGroup.__PropertyOffset_bIsSelected) & ~UInterpGroup.__PropertyMask_bIsSelected) | (value ? UInterpGroup.__PropertyMask_bIsSelected : 0));
			}
		}

		// Token: 0x0600A272 RID: 41586 RVA: 0x000E6B06 File Offset: 0x000E4D06
		static UInterpGroup()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.InterpGroup");
		}

		// Token: 0x0600A273 RID: 41587 RVA: 0x000E6B14 File Offset: 0x000E4D14
		protected UInterpGroup(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04005918 RID: 22808
		public new const string __ObjectPath = "/Script/Engine.InterpGroup";

		// Token: 0x04005919 RID: 22809
		private static IntPtr _ClassPtr;

		// Token: 0x0400591A RID: 22810
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400591B RID: 22811
		internal static int __PropertyOffset_InterpTracks;

		// Token: 0x0400591C RID: 22812
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UInterpTrack> _InterpTracks;

		// Token: 0x0400591D RID: 22813
		internal static int __PropertyOffset_GroupName;

		// Token: 0x0400591E RID: 22814
		internal static int __PropertyOffset_GroupColor;

		// Token: 0x0400591F RID: 22815
		internal static int __PropertyOffset_bCollapsed;

		// Token: 0x04005920 RID: 22816
		internal static byte __PropertyMask_bCollapsed;

		// Token: 0x04005921 RID: 22817
		internal static int __PropertyOffset_bVisible;

		// Token: 0x04005922 RID: 22818
		internal static byte __PropertyMask_bVisible;

		// Token: 0x04005923 RID: 22819
		internal static int __PropertyOffset_bIsFolder;

		// Token: 0x04005924 RID: 22820
		internal static byte __PropertyMask_bIsFolder;

		// Token: 0x04005925 RID: 22821
		internal static int __PropertyOffset_bIsParented;

		// Token: 0x04005926 RID: 22822
		internal static byte __PropertyMask_bIsParented;

		// Token: 0x04005927 RID: 22823
		internal static int __PropertyOffset_bIsSelected;

		// Token: 0x04005928 RID: 22824
		internal static byte __PropertyMask_bIsSelected;
	}
}
